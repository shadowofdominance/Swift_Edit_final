using System.Windows.Forms;
using System.ComponentModel;
using ReaLTaiizor.Controls;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Swift_Edit
{
    public partial class defaultmode_form : Form
    {

        public defaultmode_form()
        {
            InitializeComponent();
        }
        bool menuExpand = false;
        bool sidebarExpand = true;
        bool switchmodeExpand = true;
        bool placeholderActive = true;
        int step1 = 40;
        int step2 = 25;

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
                if (filemenupanel.Height >= 606)
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
        private void UpdateFooter()
        {
            // Word Count
            string text = textarea.Text;
            int wordCount = 0;

            if (!string.IsNullOrWhiteSpace(text))
            {
                wordCount = text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            }

            // Line Count
            int lineCount = textarea.Lines.Length;

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
    }
}
