namespace Swift_Edit
{
    partial class Keyboardshortcuts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Keyboardshortcuts));
            panel1 = new Panel();
            label1 = new Label();
            close_picturebox = new PictureBox();
            panel2 = new Panel();
            richTextBox2 = new RichTextBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)close_picturebox).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(close_picturebox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 42);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("VictorMono NF SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 26);
            label1.TabIndex = 1;
            label1.Text = "Keyboard Shortcuts";
            // 
            // close_picturebox
            // 
            close_picturebox.BackColor = Color.IndianRed;
            close_picturebox.Dock = DockStyle.Right;
            close_picturebox.Image = (Image)resources.GetObject("close_picturebox.Image");
            close_picturebox.Location = new Point(439, 0);
            close_picturebox.Name = "close_picturebox";
            close_picturebox.Size = new Size(50, 42);
            close_picturebox.SizeMode = PictureBoxSizeMode.CenterImage;
            close_picturebox.TabIndex = 0;
            close_picturebox.TabStop = false;
            close_picturebox.Click += close_picturebox_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(richTextBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(richTextBox1);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(489, 758);
            panel2.TabIndex = 2;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.ActiveBorder;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Location = new Point(12, 428);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(465, 303);
            richTextBox2.TabIndex = 5;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("VictorMono NF SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 399);
            label2.Name = "label2";
            label2.Size = new Size(92, 26);
            label2.TabIndex = 4;
            label2.Text = "Dev Mode";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ActiveBorder;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(12, 52);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(465, 303);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("VictorMono NF SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 23);
            label3.Name = "label3";
            label3.Size = new Size(132, 26);
            label3.TabIndex = 2;
            label3.Text = "Default Mode";
            label3.Click += label3_Click;
            // 
            // Keyboardshortcuts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 800);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Keyboardshortcuts";
            Text = "Keyboardshortcuts";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)close_picturebox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox close_picturebox;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
    }
}