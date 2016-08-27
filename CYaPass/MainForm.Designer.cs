namespace DragPass
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordGroupBox = new System.Windows.Forms.GroupBox();
            this.SaltGroupBox = new System.Windows.Forms.GroupBox();
            this.saltBoxMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearSaltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaltIsSetCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GridPictureBox = new System.Windows.Forms.PictureBox();
            this.ClearGridButton = new System.Windows.Forms.Button();
            this.GenPasswordButton = new System.Windows.Forms.Button();
            this.addUpperCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.MaxLengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.SetMaxLengthCheckBox = new System.Windows.Forms.CheckBox();
            this.AddSpecialCharsTextBox = new System.Windows.Forms.TextBox();
            this.AddSpecialCharsCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SiteListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddSiteKeyButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.drawPatterGroupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.remoteFileUrlTextBox = new System.Windows.Forms.TextBox();
            this.RemoteFileMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reloadFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unloadFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteTextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.deleteSiteButton = new System.Windows.Forms.Button();
            this.passwordGroupBox.SuspendLayout();
            this.SaltGroupBox.SuspendLayout();
            this.saltBoxMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPictureBox)).BeginInit();
            this.OptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLengthUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.drawPatterGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.RemoteFileMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "2. Drop any file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "anywhere on this box.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "to generate a password";
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
            // passwordGroupBox
            // 
            this.passwordGroupBox.Controls.Add(this.label1);
            this.passwordGroupBox.Controls.Add(this.label2);
            this.passwordGroupBox.Controls.Add(this.label3);
            this.passwordGroupBox.Location = new System.Drawing.Point(298, 445);
            this.passwordGroupBox.Name = "passwordGroupBox";
            this.passwordGroupBox.Size = new System.Drawing.Size(250, 115);
            this.passwordGroupBox.TabIndex = 5;
            this.passwordGroupBox.TabStop = false;
            this.passwordGroupBox.Text = "Drop File";
            this.passwordGroupBox.Visible = false;
            // 
            // SaltGroupBox
            // 
            this.SaltGroupBox.ContextMenuStrip = this.saltBoxMenuStrip;
            this.SaltGroupBox.Controls.Add(this.SaltIsSetCheckBox);
            this.SaltGroupBox.Controls.Add(this.label4);
            this.SaltGroupBox.Controls.Add(this.label5);
            this.SaltGroupBox.Controls.Add(this.label6);
            this.SaltGroupBox.Location = new System.Drawing.Point(19, 331);
            this.SaltGroupBox.Name = "SaltGroupBox";
            this.SaltGroupBox.Size = new System.Drawing.Size(250, 104);
            this.SaltGroupBox.TabIndex = 1;
            this.SaltGroupBox.TabStop = false;
            this.SaltGroupBox.Text = "Salt File";
            // 
            // saltBoxMenuStrip
            // 
            this.saltBoxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearSaltToolStripMenuItem});
            this.saltBoxMenuStrip.Name = "saltBoxMenuStrip";
            this.saltBoxMenuStrip.Size = new System.Drawing.Size(124, 26);
            // 
            // clearSaltToolStripMenuItem
            // 
            this.clearSaltToolStripMenuItem.Name = "clearSaltToolStripMenuItem";
            this.clearSaltToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.clearSaltToolStripMenuItem.Text = "Clear Salt";
            this.clearSaltToolStripMenuItem.Click += new System.EventHandler(this.clearSaltToolStripMenuItem_Click);
            // 
            // SaltIsSetCheckBox
            // 
            this.SaltIsSetCheckBox.AutoSize = true;
            this.SaltIsSetCheckBox.Enabled = false;
            this.SaltIsSetCheckBox.Location = new System.Drawing.Point(191, 86);
            this.SaltIsSetCheckBox.Name = "SaltIsSetCheckBox";
            this.SaltIsSetCheckBox.Size = new System.Drawing.Size(42, 17);
            this.SaltIsSetCheckBox.TabIndex = 3;
            this.SaltIsSetCheckBox.Text = "Set";
            this.SaltIsSetCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(20, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "(Optional) Drop a file";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "anywhere on this box.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(20, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "to generate a SALT.";
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
            // GenPasswordButton
            // 
            this.GenPasswordButton.Location = new System.Drawing.Point(424, 68);
            this.GenPasswordButton.Name = "GenPasswordButton";
            this.GenPasswordButton.Size = new System.Drawing.Size(99, 23);
            this.GenPasswordButton.TabIndex = 12;
            this.GenPasswordButton.Text = "Gen Password";
            this.GenPasswordButton.UseVisualStyleBackColor = true;
            this.GenPasswordButton.Click += new System.EventHandler(this.GenPasswordButton_Click);
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
            this.OptionsGroupBox.Location = new System.Drawing.Point(19, 230);
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
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.GenPasswordButton);
            this.groupBox1.Location = new System.Drawing.Point(19, 445);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 103);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generated Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(253, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "3. Create Password";
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
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 211);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sites/Keys";
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
            this.drawPatterGroupBox.Controls.Add(this.label8);
            this.drawPatterGroupBox.Controls.Add(this.ClearGridButton);
            this.drawPatterGroupBox.Controls.Add(this.GridPictureBox);
            this.drawPatterGroupBox.Location = new System.Drawing.Point(270, 13);
            this.drawPatterGroupBox.Name = "drawPatterGroupBox";
            this.drawPatterGroupBox.Size = new System.Drawing.Size(271, 331);
            this.drawPatterGroupBox.TabIndex = 17;
            this.drawPatterGroupBox.TabStop = false;
            this.drawPatterGroupBox.Text = "Draw Pattern";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.remoteFileUrlTextBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(279, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 100);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Remote File";
            this.groupBox3.DragDrop += new System.Windows.Forms.DragEventHandler(this.groupBox3_DragDrop);
            this.groupBox3.DragEnter += new System.Windows.Forms.DragEventHandler(this.groupBox3_DragEnter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "URL:";
            // 
            // remoteFileUrlTextBox
            // 
            this.remoteFileUrlTextBox.AllowDrop = true;
            this.remoteFileUrlTextBox.ContextMenuStrip = this.RemoteFileMenuStrip;
            this.remoteFileUrlTextBox.Location = new System.Drawing.Point(15, 64);
            this.remoteFileUrlTextBox.Name = "remoteFileUrlTextBox";
            this.remoteFileUrlTextBox.Size = new System.Drawing.Size(237, 20);
            this.remoteFileUrlTextBox.TabIndex = 2;
            this.remoteFileUrlTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.remoteFileUrlTextBox_DragDrop);
            this.remoteFileUrlTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.remoteFileUrlTextBox_DragEnter);
            // 
            // RemoteFileMenuStrip
            // 
            this.RemoteFileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadFileMenuItem,
            this.unloadFileMenuItem,
            this.DeleteTextMenuItem});
            this.RemoteFileMenuStrip.Name = "RemoteFileMenuStrip";
            this.RemoteFileMenuStrip.Size = new System.Drawing.Size(134, 70);
            // 
            // reloadFileMenuItem
            // 
            this.reloadFileMenuItem.Name = "reloadFileMenuItem";
            this.reloadFileMenuItem.Size = new System.Drawing.Size(133, 22);
            this.reloadFileMenuItem.Text = "Reload File";
            this.reloadFileMenuItem.Click += new System.EventHandler(this.reloadFileMenuItem_Click);
            // 
            // unloadFileMenuItem
            // 
            this.unloadFileMenuItem.Name = "unloadFileMenuItem";
            this.unloadFileMenuItem.Size = new System.Drawing.Size(133, 22);
            this.unloadFileMenuItem.Text = "Unload File";
            this.unloadFileMenuItem.Click += new System.EventHandler(this.unloadFileMenuItem_Click);
            // 
            // DeleteTextMenuItem
            // 
            this.DeleteTextMenuItem.Name = "DeleteTextMenuItem";
            this.DeleteTextMenuItem.Size = new System.Drawing.Size(133, 22);
            this.DeleteTextMenuItem.Text = "Delete";
            this.DeleteTextMenuItem.Click += new System.EventHandler(this.DeleteTextMenuItem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(11, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "(Optional) Remote File";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 558);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.drawPatterGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaltGroupBox);
            this.Controls.Add(this.passwordGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "C\'Ya Pass";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDoubleClick);
            this.passwordGroupBox.ResumeLayout(false);
            this.passwordGroupBox.PerformLayout();
            this.SaltGroupBox.ResumeLayout(false);
            this.SaltGroupBox.PerformLayout();
            this.saltBoxMenuStrip.ResumeLayout(false);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.RemoteFileMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.GroupBox passwordGroupBox;
        private System.Windows.Forms.GroupBox SaltGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox SaltIsSetCheckBox;
        private System.Windows.Forms.ContextMenuStrip saltBoxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem clearSaltToolStripMenuItem;
        private System.Windows.Forms.PictureBox GridPictureBox;
        private System.Windows.Forms.Button ClearGridButton;
        private System.Windows.Forms.Button GenPasswordButton;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox remoteFileUrlTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip RemoteFileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem reloadFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unloadFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteTextMenuItem;
        private System.Windows.Forms.Button deleteSiteButton;
    }
}

