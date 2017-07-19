namespace CYaPass
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.GridPictureBox = new System.Windows.Forms.PictureBox();
            this.ClearGridButton = new System.Windows.Forms.Button();
            this.addUpperCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.MaxLengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.SetMaxLengthCheckBox = new System.Windows.Forms.CheckBox();
            this.AddSpecialCharsTextBox = new System.Windows.Forms.TextBox();
            this.AddSpecialCharsCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SiteListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteSiteButton = new System.Windows.Forms.Button();
            this.AddSiteKeyButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.drawPatterGroupBox = new System.Windows.Forms.GroupBox();
            this.hidePatternCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridPictureBox)).BeginInit();
            this.OptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLengthUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.drawPatterGroupBox.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(6, 42);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(517, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Checked = true;
            this.showPasswordCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(6, 19);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(99, 17);
            this.showPasswordCheckBox.TabIndex = 1;
            this.showPasswordCheckBox.Text = "show password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // GridPictureBox
            // 
            this.GridPictureBox.Location = new System.Drawing.Point(9, 41);
            this.GridPictureBox.Name = "GridPictureBox";
            this.GridPictureBox.Size = new System.Drawing.Size(252, 252);
            this.GridPictureBox.TabIndex = 6;
            this.GridPictureBox.TabStop = false;
            this.GridPictureBox.Click += new System.EventHandler(this.GridPictureBox_Click);
            this.GridPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GridPictureBox_Paint);
            this.GridPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GridPictureBox_MouseMove);
            // 
            // ClearGridButton
            // 
            this.ClearGridButton.Location = new System.Drawing.Point(192, 300);
            this.ClearGridButton.Name = "ClearGridButton";
            this.ClearGridButton.Size = new System.Drawing.Size(75, 23);
            this.ClearGridButton.TabIndex = 11;
            this.ClearGridButton.Text = "Clear Grid";
            this.ClearGridButton.UseVisualStyleBackColor = true;
            this.ClearGridButton.Click += new System.EventHandler(this.ClearGridButton_Click);
            // 
            // addUpperCaseCheckBox
            // 
            this.addUpperCaseCheckBox.AutoSize = true;
            this.addUpperCaseCheckBox.Location = new System.Drawing.Point(6, 19);
            this.addUpperCaseCheckBox.Name = "addUpperCaseCheckBox";
            this.addUpperCaseCheckBox.Size = new System.Drawing.Size(101, 17);
            this.addUpperCaseCheckBox.TabIndex = 13;
            this.addUpperCaseCheckBox.Text = "Add UpperCase";
            this.addUpperCaseCheckBox.UseVisualStyleBackColor = true;
            this.addUpperCaseCheckBox.CheckedChanged += new System.EventHandler(this.addUpperCaseCheckBox_CheckedChanged);
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Controls.Add(this.MaxLengthUpDown);
            this.OptionsGroupBox.Controls.Add(this.SetMaxLengthCheckBox);
            this.OptionsGroupBox.Controls.Add(this.AddSpecialCharsTextBox);
            this.OptionsGroupBox.Controls.Add(this.AddSpecialCharsCheckBox);
            this.OptionsGroupBox.Controls.Add(this.addUpperCaseCheckBox);
            this.OptionsGroupBox.Location = new System.Drawing.Point(19, 244);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(252, 95);
            this.OptionsGroupBox.TabIndex = 14;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // MaxLengthUpDown
            // 
            this.MaxLengthUpDown.Location = new System.Drawing.Point(125, 65);
            this.MaxLengthUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.MaxLengthUpDown.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.MaxLengthUpDown.Name = "MaxLengthUpDown";
            this.MaxLengthUpDown.Size = new System.Drawing.Size(120, 20);
            this.MaxLengthUpDown.TabIndex = 17;
            this.MaxLengthUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.MaxLengthUpDown.ValueChanged += new System.EventHandler(this.MaxLengthUpDown_ValueChanged);
            // 
            // SetMaxLengthCheckBox
            // 
            this.SetMaxLengthCheckBox.AutoSize = true;
            this.SetMaxLengthCheckBox.Location = new System.Drawing.Point(6, 66);
            this.SetMaxLengthCheckBox.Name = "SetMaxLengthCheckBox";
            this.SetMaxLengthCheckBox.Size = new System.Drawing.Size(101, 17);
            this.SetMaxLengthCheckBox.TabIndex = 16;
            this.SetMaxLengthCheckBox.Text = "Set Max Length";
            this.SetMaxLengthCheckBox.UseVisualStyleBackColor = true;
            this.SetMaxLengthCheckBox.CheckedChanged += new System.EventHandler(this.SetMaxLengthCheckBox_CheckedChanged);
            // 
            // AddSpecialCharsTextBox
            // 
            this.AddSpecialCharsTextBox.Location = new System.Drawing.Point(125, 40);
            this.AddSpecialCharsTextBox.Name = "AddSpecialCharsTextBox";
            this.AddSpecialCharsTextBox.Size = new System.Drawing.Size(120, 20);
            this.AddSpecialCharsTextBox.TabIndex = 15;
            this.AddSpecialCharsTextBox.TextChanged += new System.EventHandler(this.AddSpecialCharsTextBox_TextChanged);
            // 
            // AddSpecialCharsCheckBox
            // 
            this.AddSpecialCharsCheckBox.AutoSize = true;
            this.AddSpecialCharsCheckBox.Location = new System.Drawing.Point(6, 42);
            this.AddSpecialCharsCheckBox.Name = "AddSpecialCharsCheckBox";
            this.AddSpecialCharsCheckBox.Size = new System.Drawing.Size(113, 17);
            this.AddSpecialCharsCheckBox.TabIndex = 14;
            this.AddSpecialCharsCheckBox.Text = "Add Special Chars";
            this.AddSpecialCharsCheckBox.UseVisualStyleBackColor = true;
            this.AddSpecialCharsCheckBox.CheckedChanged += new System.EventHandler(this.AddSpecialCharsCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showPasswordCheckBox);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Location = new System.Drawing.Point(19, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 76);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generated Password";
            // 
            // SiteListBox
            // 
            this.SiteListBox.FormattingEnabled = true;
            this.SiteListBox.Location = new System.Drawing.Point(14, 42);
            this.SiteListBox.Name = "SiteListBox";
            this.SiteListBox.Size = new System.Drawing.Size(233, 134);
            this.SiteListBox.TabIndex = 16;
            this.SiteListBox.SelectedIndexChanged += new System.EventHandler(this.SiteListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteSiteButton);
            this.groupBox2.Controls.Add(this.AddSiteKeyButton);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.SiteListBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 211);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sites/Keys";
            // 
            // deleteSiteButton
            // 
            this.deleteSiteButton.Location = new System.Drawing.Point(84, 182);
            this.deleteSiteButton.Name = "deleteSiteButton";
            this.deleteSiteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteSiteButton.TabIndex = 18;
            this.deleteSiteButton.Text = "Delete Site";
            this.deleteSiteButton.UseVisualStyleBackColor = true;
            this.deleteSiteButton.Click += new System.EventHandler(this.deleteSiteButton_Click);
            // 
            // AddSiteKeyButton
            // 
            this.AddSiteKeyButton.Location = new System.Drawing.Point(165, 182);
            this.AddSiteKeyButton.Name = "AddSiteKeyButton";
            this.AddSiteKeyButton.Size = new System.Drawing.Size(75, 23);
            this.AddSiteKeyButton.TabIndex = 17;
            this.AddSiteKeyButton.Text = "Add Site";
            this.AddSiteKeyButton.UseVisualStyleBackColor = true;
            this.AddSiteKeyButton.Click += new System.EventHandler(this.AddSiteKeyButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(10, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "1. Select (or add) a Site Key";
            // 
            // drawPatterGroupBox
            // 
            this.drawPatterGroupBox.Controls.Add(this.hidePatternCheckBox);
            this.drawPatterGroupBox.Controls.Add(this.label8);
            this.drawPatterGroupBox.Controls.Add(this.ClearGridButton);
            this.drawPatterGroupBox.Controls.Add(this.GridPictureBox);
            this.drawPatterGroupBox.Location = new System.Drawing.Point(270, 27);
            this.drawPatterGroupBox.Name = "drawPatterGroupBox";
            this.drawPatterGroupBox.Size = new System.Drawing.Size(271, 331);
            this.drawPatterGroupBox.TabIndex = 17;
            this.drawPatterGroupBox.TabStop = false;
            this.drawPatterGroupBox.Text = "Draw Pattern";
            // 
            // hidePatternCheckBox
            // 
            this.hidePatternCheckBox.AutoSize = true;
            this.hidePatternCheckBox.Location = new System.Drawing.Point(9, 304);
            this.hidePatternCheckBox.Name = "hidePatternCheckBox";
            this.hidePatternCheckBox.Size = new System.Drawing.Size(85, 17);
            this.hidePatternCheckBox.TabIndex = 13;
            this.hidePatternCheckBox.Text = "Hide Pattern";
            this.hidePatternCheckBox.UseVisualStyleBackColor = true;
            this.hidePatternCheckBox.CheckedChanged += new System.EventHandler(this.hidePatternCheckBox_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(21, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "2. Draw a pattern";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(554, 24);
            this.mainMenuStrip.TabIndex = 18;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aboutMenuItem.Text = "About...";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 453);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.drawPatterGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "C\'Ya Pass";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPictureBox)).EndInit();
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLengthUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.drawPatterGroupBox.ResumeLayout(false);
            this.drawPatterGroupBox.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.PictureBox GridPictureBox;
        private System.Windows.Forms.Button ClearGridButton;
        private System.Windows.Forms.CheckBox addUpperCaseCheckBox;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.TextBox AddSpecialCharsTextBox;
        private System.Windows.Forms.CheckBox AddSpecialCharsCheckBox;
        private System.Windows.Forms.NumericUpDown MaxLengthUpDown;
        private System.Windows.Forms.CheckBox SetMaxLengthCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox SiteListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddSiteKeyButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox drawPatterGroupBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button deleteSiteButton;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.CheckBox hidePatternCheckBox;
    }
}

