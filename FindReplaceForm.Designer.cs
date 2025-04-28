namespace Swift_Edit
{
    partial class FindReplaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindReplaceForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            findandreplace_label = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            textBox2 = new TextBox();
            label2 = new Label();
            match_CheckBox = new CheckBox();
            whole_CheckBox = new CheckBox();
            findnext_btn = new Button();
            replace_btn = new Button();
            replaceall_btn = new Button();
            cancel_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(findandreplace_label);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 36);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.IndianRed;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(499, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // findandreplace_label
            // 
            findandreplace_label.AutoSize = true;
            findandreplace_label.Font = new Font("Iosevka NF Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            findandreplace_label.Location = new Point(12, 9);
            findandreplace_label.Name = "findandreplace_label";
            findandreplace_label.Size = new Size(170, 21);
            findandreplace_label.TabIndex = 1;
            findandreplace_label.Text = "Find and Replace";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(34, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 40);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 27);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Iosevka NF Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 40);
            label1.TabIndex = 2;
            label1.Text = "Find: ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(34, 124);
            panel3.Name = "panel3";
            panel3.Size = new Size(449, 40);
            panel3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(178, 7);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Iosevka NF Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 40);
            label2.TabIndex = 2;
            label2.Text = "Replace: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // match_CheckBox
            // 
            match_CheckBox.AutoSize = true;
            match_CheckBox.Font = new Font("MartianMono NF", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            match_CheckBox.Location = new Point(129, 197);
            match_CheckBox.Name = "match_CheckBox";
            match_CheckBox.Size = new Size(85, 22);
            match_CheckBox.TabIndex = 3;
            match_CheckBox.Text = "Match";
            match_CheckBox.UseVisualStyleBackColor = true;
            match_CheckBox.CheckedChanged += match_CheckBox_CheckedChanged;
            // 
            // whole_CheckBox
            // 
            whole_CheckBox.AutoSize = true;
            whole_CheckBox.Font = new Font("MartianMono NF", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            whole_CheckBox.Location = new Point(300, 197);
            whole_CheckBox.Name = "whole_CheckBox";
            whole_CheckBox.Size = new Size(85, 22);
            whole_CheckBox.TabIndex = 4;
            whole_CheckBox.Text = "Whole";
            whole_CheckBox.UseVisualStyleBackColor = true;
            whole_CheckBox.CheckedChanged += whole_CheckBox_CheckedChanged;
            // 
            // findnext_btn
            // 
            findnext_btn.Font = new Font("MartianMono NFP", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            findnext_btn.Location = new Point(107, 263);
            findnext_btn.Name = "findnext_btn";
            findnext_btn.Size = new Size(148, 40);
            findnext_btn.TabIndex = 5;
            findnext_btn.Text = "Find Next";
            findnext_btn.UseVisualStyleBackColor = true;
            findnext_btn.Click += findnext_btn_Click;
            // 
            // replace_btn
            // 
            replace_btn.Font = new Font("MartianMono NFP", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            replace_btn.Location = new Point(284, 263);
            replace_btn.Name = "replace_btn";
            replace_btn.Size = new Size(148, 40);
            replace_btn.TabIndex = 6;
            replace_btn.Text = "Replace";
            replace_btn.UseVisualStyleBackColor = true;
            replace_btn.Click += replace_btn_Click;
            // 
            // replaceall_btn
            // 
            replaceall_btn.Font = new Font("MartianMono NFP", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            replaceall_btn.Location = new Point(107, 328);
            replaceall_btn.Name = "replaceall_btn";
            replaceall_btn.Size = new Size(148, 40);
            replaceall_btn.TabIndex = 7;
            replaceall_btn.Text = "Replace All";
            replaceall_btn.UseVisualStyleBackColor = true;
            replaceall_btn.Click += replaceall_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.Font = new Font("MartianMono NFP", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancel_btn.Location = new Point(284, 328);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(148, 40);
            cancel_btn.TabIndex = 8;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // FindReplaceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(555, 417);
            Controls.Add(cancel_btn);
            Controls.Add(replaceall_btn);
            Controls.Add(replace_btn);
            Controls.Add(findnext_btn);
            Controls.Add(whole_CheckBox);
            Controls.Add(match_CheckBox);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FindReplaceForm";
            Text = "FindReplaceForm2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label findandreplace_label;
        private Label label1;
        private TextBox textBox1;
        private Panel panel3;
        private TextBox textBox2;
        private Label label2;
        private CheckBox match_CheckBox;
        private CheckBox whole_CheckBox;
        private Button findnext_btn;
        private Button replace_btn;
        private Button replaceall_btn;
        private Button cancel_btn;
        private PictureBox pictureBox1;
    }
}