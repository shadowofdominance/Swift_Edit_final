using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Swift_Edit
{
    public partial class FormAI : Form
    {
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 1;
            const int HTCAPTION = 2;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);

                if ((int)m.Result == HTCLIENT)
                {
                    m.Result = (IntPtr)HTCAPTION;
                    return;
                }

                return;
            }

            base.WndProc(ref m);
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        bool placeholderactive = true;

        public FormAI()
        {
            InitializeComponent();
        }

        private void close_picturebox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void send_btn_Click(object sender, EventArgs e)
        {
            string prompt = prompt_textbox.Text.Trim();

            if (string.IsNullOrEmpty(prompt))
            {
                MessageBox.Show("Please enter a prompt.");
                return;
            }

            send_btn.Enabled = false;
            send_btn.Text = "Thinking...";

            string response = await SendPromptToOllama(prompt);
            response_textbox.AppendText("You: " + prompt + Environment.NewLine);
            response_textbox.AppendText("AI: " + response + Environment.NewLine + Environment.NewLine);

            send_btn.Enabled = true;
            send_btn.Text = "Send";

            prompt_textbox.Clear();
            placeholderactive = true;
            prompt_textbox.Text = "Ask me anything...";
        }

        private void copy_btn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(response_textbox.Text);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            response_textbox.Clear();
        }

        private void prompt_textbox_Click(object sender, EventArgs e)
        {
            if (placeholderactive)
            {
                prompt_textbox.Text = string.Empty;
                placeholderactive = false;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Clicks == 2)
                {
                    this.WindowState = this.WindowState == FormWindowState.Normal
                        ? FormWindowState.Maximized
                        : FormWindowState.Normal;
                }
                else
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

        private async Task<string> SendPromptToOllama(string prompt)
        {
            if (!await IsOllamaRunningAsync())
                return "[Error] Ollama is not running. Please start Ollama and try again.";

            using (HttpClient client = new HttpClient())
            {
                var requestBody = new
                {
                    model = "llama3",
                    prompt = prompt,
                    stream = false
                };

                string json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync("http://localhost:11434/api/generate", content);
                    response.EnsureSuccessStatusCode();

                    string responseJson = await response.Content.ReadAsStringAsync();
                    dynamic result = JsonConvert.DeserializeObject(responseJson);

                    return result.response.ToString().Trim();
                }
                catch (Exception ex)
                {
                    return $"[Ollama Error]: {ex.Message}";
                }
            }
        }


        private async Task<bool> IsOllamaRunningAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync("http://localhost:11434/api/tags");
                    response.EnsureSuccessStatusCode();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}