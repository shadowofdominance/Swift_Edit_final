namespace Swift_Edit
{
    partial class quillmode
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quillmode));
            panel1 = new Panel();
            switchmode_layoutpanel = new FlowLayoutPanel();
            panel13 = new Panel();
            switchmode_btn = new Button();
            panel15 = new Panel();
            quillmode_btn = new Button();
            panel16 = new Panel();
            devmode_btn = new Button();
            panel17 = new Panel();
            modemenuclose_btn = new Button();
            controlbar = new ReaLTaiizor.Controls.NightControlBox();
            heading_label = new Label();
            mainbutton_picbox = new PictureBox();
            infinitycanvas = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            mode_transition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            switchmode_layoutpanel.SuspendLayout();
            panel13.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainbutton_picbox).BeginInit();
            infinitycanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(switchmode_layoutpanel);
            panel1.Controls.Add(controlbar);
            panel1.Controls.Add(heading_label);
            panel1.Controls.Add(mainbutton_picbox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1478, 37);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // switchmode_layoutpanel
            // 
            switchmode_layoutpanel.Controls.Add(panel13);
            switchmode_layoutpanel.Controls.Add(panel15);
            switchmode_layoutpanel.Controls.Add(panel16);
            switchmode_layoutpanel.Controls.Add(panel17);
            switchmode_layoutpanel.Dock = DockStyle.Right;
            switchmode_layoutpanel.Location = new Point(1130, 0);
            switchmode_layoutpanel.Name = "switchmode_layoutpanel";
            switchmode_layoutpanel.Size = new Size(209, 37);
            switchmode_layoutpanel.TabIndex = 11;
            // 
            // panel13
            // 
            panel13.Controls.Add(switchmode_btn);
            panel13.Location = new Point(3, 3);
            panel13.Name = "panel13";
            panel13.Size = new Size(208, 34);
            panel13.TabIndex = 3;
            // 
            // switchmode_btn
            // 
            switchmode_btn.BackColor = Color.FromArgb(23, 24, 29);
            switchmode_btn.Font = new Font("Iosevka NFP ExtraBold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            switchmode_btn.ForeColor = Color.White;
            switchmode_btn.Image = (Image)resources.GetObject("switchmode_btn.Image");
            switchmode_btn.ImageAlign = ContentAlignment.MiddleRight;
            switchmode_btn.Location = new Point(-3, -3);
            switchmode_btn.Name = "switchmode_btn";
            switchmode_btn.Padding = new Padding(0, 0, 15, 0);
            switchmode_btn.Size = new Size(211, 37);
            switchmode_btn.TabIndex = 4;
            switchmode_btn.Text = "SWITCH MODE";
            switchmode_btn.UseVisualStyleBackColor = false;
            switchmode_btn.Click += switchmode_btn_Click;
            // 
            // panel15
            // 
            panel15.Controls.Add(quillmode_btn);
            panel15.Location = new Point(3, 43);
            panel15.Name = "panel15";
            panel15.Size = new Size(208, 34);
            panel15.TabIndex = 5;
            // 
            // quillmode_btn
            // 
            quillmode_btn.BackColor = Color.FromArgb(23, 24, 29);
            quillmode_btn.Font = new Font("Iosevka NFP ExtraBold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quillmode_btn.ForeColor = Color.White;
            quillmode_btn.Image = (Image)resources.GetObject("quillmode_btn.Image");
            quillmode_btn.ImageAlign = ContentAlignment.MiddleRight;
            quillmode_btn.Location = new Point(-3, -3);
            quillmode_btn.Name = "quillmode_btn";
            quillmode_btn.Padding = new Padding(0, 0, 15, 0);
            quillmode_btn.Size = new Size(211, 37);
            quillmode_btn.TabIndex = 4;
            quillmode_btn.Text = "QUILL MODE";
            quillmode_btn.UseVisualStyleBackColor = false;
            // 
            // panel16
            // 
            panel16.Controls.Add(devmode_btn);
            panel16.Location = new Point(3, 83);
            panel16.Name = "panel16";
            panel16.Size = new Size(208, 34);
            panel16.TabIndex = 6;
            // 
            // devmode_btn
            // 
            devmode_btn.BackColor = Color.FromArgb(23, 24, 29);
            devmode_btn.Font = new Font("Iosevka NFP ExtraBold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            devmode_btn.ForeColor = Color.White;
            devmode_btn.Image = (Image)resources.GetObject("devmode_btn.Image");
            devmode_btn.ImageAlign = ContentAlignment.MiddleRight;
            devmode_btn.Location = new Point(-3, -3);
            devmode_btn.Name = "devmode_btn";
            devmode_btn.Padding = new Padding(0, 0, 15, 0);
            devmode_btn.Size = new Size(211, 37);
            devmode_btn.TabIndex = 4;
            devmode_btn.Text = "DEV MODE";
            devmode_btn.UseVisualStyleBackColor = false;
            // 
            // panel17
            // 
            panel17.Controls.Add(modemenuclose_btn);
            panel17.Location = new Point(3, 123);
            panel17.Name = "panel17";
            panel17.Size = new Size(53, 34);
            panel17.TabIndex = 7;
            // 
            // modemenuclose_btn
            // 
            modemenuclose_btn.BackColor = Color.FromArgb(23, 24, 29);
            modemenuclose_btn.Font = new Font("Iosevka NFP ExtraBold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modemenuclose_btn.ForeColor = Color.White;
            modemenuclose_btn.Image = (Image)resources.GetObject("modemenuclose_btn.Image");
            modemenuclose_btn.ImageAlign = ContentAlignment.MiddleLeft;
            modemenuclose_btn.Location = new Point(-3, -3);
            modemenuclose_btn.Name = "modemenuclose_btn";
            modemenuclose_btn.Padding = new Padding(15, 0, 0, 0);
            modemenuclose_btn.Size = new Size(62, 37);
            modemenuclose_btn.TabIndex = 4;
            modemenuclose_btn.UseVisualStyleBackColor = false;
            // 
            // controlbar
            // 
            controlbar.BackColor = Color.Transparent;
            controlbar.CloseHoverColor = Color.FromArgb(199, 80, 80);
            controlbar.CloseHoverForeColor = SystemColors.HighlightText;
            controlbar.DefaultLocation = true;
            controlbar.DisableMaximizeColor = Color.White;
            controlbar.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            controlbar.Dock = DockStyle.Right;
            controlbar.EnableCloseColor = Color.FromArgb(160, 160, 160);
            controlbar.EnableMaximizeButton = true;
            controlbar.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            controlbar.EnableMinimizeButton = true;
            controlbar.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            controlbar.Location = new Point(1339, 0);
            controlbar.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            controlbar.MaximizeHoverForeColor = SystemColors.WindowText;
            controlbar.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            controlbar.MinimizeHoverForeColor = SystemColors.WindowText;
            controlbar.Name = "controlbar";
            controlbar.Size = new Size(139, 31);
            controlbar.TabIndex = 2;
            // 
            // heading_label
            // 
            heading_label.AutoSize = true;
            heading_label.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            heading_label.Location = new Point(73, 8);
            heading_label.Name = "heading_label";
            heading_label.Size = new Size(209, 23);
            heading_label.TabIndex = 1;
            heading_label.Text = "SWIFTEDIT | QUILL MODE";
            // 
            // mainbutton_picbox
            // 
            mainbutton_picbox.Image = (Image)resources.GetObject("mainbutton_picbox.Image");
            mainbutton_picbox.Location = new Point(3, 3);
            mainbutton_picbox.Name = "mainbutton_picbox";
            mainbutton_picbox.Size = new Size(51, 31);
            mainbutton_picbox.SizeMode = PictureBoxSizeMode.CenterImage;
            mainbutton_picbox.TabIndex = 1;
            mainbutton_picbox.TabStop = false;
            // 
            // infinitycanvas
            // 
            infinitycanvas.AutoScroll = true;
            infinitycanvas.AutoScrollMinSize = new Size(5000, 5000);
            infinitycanvas.BackColor = Color.WhiteSmoke;
            infinitycanvas.Controls.Add(pictureBox3);
            infinitycanvas.Controls.Add(pictureBox2);
            infinitycanvas.Controls.Add(panel2);
            infinitycanvas.Dock = DockStyle.Fill;
            infinitycanvas.Location = new Point(0, 37);
            infinitycanvas.Name = "infinitycanvas";
            infinitycanvas.Size = new Size(1478, 808);
            infinitycanvas.TabIndex = 2;
            infinitycanvas.Scroll += panel2_Scroll;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(23, 24, 29);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(344, 702);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(65, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(23, 24, 29);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(256, 702);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 24, 29);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(433, 702);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 0, 10, 0);
            panel2.Size = new Size(764, 51);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(13, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 51);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // mode_transition
            // 
            mode_transition.Interval = 10;
            // 
            // quillmode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 845);
            Controls.Add(infinitycanvas);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "quillmode";
            Text = "quillmode";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            switchmode_layoutpanel.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainbutton_picbox).EndInit();
            infinitycanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel switchmode_layoutpanel;
        private Panel panel13;
        private Button switchmode_btn;
        private Panel panel15;
        private Button quillmode_btn;
        private Panel panel16;
        private Button devmode_btn;
        private Panel panel17;
        private Button modemenuclose_btn;
        private ReaLTaiizor.Controls.NightControlBox controlbar;
        private Label heading_label;
        private PictureBox mainbutton_picbox;
        private Panel infinitycanvas;
        private System.Windows.Forms.Timer mode_transition;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}