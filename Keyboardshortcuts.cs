﻿using System;
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
    public partial class Keyboardshortcuts : Form
    {
        public Keyboardshortcuts()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void close_picturebox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
