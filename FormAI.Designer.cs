namespace Swift_Edit
{
    partial class FormAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAI));
            panel1 = new Panel();
            label1 = new Label();
            close_picturebox = new PictureBox();
            panel2 = new Panel();
            panel4 = new Panel();
            response_textbox = new TextBox();
            close_btn = new Button();
            panel3 = new Panel();
            clear_btn = new Button();
            copy_btn = new Button();
            send_btn = new Button();
            prompt_textbox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)close_picturebox).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(close_picturebox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 42);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("VictorMono NF SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(222, 26);
            label1.TabIndex = 1;
            label1.Text = "Ask Swiftie Anything!";
            // 
            // close_picturebox
            // 
            close_picturebox.BackColor = Color.IndianRed;
            close_picturebox.Dock = DockStyle.Right;
            close_picturebox.Image = (Image)resources.GetObject("close_picturebox.Image");
            close_picturebox.Location = new Point(365, 0);
            close_picturebox.Name = "close_picturebox";
            close_picturebox.Size = new Size(50, 42);
            close_picturebox.SizeMode = PictureBoxSizeMode.CenterImage;
            close_picturebox.TabIndex = 0;
            close_picturebox.TabStop = false;
            close_picturebox.Click += close_picturebox_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(415, 528);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(response_textbox);
            panel4.Controls.Add(close_btn);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 177);
            panel4.Name = "panel4";
            panel4.Size = new Size(415, 351);
            panel4.TabIndex = 1;
            // 
            // response_textbox
            // 
            response_textbox.BackColor = SystemColors.ScrollBar;
            response_textbox.Dock = DockStyle.Fill;
            response_textbox.Font = new Font("UbuntuMono Nerd Font", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            response_textbox.Location = new Point(0, 0);
            response_textbox.Multiline = true;
            response_textbox.Name = "response_textbox";
            response_textbox.ReadOnly = true;
            response_textbox.ScrollBars = ScrollBars.Both;
            response_textbox.Size = new Size(415, 311);
            response_textbox.TabIndex = 1;
            response_textbox.WordWrap = false;
            // 
            // close_btn
            // 
            close_btn.BackColor = SystemColors.MenuText;
            close_btn.Dock = DockStyle.Bottom;
            close_btn.Font = new Font("UbuntuMono Nerd Font", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close_btn.ForeColor = Color.White;
            close_btn.Location = new Point(0, 311);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(415, 40);
            close_btn.TabIndex = 0;
            close_btn.Text = "Close";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(clear_btn);
            panel3.Controls.Add(copy_btn);
            panel3.Controls.Add(send_btn);
            panel3.Controls.Add(prompt_textbox);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(415, 177);
            panel3.TabIndex = 0;
            // 
            // clear_btn
            // 
            clear_btn.BackColor = SystemColors.ControlLight;
            clear_btn.Font = new Font("UbuntuMono Nerd Font", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clear_btn.Image = (Image)resources.GetObject("clear_btn.Image");
            clear_btn.ImageAlign = ContentAlignment.MiddleRight;
            clear_btn.Location = new Point(259, 138);
            clear_btn.Name = "clear_btn";
            clear_btn.Padding = new Padding(10, 0, 10, 0);
            clear_btn.Size = new Size(100, 35);
            clear_btn.TabIndex = 3;
            clear_btn.Text = "Clear";
            clear_btn.TextAlign = ContentAlignment.MiddleLeft;
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += clear_btn_Click;
            // 
            // copy_btn
            // 
            copy_btn.BackColor = SystemColors.ControlLight;
            copy_btn.Font = new Font("UbuntuMono Nerd Font", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            copy_btn.Image = (Image)resources.GetObject("copy_btn.Image");
            copy_btn.ImageAlign = ContentAlignment.MiddleRight;
            copy_btn.Location = new Point(153, 138);
            copy_btn.Name = "copy_btn";
            copy_btn.Padding = new Padding(10, 0, 10, 0);
            copy_btn.Size = new Size(100, 35);
            copy_btn.TabIndex = 2;
            copy_btn.Text = "Copy";
            copy_btn.TextAlign = ContentAlignment.MiddleLeft;
            copy_btn.UseVisualStyleBackColor = false;
            copy_btn.Click += copy_btn_Click;
            // 
            // send_btn
            // 
            send_btn.BackColor = SystemColors.ControlLight;
            send_btn.Font = new Font("UbuntuMono Nerd Font", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            send_btn.Image = (Image)resources.GetObject("send_btn.Image");
            send_btn.ImageAlign = ContentAlignment.MiddleRight;
            send_btn.Location = new Point(47, 136);
            send_btn.Name = "send_btn";
            send_btn.Padding = new Padding(10, 0, 10, 0);
            send_btn.Size = new Size(100, 35);
            send_btn.TabIndex = 1;
            send_btn.Text = "Send";
            send_btn.TextAlign = ContentAlignment.MiddleLeft;
            send_btn.UseVisualStyleBackColor = false;
            send_btn.Click += send_btn_Click;
            // 
            // prompt_textbox
            // 
            prompt_textbox.BackColor = SystemColors.ScrollBar;
            prompt_textbox.Dock = DockStyle.Top;
            prompt_textbox.Font = new Font("UbuntuMono Nerd Font", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prompt_textbox.Location = new Point(0, 0);
            prompt_textbox.Multiline = true;
            prompt_textbox.Name = "prompt_textbox";
            prompt_textbox.ScrollBars = ScrollBars.Both;
            prompt_textbox.Size = new Size(415, 132);
            prompt_textbox.TabIndex = 0;
            prompt_textbox.Text = "Enter your  prompt here!";
            prompt_textbox.WordWrap = false;
            prompt_textbox.Click += prompt_textbox_Click;
            // 
            // FormAI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 570);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAI";
            Text = "FormAI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)close_picturebox).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox close_picturebox;
        private Panel panel2;
        private Panel panel3;
        private TextBox prompt_textbox;
        private Button clear_btn;
        private Button copy_btn;
        private Button send_btn;
        private Panel panel4;
        private TextBox response_textbox;
        private Button close_btn;
    }
}