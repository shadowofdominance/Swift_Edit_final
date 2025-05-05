using Newtonsoft.Json.Linq;
using ReaLTaiizor.Controls;
using Swift_Edit.Properties;
using SwiftEdit;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using WinFormsTabPage = System.Windows.Forms.TabPage;

namespace Swift_Edit
{
    public partial class devmode_form : Form
    {
        public devmode_form()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        //*****************************
        //Variable Declarations section Start
        //*****************************

        private LspClient lspClient = new LspClient();
        private recentfilemanagerdevmode recentfilemgr = new recentfilemanagerdevmode();
        private Process terminalProcess;
        bool menuExpand = false;
        bool recentmenuExpand = false;
        bool sidebarExpand = true;
        bool switchmodeExpand = true;
        bool placeholderActive = true;
        bool fileexplorer_expand = true;
        bool placeholder = false;
        int step1 = 40;
        int step2 = 25;
        List<string> expandedPaths = new List<string>();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        const int WM_VSCROLL = 0x115;
        const int SB_THUMBPOSITION = 4;
        private const int SB_VERT = 1;

        //*****************************
        //Variable Declarations section End
        //*****************************

        //*****************************
        //Functions for the enabling of dragging of window start
        //*****************************
        [DllImport("user32.dll")]
        private static extern int GetScrollPos(IntPtr hWnd, int nBar);

        [DllImport("user32.dll")]
        private static extern int SetScrollPos(IntPtr hWnd, int nBar, int nPos, bool bRedraw);

        // These two functions allow dragging
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        //*****************************
        //Functions for the enabling of dragging of window end
        //*****************************


        //*****************************
        //User defined functions start
        //*****************************
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
        private void LoadRecentFilesToUI()
        {
            recentfilemgr.LoadRecentFiles(recentfile_listbox);
        }
        public void UpdateFooter()
        {
            if (tabControl1.SelectedTab != null && tabControl1.SelectedTab.Controls.Count > 0)
            {
                // Find the RichTextBox/TextBox inside the current tab
                var currentTextArea = tabControl1.SelectedTab.Controls
                                        .OfType<RichTextBox>()
                                        .FirstOrDefault(); // or TextBox if you're using that

                if (currentTextArea != null)
                {
                    string text = currentTextArea.Text;

                    int wordCount = 0;
                    if (!string.IsNullOrWhiteSpace(text))
                    {
                        wordCount = text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
                    }

                    int lineCount = currentTextArea.Lines.Length;

                    int characterCount = 0;
                    if (!string.IsNullOrWhiteSpace(text))
                    {
                        characterCount = text.Count(c => !char.IsWhiteSpace(c));
                    }

                    // Update Labels
                    wordcount_label.Text = $"Words: {wordCount}";
                    linecount_label.Text = $"Lines: {lineCount}";
                    charactercount_label.Text = $"Characters: {characterCount}";
                }
            }
        }
        private void CloseCurrentFile()
        {
            try
            {
                if (tabControl1.TabCount == 0)
                {
                    MessageBox.Show("There are no files open to close.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                WinFormsTabPage currentTab = tabControl1.SelectedTab;
                if (currentTab.Tag is bool isSaved && !isSaved)
                {
                    DialogResult result = MessageBox.Show("The current file has unsaved changes. Do you still want to close it?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                        return;
                }

                tabControl1.TabPages.Remove(currentTab);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while closing the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateLineNumbers()
        {
            int firstLine = textarea.GetLineFromCharIndex(0);
            int totalLines = textarea.Lines.Length;

            StringBuilder lineNumbers = new StringBuilder();
            for (int i = 1; i <= totalLines; i++)
            {
                lineNumbers.AppendLine(i.ToString());
            }

            linenumber_richtextbox.Text = lineNumbers.ToString();
        }

        private void HighlightTokens(JArray tokens)
        {
            int line = 0, charPos = 0;

            for (int i = 0; i < tokens.Count; i += 5)
            {
                int deltaLine = (int)tokens[i];
                int deltaChar = (int)tokens[i + 1];
                int length = (int)tokens[i + 2];
                int tokenType = (int)tokens[i + 3];
                // int tokenModifiers = (int)tokens[i + 4];

                line += deltaLine;
                charPos = (deltaLine == 0) ? charPos + deltaChar : deltaChar;

                int startIndex = GetCharIndexFromLineAndColumn(line, charPos);
                textarea.Select(startIndex, length);
                textarea.SelectionColor = GetColorForTokenType(tokenType);
            }

            textarea.Select(0, 0); // reset selection
        }

        private int GetCharIndexFromLineAndColumn(int line, int column)
        {
            string[] lines = textarea.Lines;
            int index = 0;
            for (int i = 0; i < line; i++)
            {
                index += lines[i].Length + 1; // +1 for newline
            }
            return index + column;
        }

        private Color GetColorForTokenType(int tokenType)
        {
            // Pyright LSP token types: https://microsoft.github.io/language-server-protocol/specifications/lsp/3.17/specification/#semanticTokenTypes
            return tokenType switch
            {
                0 => Color.Blue,       // namespace
                1 => Color.DarkCyan,   // type
                2 => Color.DarkGreen,  // class
                3 => Color.Orange,     // enum
                4 => Color.Purple,     // interface
                5 => Color.Red,        // function
                6 => Color.Brown,      // variable
                _ => Color.Gray
            };
        }
        void CollectExpanded(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.IsExpanded)
                    expandedPaths.Add(node.Tag.ToString());

                CollectExpanded(node.Nodes);
            }
        }
        void RestoreExpanded(TreeNodeCollection nodes, List<string> paths)
        {
            foreach (TreeNode node in nodes)
            {
                if (paths.Contains(node.Tag.ToString()))
                    node.Expand();

                RestoreExpanded(node.Nodes, paths);
            }
        }

        void LoadDirectory(string dir, TreeNodeCollection nodes)
        {
            DirectoryInfo di = new DirectoryInfo(dir);

            TreeNode dirNode = nodes.Add(di.Name);
            dirNode.Tag = di.FullName;

            foreach (var subDir in di.GetDirectories())
            {
                LoadDirectory(subDir.FullName, dirNode.Nodes);
            }

            foreach (var file in di.GetFiles())
            {
                TreeNode fileNode = dirNode.Nodes.Add(file.Name);
                fileNode.Tag = file.FullName;
            }
        }
        private void LaunchPowerShell()
        {
            try
            {
                terminalProcess = new Process();
                terminalProcess.StartInfo.FileName = "powershell.exe";
                terminalProcess.StartInfo.UseShellExecute = false;
                terminalProcess.StartInfo.RedirectStandardInput = true;
                terminalProcess.StartInfo.RedirectStandardOutput = true;
                terminalProcess.StartInfo.RedirectStandardError = true;
                terminalProcess.StartInfo.CreateNoWindow = true;

                terminalProcess.OutputDataReceived += (s, e) =>
                {
                    if (e.Data != null)
                    {
                        outputTerminal.Invoke((MethodInvoker)(() =>
                        {
                            terminalProcess.StartInfo.Arguments = "-NoExit";
                            outputTerminal.AppendText(e.Data + Environment.NewLine);
                            outputTerminal.SelectionStart = outputTerminal.Text.Length;
                            outputTerminal.ScrollToCaret();
                        }));
                    }
                };

                terminalProcess.ErrorDataReceived += (s, e) =>
                {
                    if (e.Data != null)
                    {
                        outputTerminal.Invoke((MethodInvoker)(() =>
                        {
                            outputTerminal.AppendText("ERROR: " + e.Data + Environment.NewLine);
                            outputTerminal.SelectionStart = outputTerminal.Text.Length;
                            outputTerminal.ScrollToCaret();
                        }));
                    }
                };

                try
                {
                    terminalProcess.Start();
                    terminalProcess.BeginOutputReadLine();
                    terminalProcess.BeginErrorReadLine();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to start terminal:\n" + ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to start PowerShell process:\n" + ex.Message);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.Alt | Keys.A:
                    FormAI formAI = new FormAI();
                    formAI.ShowDialog();
                    return true;

                case Keys.Control | Keys.N:
                    fileoperations.NewFile(tabControl1, textarea);
                    return true;

                case Keys.Control | Keys.O:
                    string filePath = fileoperations.OpenFile(tabControl1, textarea);
                    if (!string.IsNullOrEmpty(filePath))
                        recentfilemgr.AddRecentFile(filePath, recentfile_listbox);
                    return true;

                case Keys.Control | Keys.S:
                    fileoperations.SaveFile(tabControl1);
                    return true;

                case Keys.Control | Keys.Shift | Keys.S:
                    fileoperations.SaveFileAs(tabControl1);
                    return true;

                case Keys.Control | Keys.F:
                    var currentTextArea = tabControl1.SelectedTab?.Controls.OfType<RichTextBox>().FirstOrDefault();
                    if (currentTextArea != null)
                    {
                        FindReplaceForm findForm = new FindReplaceForm(currentTextArea);
                        findForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("No active text area found.");
                    }
                    return true;

                case Keys.Control | Keys.Alt | Keys.R:
                    sidebarTransition.Start();
                    recentfiles_Transition.Start();
                    return true;

                case Keys.Control | Keys.Alt | Keys.S:
                    Settings settings = new Settings();
                    settings.Show();
                    return true;

                case Keys.Control | Keys.Alt | Keys.C:
                    fileoperations.CloseAllTabs(tabControl1);
                    return true;

                case Keys.Control | Keys.Alt | Keys.X:
                    fileoperations.CloseApplication(tabControl1);
                    return true;

                case Keys.Control | Keys.Z:
                    if (textarea.CanUndo)
                        textarea.Undo();
                    return true;

                case Keys.Control | Keys.Y:
                    if (textarea.CanRedo)
                        textarea.Redo();
                    return true;

                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        //*****************************
        //User defined functions end
        //*****************************

        //*****************************
        //Functions called from the designer!
        //*****************************
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                filemenupanel.Height += step1;
                if (filemenupanel.Height >= 610)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }

            }
            else
            {
                filemenupanel.Height -= step1;
                if (filemenupanel.Height <= 70)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarpanel.Width += step2;
                if (sidebarpanel.Width >= 315)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebarpanel.Width -= step2;
                if (sidebarpanel.Width <= 69)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void mainfilemenu_btn_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void modetransition_Tick(object sender, EventArgs e)
        {
            if (switchmodeExpand)
            {
                switchmode_layoutpanel.Width += 20;
                if (switchmode_layoutpanel.Width >= 703)
                {
                    switchmodeExpand = false;
                    modetransition.Stop();
                }
            }
            else
            {
                switchmode_layoutpanel.Width -= 20;
                if (switchmode_layoutpanel.Width <= 209)
                {
                    switchmodeExpand = true;
                    modetransition.Stop();
                }
            }
        }

        private void switchmode_btn_Click(object sender, EventArgs e)
        {
            modetransition.Start();
        }
        private void modemenuclose_btn_Click(object sender, EventArgs e)
        {
            modetransition.Start();
        }

        private void mainbutton_picbox_Click(object sender, EventArgs e)
        {

            sidebarTransition.Start();
        }
        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Detect double-click manually
                if (e.Clicks == 2)
                {
                    // Double click = maximize/restore
                    if (this.WindowState == FormWindowState.Normal)
                    {
                        this.WindowState = FormWindowState.Maximized;
                    }
                    else if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                }
                else
                {
                    // Single click = Drag
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            fileoperations.SaveFile(tabControl1);
        }

        private void saveas_btn_Click(object sender, EventArgs e)
        {
            fileoperations.SaveFileAs(tabControl1);
        }

        private void openfile_btn_Click(object sender, EventArgs e)
        {
            // Open file and get the file path
            string filePath = fileoperations.OpenFile(tabControl1, textarea);

            // If a valid file path is returned, add it to the recent files list
            if (!string.IsNullOrEmpty(filePath))
            {
                recentfilemgr.AddRecentFile(filePath, recentfile_listbox);
            }

        }

        private void newfile_btn_Click(object sender, EventArgs e)
        {
            fileoperations.NewFile(tabControl1, textarea);
        }

        private void openrecent_btn_Click(object sender, EventArgs e)
        {
            recentfiles_Transition.Start();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFooter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileoperations.CloseApplication(tabControl1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fileoperations.CloseCurrentFile(tabControl1);
        }

        private void findandreplace_btn_Click(object sender, EventArgs e)
        {
            var currentTextArea = tabControl1.SelectedTab?.Controls.OfType<RichTextBox>().FirstOrDefault();
            if (currentTextArea != null)
            {
                FindReplaceForm findForm = new FindReplaceForm(currentTextArea);
                findForm.Show();
            }
            else
            {
                MessageBox.Show("No active text area found.");
            }
        }

        private void recentfiles_Transition_Tick(object sender, EventArgs e)
        {
            if (recentmenuExpand == false)
            {
                recentfilepanel.Height += step1;
                if (recentfilepanel.Height >= 233)
                {
                    recentfiles_Transition.Stop();
                    recentmenuExpand = true;
                }

            }
            else
            {
                recentfilepanel.Height -= step1;
                if (recentfilepanel.Height <= 70)
                {
                    recentfiles_Transition.Stop();
                    recentmenuExpand = false;
                }
            }
        }

        private void recentfile_listbox_DoubleClick(object sender, EventArgs e)
        {
            if (recentfile_listbox.SelectedIndex >= 0 && recentfile_listbox.Tag is List<string> paths)
            {
                string selectedFilePath = paths[recentfile_listbox.SelectedIndex];
                try
                {
                    fileoperations.OpenFile(selectedFilePath, tabControl1, textarea);
                    recentfilemgr.AddRecentFile(selectedFilePath, recentfile_listbox);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening recent file: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fileoperations.CloseAllTabs(tabControl1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormAI formAI = new FormAI();
            formAI.ShowDialog();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            Keyboardshortcuts keyboard = new Keyboardshortcuts();
            keyboard.ShowDialog();
        }

        private void quillmode_btn_Click(object sender, EventArgs e)
        {
            quillmode quill = new quillmode();
            quill.ShowDialog();
        }
        private void defaultmode_btn_Click(object sender, EventArgs e)
        {
            defaultmode_form defaultmodeform = new defaultmode_form();
            defaultmodeform.ShowDialog();
        }

        private void sidebarcompleteclose_Tick(object sender, EventArgs e)
        {
            if (fileexplorer_expand)
            {
                fileplorer_panel.Width += 10;
                if (fileplorer_panel.Width >= 329)
                {
                    fileexplorer_expand = false;
                    sidebarcompleteclose.Stop();
                }
            }
            else
            {
                fileplorer_panel.Width -= 10;
                if (fileplorer_panel.Width <= 46)
                {
                    fileexplorer_expand = true;
                    sidebarcompleteclose.Stop();
                }
            }
        }

        private void textarea_VScroll(object sender, EventArgs e)
        {
            int nPos = GetScrollPos(textarea.Handle, SB_VERT);
            SetScrollPos(linenumber_richtextbox.Handle, SB_VERT, nPos, true);
            SendMessage(linenumber_richtextbox.Handle, WM_VSCROLL, (SB_THUMBPOSITION + 0x10000 * nPos), 0);
        }
        
        private void textarea_Click_1(object sender, EventArgs e)
        {
            if (placeholderActive)
            {
                textarea.Text = string.Empty;
                placeholderActive = false;
            }
        }

        private void textarea_TextChanged(object sender, EventArgs e)
        {
            UpdateFooter();
            UpdateLineNumbers();
        }

        

        private void openfolder_btn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = fbd.SelectedPath;

                    // Save path to file
                    File.WriteAllText("last_folder.txt", selectedPath);

                    // Load it into the file explorer
                    filetreeview.Nodes.Clear();
                    LoadDirectory(selectedPath, filetreeview.Nodes);
                }
            }


        }

        private void filetreeview_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string path = e.Node.Tag.ToString();

            if (File.Exists(path))
            {
                // Assuming you already use fileoperations.OpenFile(...) somewhere:
                fileoperations.OpenFile(path, tabControl1, textarea);
            }

            if (!string.IsNullOrEmpty(path))
            {
                recentfilemgr.AddRecentFile(path, recentfile_listbox);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sidebarcompleteclose.Start();
        }
        

        

        private void terminalInput_Click(object sender, EventArgs e)
        {
            if (!placeholder)
            {
                terminalInput.Text = string.Empty;
                placeholder = true;
            }
        }
        

        private void terminalInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string cmd = terminalInput.Text.Trim();
                terminalInput.Clear();

                outputTerminal.AppendText("> " + cmd + Environment.NewLine);

                if (cmd.ToLower() == "clear")
                {
                    outputTerminal.Clear();
                }
                else if (terminalProcess != null && !terminalProcess.HasExited)
                {
                    terminalProcess.StandardInput.WriteLine(cmd);
                    terminalProcess.StandardInput.Flush();
                }
                else
                {
                    outputTerminal.AppendText("⚠️ Terminal process not available." + Environment.NewLine);
                }
            }
        }

        private void devmode_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                recentfilemgr.SaveRecentFiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving recent files: " + ex.Message);
            }
            try
            {
                List<string> openFilePaths = new List<string>();

                foreach (WinFormsTabPage tab in tabControl1.TabPages)
                {
                    if (tab.Tag is string path && !string.IsNullOrEmpty(path) && !openFilePaths.Contains(path))
                    {
                        openFilePaths.Add(path);
                    }

                    File.WriteAllLines("open_tabs_devmode" + ".txt", openFilePaths);
                }

                recentfilemgr.SaveRecentFiles(); // keep this if you're saving recents
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving session: " + ex.Message);
            }
        }

        private async void devmode_form_Load(object sender, EventArgs e)
        {
            try
            {
                // 💻 Setup Terminal (PowerShell)
                LaunchPowerShell(); // Make sure you have this method defined!

                // 🧠 Initialize Python LSP (example: Pyright, you can later swap for OmniSharp)
                lspClient = new LspClient();

                string pyrightPath = Path.Combine(Application.StartupPath, @"node_modules\.bin\pyright-langserver.cmd");

                if (!File.Exists(pyrightPath))
                {
                    MessageBox.Show("Pyright LSP not found. Please ensure it is installed in node_modules.");
                }
                else
                {
                    await lspClient.StartAsync(pyrightPath);

                    if (textarea == null)
                    {
                        MessageBox.Show("Coding area (textarea) is not initialized.");
                        return;
                    }

                    string fileContent = textarea.Text;
                    if (string.IsNullOrEmpty(fileContent))
                    {
                        MessageBox.Show("No file content found to send to LSP.");
                        return;
                    }

                    string fileUri = "file:///fake_file.py"; // Just a unique ID for now
                    await lspClient.SendDidOpenAsync(fileUri, "python", fileContent);

                    JObject tokenResponse = await lspClient.RequestSemanticTokensAsync(fileUri);
                    if (tokenResponse != null && tokenResponse["result"]?["data"] is JArray tokens)
                    {
                        HighlightTokens(tokens); // You must define this method!
                    }
                }

                // 📁 Load last opened directory if available
                if (File.Exists("last_folder.txt"))
                {
                    string lastPath = File.ReadAllText("last_folder.txt");

                    if (Directory.Exists(lastPath))
                    {
                        filetreeview.Nodes.Clear();
                        LoadDirectory(lastPath, filetreeview.Nodes); // Make sure this method exists!
                    }
                    else
                    {
                        MessageBox.Show("Last folder path is invalid or doesn't exist.");
                    }
                }

                // 🕘 Load recent files into the listbox
                recentfilemgr.LoadRecentFiles(recentfile_listbox);

                // 📂 Load open tabs from previous session
                string openTabsPath = "open_tabs_devmode.txt";
                if (File.Exists(openTabsPath))
                {
                    string[] filePaths = File.ReadAllLines(openTabsPath);

                    foreach (string path in filePaths)
                    {
                        if (File.Exists(path))
                        {
                            fileoperations.OpenFile(path, tabControl1, textarea);
                        }
                        else
                        {
                            MessageBox.Show($"The file {path} no longer exists.");
                        }
                    }

                    // Clear session tracker
                    File.WriteAllText(openTabsPath, string.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading Dev Mode:\n" + ex.Message);
            }
        }
        private void settings_btn_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
        //*****************************
        //Functions called from designer end
        //*****************************
    }
}
