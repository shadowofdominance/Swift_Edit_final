namespace Swift_Edit
{
    partial class ApiKeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApiKeyForm));
            panel1 = new Panel();
            label1 = new Label();
            close_picturebox = new PictureBox();
            apienter_textbox = new TextBox();
            label2 = new Label();
            help_linklabel = new LinkLabel();
            submit_btn = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)close_picturebox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(close_picturebox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 42);
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
            label1.Text = "API Key Validation";
            // 
            // close_picturebox
            // 
            close_picturebox.BackColor = Color.IndianRed;
            close_picturebox.Dock = DockStyle.Right;
            close_picturebox.Image = (Image)resources.GetObject("close_picturebox.Image");
            close_picturebox.Location = new Point(383, 0);
            close_picturebox.Name = "close_picturebox";
            close_picturebox.Size = new Size(50, 42);
            close_picturebox.SizeMode = PictureBoxSizeMode.CenterImage;
            close_picturebox.TabIndex = 0;
            close_picturebox.TabStop = false;
            close_picturebox.Click += close_picturebox_Click;
            // 
            // apienter_textbox
            // 
            apienter_textbox.Location = new Point(58, 201);
            apienter_textbox.Name = "apienter_textbox";
            apienter_textbox.Size = new Size(312, 27);
            apienter_textbox.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(58, 57);
            label2.Name = "label2";
            label2.Size = new Size(312, 85);
            label2.TabIndex = 3;
            label2.Text = "Enter your Open API key in the textbox below! The key will be stored safely in your system! If you dont know how to generate an OpenAPI key click on the link below!";
            // 
            // help_linklabel
            // 
            help_linklabel.AutoSize = true;
            help_linklabel.Location = new Point(108, 161);
            help_linklabel.Name = "help_linklabel";
            help_linklabel.Size = new Size(192, 20);
            help_linklabel.TabIndex = 4;
            help_linklabel.TabStop = true;
            help_linklabel.Text = "Get Your API Key from here!";
            help_linklabel.LinkClicked += linkLabel1_LinkClicked;
            // 
            // submit_btn
            // 
            submit_btn.BackColor = SystemColors.InactiveCaption;
            submit_btn.Location = new Point(158, 251);
            submit_btn.Name = "submit_btn";
            submit_btn.Size = new Size(104, 34);
            submit_btn.TabIndex = 5;
            submit_btn.Text = "Submit";
            submit_btn.UseVisualStyleBackColor = false;
            submit_btn.Click += submit_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 306);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 6;
            // 
            // ApiKeyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 349);
            Controls.Add(label3);
            Controls.Add(submit_btn);
            Controls.Add(help_linklabel);
            Controls.Add(label2);
            Controls.Add(apienter_textbox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ApiKeyForm";
            Text = "ApiKeyForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)close_picturebox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox close_picturebox;
        private TextBox apienter_textbox;
        private Label label2;
        private LinkLabel help_linklabel;
        private Button submit_btn;
        private Label label3;
    }
}