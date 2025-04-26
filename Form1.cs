using System.Windows.Forms;
using System.ComponentModel;
using ReaLTaiizor.Controls;

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
        int step = 35;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                filemenupanel.Height += step;
                if (filemenupanel.Height >= 606)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }

            }
            else
            {
                filemenupanel.Height -= step;
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
                sidebarpanel.Width += step;
                if (sidebarpanel.Width >= 315)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();


                }
            }
            else
            {
                sidebarpanel.Width -= step;
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

        private void mainbutton_picbox_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void mainbutton_picbox_MouseHover(object sender, EventArgs e)
        {
            mainbutton_picbox.Size = new Size(mainbutton_picbox.Width + 10, mainbutton_picbox.Height + 10);
            mainbutton_picbox.Location = new Point(mainbutton_picbox.Location.X - 5, mainbutton_picbox.Location.Y - 5);
        }

        private void mainbutton_picbox_MouseLeave(object sender, EventArgs e)
        {
            mainbutton_picbox.Size = new Size(mainbutton_picbox.Width - 10, mainbutton_picbox.Height - 10);
            mainbutton_picbox.Location = new Point(mainbutton_picbox.Location.X + 5, mainbutton_picbox.Location.Y + 5);
        }
    }
}
