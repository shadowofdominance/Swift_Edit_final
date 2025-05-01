using ReaLTaiizor.Controls;
using SwiftEdit;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using WinFormsTabPage = System.Windows.Forms.TabPage;

namespace Swift_Edit
{
    public partial class defaultmode_form : Form
    {
        private recentfilemanager recentFilesManager = new recentfilemanager();
        public defaultmode_form()
        {
            InitializeComponent();
            FormClosing += defaultmode_form_FormClosing;
            Load += defaultmode_form_Load;

        }
        bool menuExpand = false;
        bool recentmenuExpand = false;
        bool sidebarExpand = true;
        bool switchmodeExpand = true;
        bool placeholderActive = true;
        int step1 = 40;
        int step2 = 25;
        private void LoadRecentFilesToUI()
        {
            recentFilesManager.LoadRecentFiles(recentfile_listbox);
        }

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
        // These two functions allow dragging
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constants
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                filemenupanel.Height += step1;
                if (filemenupanel.Height >= 537)
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
                if (switchmode_layoutpanel.Width >= 915)
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
        public void UpdateFooter()
        {
            if (tabControl1.SelectedTab != null && tabControl1.SelectedTab.Controls.Count > 0)
            {
                // Find the RichTextBox/TextBox inside the current tab
                var currentTextArea = tabControl1.SelectedTab.Controls
                                        .OfType<TextBox>()
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


        private void textarea_Click(object sender, EventArgs e)
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
                recentFilesManager.AddRecentFile(filePath, recentfile_listbox);
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

        private void defaultmode_form_Load(object sender, EventArgs e)
        {
            recentFilesManager.LoadRecentFiles(recentfile_listbox);
            try
            {
                if (File.Exists("open_tabs.txt"))
                {
                    string[] filePaths = File.ReadAllLines("open_tabs.txt");

                    foreach (string path in filePaths)
                    {
                        if (File.Exists(path))
                        {
                            // Optional: Check if it's already open (not likely on startup, but future-proof)
                            fileoperations.OpenFile(path, tabControl1, textarea);
                        }
                    }

                    // After loading, clear the file so it's fresh for next exit
                    File.WriteAllText("open_tabs.txt", string.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading session: " + ex.Message);
            }
        }

        private void defaultmode_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                recentFilesManager.SaveRecentFiles();
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

                    File.WriteAllLines("open_tabs.txt", openFilePaths);
                }

                recentFilesManager.SaveRecentFiles(); // keep this if you're saving recents
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving session: " + ex.Message);
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
            var currentTextArea = tabControl1.SelectedTab?.Controls.OfType<TextBox>().FirstOrDefault();
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
                    recentFilesManager.AddRecentFile(selectedFilePath, recentfile_listbox);
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
            string savedKey = Properties.Settings.Default.APIKey;

            if (!string.IsNullOrEmpty(savedKey))
            {
                // Key exists -> open chatbot
                var aiForm = new FormAI(savedKey);
                aiForm.Show();
            }
            else
            {
                // No key yet -> open key entry form
                var keyForm = new ApiKeyForm();
                keyForm.Show();
            }
        }
    }
}
