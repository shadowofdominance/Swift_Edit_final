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

namespace Swift_Edit
{
    public partial class quillmode : Form
    {
        public quillmode()
        {
            InitializeComponent();
        }

        bool switchmodeExpand = true;

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

        private void switchmode_btn_Click(object sender, EventArgs e)
        {

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

        int buffer = 100; // How close to the edge before we expand
        int growthSize = 1000; // How much we expand each time

        private void CheckAndExpandCanvas()
        {
            var scrollPos = infinitycanvas.AutoScrollPosition;
            var scrollMax = infinitycanvas.DisplayRectangle;

            // In WinForms, AutoScrollPosition is negative, so flip signs
            int scrollX = -scrollPos.X;
            int scrollY = -scrollPos.Y;

            if (scrollX + infinitycanvas.ClientSize.Width >= infinitycanvas.AutoScrollMinSize.Width - buffer)
            {
                infinitycanvas.AutoScrollMinSize = new Size(
                    infinitycanvas.AutoScrollMinSize.Width + growthSize,
                    infinitycanvas.AutoScrollMinSize.Height
                );
            }

            if (scrollY + infinitycanvas.ClientSize.Height >= infinitycanvas.AutoScrollMinSize.Height - buffer)
            {
                infinitycanvas.AutoScrollMinSize = new Size(
                    infinitycanvas.AutoScrollMinSize.Width,
                    infinitycanvas.AutoScrollMinSize.Height + growthSize
                );
            }
        }
        public void AddTextBox(Point location)
        {
            TextBox tb = new TextBox
            {
                Multiline = true,
                Size = new Size(150, 50),
                Location = location,
                BorderStyle = BorderStyle.FixedSingle
            };

            EnableDrag(tb);

            this.Controls.Add(tb);
            tb.BringToFront();
            tb.Focus();
        }
        private void EnableDrag(Control ctrl)
        {
            Point offset = Point.Empty;

            ctrl.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                    offset = e.Location;
            };

            ctrl.MouseMove += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ctrl.Left += e.X - offset.X;
                    ctrl.Top += e.Y - offset.Y;
                }
            };
        }

        private void panel2_Scroll(object sender, ScrollEventArgs e)
        {
            CheckAndExpandCanvas();
        }

        private void mode_transition_Tick(object sender, EventArgs e)
        {

        }

        private void infinitycanvas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point canvasPos = e.Location;
            AddTextBox(canvasPos);
        }
    }
}
