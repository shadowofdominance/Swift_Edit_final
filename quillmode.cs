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
    public partial class quillmode : Form
    {
        private Panel canvasPanel;
        public quillmode()
        {
            InitializeComponent();
            InitializeCanvas(); 
        }

        private void InitializeCanvas()
        {
            // Create the infinite canvas panel
            canvasPanel = new Panel
            {
                Dock = DockStyle.Fill,         // Fill the whole form
                AutoScroll = true,             // Make it scrollable
                BackColor = Color.WhiteSmoke,  // Chill background color
                AutoScrollMinSize = new Size(5000, 5000) // Giant virtual area
            };

            // Add it to the form
            this.Controls.Add(canvasPanel);
        }
    }
}
