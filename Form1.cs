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
        int step1 = 40;
        int step2 = 25;
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

        private void mainbutton_picbox_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void textarea_Click(object sender, EventArgs e)
        {
            textarea.Text = string.Empty;
        }
    }
}
