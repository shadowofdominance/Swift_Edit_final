namespace Swift_Edit
{
    partial class defaultmode_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(defaultmode_form));
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
            pictureBox1 = new PictureBox();
            heading_label = new Label();
            mainbutton_picbox = new PictureBox();
            sidebarpanel = new FlowLayoutPanel();
            panel3 = new Panel();
            home_btn = new Button();
            panel2 = new Panel();
            settings_btn = new Button();
            panel6 = new Panel();
            findandreplace_btn = new Button();
            filemenupanel = new FlowLayoutPanel();
            panel5 = new Panel();
            mainfilemenu_btn = new Button();
            panel4 = new Panel();
            openfile_btn = new Button();
            panel7 = new Panel();
            newfile_btn = new Button();
            recentfilepanel = new Panel();
            panel23 = new Panel();
            recentfile_listbox = new ListBox();
            panel22 = new Panel();
            openrecent_btn = new Button();
            panel11 = new Panel();
            save_btn = new Button();
            panel12 = new Panel();
            saveas_btn = new Button();
            panel9 = new Panel();
            button1 = new Button();
            panel8 = new Panel();
            button3 = new Button();
            panel10 = new Panel();
            button2 = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            modetransition = new System.Windows.Forms.Timer(components);
            footer_layoutpanel = new FlowLayoutPanel();
            panel18 = new Panel();
            wordcount_label = new Label();
            panel19 = new Panel();
            linecount_label = new Label();
            panel20 = new Panel();
            charactercount_label = new Label();
            panel21 = new Panel();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            textarea = new RichTextBox();
            recentfiles_Transition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            switchmode_layoutpanel.SuspendLayout();
            panel13.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainbutton_picbox).BeginInit();
            sidebarpanel.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            filemenupanel.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            recentfilepanel.SuspendLayout();
            panel23.SuspendLayout();
            panel22.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            footer_layoutpanel.SuspendLayout();
            panel18.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            panel21.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(switchmode_layoutpanel);
            panel1.Controls.Add(controlbar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(heading_label);
            panel1.Controls.Add(mainbutton_picbox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1666, 37);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // switchmode_layoutpanel
            // 
            switchmode_layoutpanel.Controls.Add(panel13);
            switchmode_layoutpanel.Controls.Add(panel15);
            switchmode_layoutpanel.Controls.Add(panel16);
            switchmode_layoutpanel.Controls.Add(panel17);
            switchmode_layoutpanel.Dock = DockStyle.Right;
            switchmode_layoutpanel.Location = new Point(1318, 0);
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
            quillmode_btn.Click += quillmode_btn_Click;
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
            devmode_btn.Click += devmode_btn_Click;
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
            modemenuclose_btn.Click += modemenuclose_btn_Click;
            // 
            // controlbar
            // 
            controlbar.BackColor = Color.Transparent;
            controlbar.CloseHoverColor = Color.FromArgb(199, 80, 80);
            controlbar.CloseHoverForeColor = SystemColors.HighlightText;
            controlbar.DefaultLocation = true;
            controlbar.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            controlbar.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            controlbar.Dock = DockStyle.Right;
            controlbar.EnableCloseColor = Color.FromArgb(160, 160, 160);
            controlbar.EnableMaximizeButton = true;
            controlbar.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            controlbar.EnableMinimizeButton = true;
            controlbar.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            controlbar.Location = new Point(1527, 0);
            controlbar.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            controlbar.MaximizeHoverForeColor = SystemColors.WindowFrame;
            controlbar.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            controlbar.MinimizeHoverForeColor = SystemColors.WindowFrame;
            controlbar.Name = "controlbar";
            controlbar.Size = new Size(139, 31);
            controlbar.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(64, 64, 64);
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(54, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // heading_label
            // 
            heading_label.AutoSize = true;
            heading_label.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            heading_label.Location = new Point(129, 8);
            heading_label.Name = "heading_label";
            heading_label.Size = new Size(231, 23);
            heading_label.TabIndex = 1;
            heading_label.Text = "SWIFTEDIT | DEFAULT MODE";
            // 
            // mainbutton_picbox
            // 
            mainbutton_picbox.Dock = DockStyle.Left;
            mainbutton_picbox.Image = (Image)resources.GetObject("mainbutton_picbox.Image");
            mainbutton_picbox.Location = new Point(0, 0);
            mainbutton_picbox.Name = "mainbutton_picbox";
            mainbutton_picbox.Size = new Size(54, 37);
            mainbutton_picbox.SizeMode = PictureBoxSizeMode.CenterImage;
            mainbutton_picbox.TabIndex = 1;
            mainbutton_picbox.TabStop = false;
            mainbutton_picbox.Click += mainbutton_picbox_Click;
            // 
            // sidebarpanel
            // 
            sidebarpanel.BackColor = Color.FromArgb(23, 24, 29);
            sidebarpanel.Controls.Add(panel3);
            sidebarpanel.Controls.Add(panel2);
            sidebarpanel.Controls.Add(panel6);
            sidebarpanel.Controls.Add(filemenupanel);
            sidebarpanel.Controls.Add(panel8);
            sidebarpanel.Controls.Add(panel10);
            sidebarpanel.Dock = DockStyle.Left;
            sidebarpanel.Location = new Point(0, 37);
            sidebarpanel.Name = "sidebarpanel";
            sidebarpanel.Padding = new Padding(0, 20, 0, 0);
            sidebarpanel.Size = new Size(69, 915);
            sidebarpanel.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(home_btn);
            panel3.Location = new Point(3, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(334, 70);
            panel3.TabIndex = 3;
            // 
            // home_btn
            // 
            home_btn.BackColor = Color.FromArgb(23, 24, 29);
            home_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            home_btn.ForeColor = Color.White;
            home_btn.Image = (Image)resources.GetObject("home_btn.Image");
            home_btn.ImageAlign = ContentAlignment.MiddleLeft;
            home_btn.Location = new Point(-11, -8);
            home_btn.Name = "home_btn";
            home_btn.Padding = new Padding(25, 0, 0, 0);
            home_btn.Size = new Size(360, 87);
            home_btn.TabIndex = 0;
            home_btn.Text = "            Keyboard Shortcuts";
            home_btn.TextAlign = ContentAlignment.MiddleLeft;
            home_btn.UseVisualStyleBackColor = false;
            home_btn.Click += home_btn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(settings_btn);
            panel2.Location = new Point(3, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 70);
            panel2.TabIndex = 2;
            // 
            // settings_btn
            // 
            settings_btn.BackColor = Color.FromArgb(23, 24, 29);
            settings_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settings_btn.ForeColor = Color.White;
            settings_btn.Image = (Image)resources.GetObject("settings_btn.Image");
            settings_btn.ImageAlign = ContentAlignment.MiddleLeft;
            settings_btn.Location = new Point(-11, -10);
            settings_btn.Name = "settings_btn";
            settings_btn.Padding = new Padding(25, 0, 0, 0);
            settings_btn.Size = new Size(360, 93);
            settings_btn.TabIndex = 0;
            settings_btn.Text = "            Settings";
            settings_btn.TextAlign = ContentAlignment.MiddleLeft;
            settings_btn.UseVisualStyleBackColor = false;
            settings_btn.Click += settings_btn_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(findandreplace_btn);
            panel6.Location = new Point(3, 175);
            panel6.Name = "panel6";
            panel6.Size = new Size(340, 70);
            panel6.TabIndex = 6;
            // 
            // findandreplace_btn
            // 
            findandreplace_btn.BackColor = Color.FromArgb(23, 24, 29);
            findandreplace_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            findandreplace_btn.ForeColor = Color.White;
            findandreplace_btn.Image = (Image)resources.GetObject("findandreplace_btn.Image");
            findandreplace_btn.ImageAlign = ContentAlignment.MiddleLeft;
            findandreplace_btn.Location = new Point(-11, -8);
            findandreplace_btn.Name = "findandreplace_btn";
            findandreplace_btn.Padding = new Padding(25, 0, 0, 0);
            findandreplace_btn.Size = new Size(360, 87);
            findandreplace_btn.TabIndex = 0;
            findandreplace_btn.Text = "            Find And Replace";
            findandreplace_btn.TextAlign = ContentAlignment.MiddleLeft;
            findandreplace_btn.UseVisualStyleBackColor = false;
            findandreplace_btn.Click += findandreplace_btn_Click;
            // 
            // filemenupanel
            // 
            filemenupanel.BackColor = Color.FromArgb(23, 24, 29);
            filemenupanel.Controls.Add(panel5);
            filemenupanel.Controls.Add(panel4);
            filemenupanel.Controls.Add(panel7);
            filemenupanel.Controls.Add(recentfilepanel);
            filemenupanel.Controls.Add(panel11);
            filemenupanel.Controls.Add(panel12);
            filemenupanel.Controls.Add(panel9);
            filemenupanel.Location = new Point(3, 251);
            filemenupanel.Name = "filemenupanel";
            filemenupanel.Size = new Size(338, 70);
            filemenupanel.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.Controls.Add(mainfilemenu_btn);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(334, 70);
            panel5.TabIndex = 5;
            // 
            // mainfilemenu_btn
            // 
            mainfilemenu_btn.BackColor = Color.FromArgb(23, 24, 29);
            mainfilemenu_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainfilemenu_btn.ForeColor = Color.White;
            mainfilemenu_btn.Image = (Image)resources.GetObject("mainfilemenu_btn.Image");
            mainfilemenu_btn.ImageAlign = ContentAlignment.MiddleLeft;
            mainfilemenu_btn.Location = new Point(-11, -8);
            mainfilemenu_btn.Name = "mainfilemenu_btn";
            mainfilemenu_btn.Padding = new Padding(25, 0, 0, 0);
            mainfilemenu_btn.Size = new Size(360, 89);
            mainfilemenu_btn.TabIndex = 0;
            mainfilemenu_btn.Text = "            File";
            mainfilemenu_btn.TextAlign = ContentAlignment.MiddleLeft;
            mainfilemenu_btn.UseVisualStyleBackColor = false;
            mainfilemenu_btn.Click += mainfilemenu_btn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(openfile_btn);
            panel4.Location = new Point(3, 79);
            panel4.Name = "panel4";
            panel4.Size = new Size(334, 70);
            panel4.TabIndex = 6;
            // 
            // openfile_btn
            // 
            openfile_btn.BackColor = Color.FromArgb(36, 37, 43);
            openfile_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            openfile_btn.ForeColor = Color.White;
            openfile_btn.Image = (Image)resources.GetObject("openfile_btn.Image");
            openfile_btn.ImageAlign = ContentAlignment.MiddleLeft;
            openfile_btn.Location = new Point(-11, -8);
            openfile_btn.Name = "openfile_btn";
            openfile_btn.Padding = new Padding(25, 0, 0, 0);
            openfile_btn.Size = new Size(360, 89);
            openfile_btn.TabIndex = 0;
            openfile_btn.Text = "            Open File";
            openfile_btn.TextAlign = ContentAlignment.MiddleLeft;
            openfile_btn.UseVisualStyleBackColor = false;
            openfile_btn.Click += openfile_btn_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(newfile_btn);
            panel7.Location = new Point(3, 155);
            panel7.Name = "panel7";
            panel7.Size = new Size(334, 70);
            panel7.TabIndex = 7;
            // 
            // newfile_btn
            // 
            newfile_btn.BackColor = Color.FromArgb(36, 37, 43);
            newfile_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newfile_btn.ForeColor = Color.White;
            newfile_btn.Image = (Image)resources.GetObject("newfile_btn.Image");
            newfile_btn.ImageAlign = ContentAlignment.MiddleLeft;
            newfile_btn.Location = new Point(-11, -8);
            newfile_btn.Name = "newfile_btn";
            newfile_btn.Padding = new Padding(25, 0, 0, 0);
            newfile_btn.Size = new Size(360, 89);
            newfile_btn.TabIndex = 0;
            newfile_btn.Text = "            New File";
            newfile_btn.TextAlign = ContentAlignment.MiddleLeft;
            newfile_btn.UseVisualStyleBackColor = false;
            newfile_btn.Click += newfile_btn_Click;
            // 
            // recentfilepanel
            // 
            recentfilepanel.Controls.Add(panel23);
            recentfilepanel.Controls.Add(panel22);
            recentfilepanel.Location = new Point(3, 231);
            recentfilepanel.Name = "recentfilepanel";
            recentfilepanel.Size = new Size(334, 70);
            recentfilepanel.TabIndex = 8;
            // 
            // panel23
            // 
            panel23.Controls.Add(recentfile_listbox);
            panel23.Dock = DockStyle.Fill;
            panel23.Location = new Point(0, 70);
            panel23.Name = "panel23";
            panel23.Size = new Size(334, 0);
            panel23.TabIndex = 2;
            // 
            // recentfile_listbox
            // 
            recentfile_listbox.BackColor = Color.FromArgb(21, 22, 29);
            recentfile_listbox.Dock = DockStyle.Fill;
            recentfile_listbox.Font = new Font("UbuntuMono Nerd Font", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recentfile_listbox.ForeColor = Color.White;
            recentfile_listbox.FormattingEnabled = true;
            recentfile_listbox.Location = new Point(0, 0);
            recentfile_listbox.Name = "recentfile_listbox";
            recentfile_listbox.ScrollAlwaysVisible = true;
            recentfile_listbox.Size = new Size(334, 0);
            recentfile_listbox.TabIndex = 0;
            recentfile_listbox.DoubleClick += recentfile_listbox_DoubleClick;
            // 
            // panel22
            // 
            panel22.Controls.Add(openrecent_btn);
            panel22.Dock = DockStyle.Top;
            panel22.Location = new Point(0, 0);
            panel22.Name = "panel22";
            panel22.Size = new Size(334, 70);
            panel22.TabIndex = 1;
            // 
            // openrecent_btn
            // 
            openrecent_btn.BackColor = Color.FromArgb(36, 37, 43);
            openrecent_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            openrecent_btn.ForeColor = Color.White;
            openrecent_btn.Image = (Image)resources.GetObject("openrecent_btn.Image");
            openrecent_btn.ImageAlign = ContentAlignment.MiddleLeft;
            openrecent_btn.Location = new Point(-11, -9);
            openrecent_btn.Name = "openrecent_btn";
            openrecent_btn.Padding = new Padding(25, 0, 0, 0);
            openrecent_btn.Size = new Size(360, 89);
            openrecent_btn.TabIndex = 0;
            openrecent_btn.Text = "            Open Recent File";
            openrecent_btn.TextAlign = ContentAlignment.MiddleLeft;
            openrecent_btn.UseVisualStyleBackColor = false;
            openrecent_btn.Click += openrecent_btn_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(save_btn);
            panel11.Location = new Point(3, 307);
            panel11.Name = "panel11";
            panel11.Size = new Size(334, 70);
            panel11.TabIndex = 11;
            // 
            // save_btn
            // 
            save_btn.BackColor = Color.FromArgb(36, 37, 43);
            save_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save_btn.ForeColor = Color.White;
            save_btn.Image = (Image)resources.GetObject("save_btn.Image");
            save_btn.ImageAlign = ContentAlignment.MiddleLeft;
            save_btn.Location = new Point(-11, -8);
            save_btn.Name = "save_btn";
            save_btn.Padding = new Padding(25, 0, 0, 0);
            save_btn.Size = new Size(360, 89);
            save_btn.TabIndex = 0;
            save_btn.Text = "            Save";
            save_btn.TextAlign = ContentAlignment.MiddleLeft;
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // panel12
            // 
            panel12.Controls.Add(saveas_btn);
            panel12.Location = new Point(3, 383);
            panel12.Name = "panel12";
            panel12.Size = new Size(334, 70);
            panel12.TabIndex = 12;
            // 
            // saveas_btn
            // 
            saveas_btn.BackColor = Color.FromArgb(36, 37, 43);
            saveas_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveas_btn.ForeColor = Color.White;
            saveas_btn.Image = (Image)resources.GetObject("saveas_btn.Image");
            saveas_btn.ImageAlign = ContentAlignment.MiddleLeft;
            saveas_btn.Location = new Point(-11, -8);
            saveas_btn.Name = "saveas_btn";
            saveas_btn.Padding = new Padding(25, 0, 0, 0);
            saveas_btn.Size = new Size(360, 89);
            saveas_btn.TabIndex = 0;
            saveas_btn.Text = "            Save As";
            saveas_btn.TextAlign = ContentAlignment.MiddleLeft;
            saveas_btn.UseVisualStyleBackColor = false;
            saveas_btn.Click += saveas_btn_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(button1);
            panel9.Location = new Point(3, 459);
            panel9.Name = "panel9";
            panel9.Size = new Size(334, 70);
            panel9.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(36, 37, 43);
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-11, -8);
            button1.Name = "button1";
            button1.Padding = new Padding(25, 0, 0, 0);
            button1.Size = new Size(360, 89);
            button1.TabIndex = 0;
            button1.Text = "            Close Current";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(button3);
            panel8.Location = new Point(3, 327);
            panel8.Name = "panel8";
            panel8.Size = new Size(334, 70);
            panel8.TabIndex = 15;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(23, 24, 29);
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-11, -8);
            button3.Name = "button3";
            button3.Padding = new Padding(30, 0, 0, 0);
            button3.Size = new Size(360, 89);
            button3.TabIndex = 0;
            button3.Text = "            Close All Tabs";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(button2);
            panel10.Location = new Point(3, 403);
            panel10.Name = "panel10";
            panel10.Size = new Size(334, 70);
            panel10.TabIndex = 14;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(23, 24, 29);
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-11, -8);
            button2.Name = "button2";
            button2.Padding = new Padding(32, 0, 0, 0);
            button2.Size = new Size(360, 89);
            button2.TabIndex = 0;
            button2.Text = "            Close App";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // modetransition
            // 
            modetransition.Interval = 10;
            modetransition.Tick += modetransition_Tick;
            // 
            // footer_layoutpanel
            // 
            footer_layoutpanel.BackColor = Color.FromArgb(23, 24, 29);
            footer_layoutpanel.Controls.Add(panel18);
            footer_layoutpanel.Controls.Add(panel19);
            footer_layoutpanel.Controls.Add(panel20);
            footer_layoutpanel.Dock = DockStyle.Bottom;
            footer_layoutpanel.Location = new Point(69, 919);
            footer_layoutpanel.Name = "footer_layoutpanel";
            footer_layoutpanel.Size = new Size(1597, 33);
            footer_layoutpanel.TabIndex = 11;
            // 
            // panel18
            // 
            panel18.Controls.Add(wordcount_label);
            panel18.Location = new Point(3, 3);
            panel18.Name = "panel18";
            panel18.Size = new Size(271, 30);
            panel18.TabIndex = 12;
            // 
            // wordcount_label
            // 
            wordcount_label.AutoSize = true;
            wordcount_label.ForeColor = Color.White;
            wordcount_label.Location = new Point(3, 8);
            wordcount_label.Name = "wordcount_label";
            wordcount_label.Size = new Size(55, 17);
            wordcount_label.TabIndex = 0;
            wordcount_label.Text = "Words: ";
            wordcount_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel19
            // 
            panel19.Controls.Add(linecount_label);
            panel19.Location = new Point(280, 3);
            panel19.Name = "panel19";
            panel19.Size = new Size(271, 30);
            panel19.TabIndex = 13;
            // 
            // linecount_label
            // 
            linecount_label.AutoSize = true;
            linecount_label.ForeColor = Color.White;
            linecount_label.Location = new Point(3, 8);
            linecount_label.Name = "linecount_label";
            linecount_label.Size = new Size(45, 17);
            linecount_label.TabIndex = 0;
            linecount_label.Text = "Lines: ";
            linecount_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel20
            // 
            panel20.Controls.Add(charactercount_label);
            panel20.Location = new Point(557, 3);
            panel20.Name = "panel20";
            panel20.Size = new Size(271, 30);
            panel20.TabIndex = 14;
            // 
            // charactercount_label
            // 
            charactercount_label.AutoSize = true;
            charactercount_label.ForeColor = Color.White;
            charactercount_label.Location = new Point(3, 8);
            charactercount_label.Name = "charactercount_label";
            charactercount_label.Size = new Size(79, 17);
            charactercount_label.TabIndex = 0;
            charactercount_label.Text = "Characters: ";
            charactercount_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel21
            // 
            panel21.Controls.Add(tabControl1);
            panel21.Dock = DockStyle.Fill;
            panel21.Location = new Point(69, 37);
            panel21.Name = "panel21";
            panel21.Size = new Size(1597, 882);
            panel21.TabIndex = 12;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1597, 882);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightGray;
            tabPage2.Controls.Add(textarea);
            tabPage2.Font = new Font("FiraMono Nerd Font Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage2.ForeColor = SystemColors.ActiveCaptionText;
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1589, 852);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Untitled";
            // 
            // textarea
            // 
            textarea.BackColor = Color.Gainsboro;
            textarea.BorderStyle = BorderStyle.None;
            textarea.Dock = DockStyle.Fill;
            textarea.Font = new Font("JetBrains Mono", 10.15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textarea.Location = new Point(3, 3);
            textarea.Name = "textarea";
            textarea.Size = new Size(1583, 846);
            textarea.TabIndex = 0;
            textarea.Text = "Start Typing, Destiny Awaits!";
            textarea.WordWrap = false;
            textarea.Click += textarea_Click;
            textarea.TextChanged += textarea_TextChanged;
            // 
            // recentfiles_Transition
            // 
            recentfiles_Transition.Interval = 10;
            recentfiles_Transition.Tick += recentfiles_Transition_Tick;
            // 
            // defaultmode_form
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1666, 952);
            Controls.Add(panel21);
            Controls.Add(footer_layoutpanel);
            Controls.Add(sidebarpanel);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "defaultmode_form";
            Text = "Form1";
            FormClosing += defaultmode_form_FormClosing;
            Load += defaultmode_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            switchmode_layoutpanel.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainbutton_picbox).EndInit();
            sidebarpanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            filemenupanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            recentfilepanel.ResumeLayout(false);
            panel23.ResumeLayout(false);
            panel22.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel10.ResumeLayout(false);
            footer_layoutpanel.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel21.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox mainbutton_picbox;
        private Label heading_label;
        private FlowLayoutPanel sidebarpanel;
        private Button settings_btn;
        private Panel panel2;
        private Panel panel3;
        private Button home_btn;
        private Panel panel5;
        private Button mainfilemenu_btn;
        private FlowLayoutPanel filemenupanel;
        private Panel panel6;
        private Button findandreplace_btn;
        private Panel panel4;
        private Button openfile_btn;
        private Panel panel7;
        private Button newfile_btn;
        private Panel recentfilepanel;
        private Button openrecent_btn;
        private Panel panel11;
        private Button save_btn;
        private Panel panel12;
        private Button saveas_btn;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Timer modetransition;
        private FlowLayoutPanel switchmode_layoutpanel;
        private Panel panel13;
        private Button switchmode_btn;
        private Panel panel15;
        private Button quillmode_btn;
        private Panel panel16;
        private Button devmode_btn;
        private Panel panel17;
        private Button modemenuclose_btn;
        private FlowLayoutPanel footer_layoutpanel;
        private Panel panel18;
        private Label wordcount_label;
        private Panel panel19;
        private Label linecount_label;
        private Panel panel20;
        private Label charactercount_label;
        private Panel panel21;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private Panel panel9;
        private Button button1;
        private Panel panel10;
        private Button button2;
        private Panel panel22;
        private Panel panel23;
        private ListBox recentfile_listbox;
        private System.Windows.Forms.Timer recentfiles_Transition;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.NightControlBox controlbar;
        private Panel panel8;
        private Button button3;
        private RichTextBox textarea;
    }
}
