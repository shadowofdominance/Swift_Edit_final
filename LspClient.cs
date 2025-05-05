using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class LspClient
{
    private Process _lspProcess;
    private StreamWriter _input;
    private StreamReader _output;
    private int _idCounter = 1;

    /// <summary>
    /// Starts the LSP server (e.g., pyright-langserver) with --stdio.
    /// </summary>
    /// <param name="serverExe">Path to the LSP executable (e.g., pyright-langserver.cmd).</param>
    /// <param name="serverArgs">Optional arguments (default: "--stdio").</param>
    public async Task StartAsync(string serverExe, string serverArgs = "--stdio")
    {
        if (!File.Exists(serverExe))
        {
            throw new FileNotFoundException("LSP server not found at: " + serverExe);
        }

        var psi = new ProcessStartInfo
        {
            FileName = serverExe,
            Arguments = serverArgs,
            RedirectStandardInput = true,
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true,
            WorkingDirectory = Path.GetDirectoryName(serverExe) // important if using relative paths
        };

        _lspProcess = new Process { StartInfo = psi };
        _lspProcess.Start();
        _input = _lspProcess.StandardInput;
        _output = _lspProcess.StandardOutput;

        await SendInitializeAsync();
    }

    /// <summary>
    /// Sends the LSP "initialize" request.
    /// </summary>
    private async Task SendInitializeAsync()
    {
        var request = new
        {
            jsonrpc = "2.0",
            id = _idCounter++,
            method = "initialize",
            @params = new
            {
                processId = Process.GetCurrentProcess().Id,
                rootUri = (string)null,
                capabilities = new { }
            }
        };

        await SendMessageAsync(request);
        await ReadResponseAsync(); // init response
    }

    /// <summary>
    /// Notifies the server that a document is opened.
    /// </summary>
    public async Task SendDidOpenAsync(string uri, string languageId, string text)
    {
        var request = new
        {
            jsonrpc = "2.0",
            method = "textDocument/didOpen",
            @params = new
            {
                textDocument = new
                {
                    uri = uri,
                    languageId = languageId,
                    version = 1,
                    text = text
                }
            }
        };

        await SendMessageAsync(request);
    }

    /// <summary>
    /// Requests full semantic tokens from the LSP.
    /// </summary>
    public async Task<JObject> RequestSemanticTokensAsync(string uri)
    {
        var request = new
        {
            jsonrpc = "2.0",
            id = _idCounter++,
            method = "textDocument/semanticTokens/full",
            @params = new
            {
                textDocument = new { uri = uri }
            }
        };

        await SendMessageAsync(request);
        return await ReadResponseAsync();
    }

    /// <summary>
    /// Sends a JSON-RPC message to the LSP server.
    /// </summary>
    private async Task SendMessageAsync(object message)
    {
        string json = JsonConvert.SerializeObject(message);
        string fullMessage = $"Content-Length: {Encoding.UTF8.GetByteCount(json)}\r\n\r\n{json}";

        await _input.WriteAsync(fullMessage);
        await _input.FlushAsync();
    }

    /// <summary>
    /// Reads and parses a JSON-RPC response from the LSP server.
    /// </summary>
    private async Task<JObject> ReadResponseAsync()
    {
        // Read "Content-Length: xxx"
        string header = await _output.ReadLineAsync();
        if (string.IsNullOrWhiteSpace(header) || !header.StartsWith("Content-Length:"))
            return null;

        int contentLength = int.Parse(header.Substring("Content-Length:".Length).Trim());

        // Read the blank line
        await _output.ReadLineAsync();

        // Read JSON body
        char[] buffer = new char[contentLength];
        await _output.ReadAsync(buffer, 0, contentLength);

        string json = new string(buffer);
        return JObject.Parse(json);
    }

    /// <summary>
    /// Stops the LSP server process cleanly.
    /// </summary>
    public void Stop()
    {
        if (!_lspProcess.HasExited)
        {
            _lspProcess.Kill(true);
            _lspProcess.Dispose();
        }
    }
}
