using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swift_Edit
{
    public partial class FormAI : Form
    {
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

        private void send_btn_Click(object sender, EventArgs e)
        {

        }

        private void copy_btn_Click(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {

        }

        private void prompt_textbox_Click(object sender, EventArgs e)
        {
            if (placeholderactive)
            {
                prompt_textbox.Text = string.Empty;
                placeholderactive = false;
            }
        }
    }
}
