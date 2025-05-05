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
using Swift_Edit;

namespace Swift_Edit
{
    public partial class FindReplaceForm : Form
    {
        //private TextBox txtFind;
        //private TextBox txtReplace;
        //private CheckBox chkMatchCase;
        //private TextBox editor;
        private RichTextBox editor;

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

        public FindReplaceForm(RichTextBox editorTextBox)
        {
            if (editorTextBox == null)
                throw new ArgumentNullException(nameof(editorTextBox), "Editor TextBox cannot be null.");

            editor = editorTextBox;
            InitializeComponent();
        }

        private void findnext_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string findText = txtFind.Text.Trim();
                if (string.IsNullOrEmpty(findText))
                {
                    MessageBox.Show("Please enter text to find.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                StringComparison comparison = chkMatchCase.Checked ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase;
                int startPos = editor.SelectionStart + editor.SelectionLength;
                int foundPos = editor.Text.IndexOf(findText, startPos, comparison);
                
                if (foundPos == -1 && startPos > 0)
                {
                    // Try searching from the top again
                    foundPos = editor.Text.IndexOf(findText, 0, comparison);
                }
                else
                {
                    MessageBox.Show("Text not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void replace_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (editor.SelectedText.Equals(txtFind.Text, chkMatchCase.Checked ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase))
                {
                    editor.SelectedText = txtReplace.Text;
                }
                findnext_btn_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void replaceall_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string findText = txtFind.Text.Trim();
                string replaceText = txtReplace.Text;

                if (string.IsNullOrEmpty(findText))
                {
                    MessageBox.Show("Please enter text to find.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                StringComparison comparison = chkMatchCase.Checked ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase;
                int count = 0;
                int pos = 0;

                editor.SuspendLayout();
                while (pos <= editor.Text.Length - findText.Length)
                {
                    int foundPos = editor.Text.IndexOf(findText, pos, comparison);
                    if (foundPos == -1) break;

                    editor.Select(foundPos, findText.Length);
                    editor.SelectedText = replaceText;

                    // Move forward by REPLACEMENT length to avoid infinite loop on same match
                    pos = foundPos + replaceText.Length;
                    count++;
                }
                editor.ResumeLayout();

                MessageBox.Show($"Replaced {count} occurrence(s).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void match_CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void whole_CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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
