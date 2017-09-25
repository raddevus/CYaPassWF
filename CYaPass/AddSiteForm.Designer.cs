namespace CYaPass
{
    partial class AddSiteForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SiteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addUppercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.addSpecialCharsCheckBox = new System.Windows.Forms.CheckBox();
            this.setMaxLengthCheckBox = new System.Windows.Forms.CheckBox();
            this.maxLengthNumUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.maxLengthNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(217, 79);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(312, 81);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SiteTextBox
            // 
            this.SiteTextBox.Location = new System.Drawing.Point(13, 29);
            this.SiteTextBox.Name = "SiteTextBox";
            this.SiteTextBox.Size = new System.Drawing.Size(374, 20);
            this.SiteTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Site:";
            // 
            // addUppercaseCheckBox
            // 
            this.addUppercaseCheckBox.AutoSize = true;
            this.addUppercaseCheckBox.Location = new System.Drawing.Point(16, 56);
            this.addUppercaseCheckBox.Name = "addUppercaseCheckBox";
            this.addUppercaseCheckBox.Size = new System.Drawing.Size(101, 17);
            this.addUppercaseCheckBox.TabIndex = 4;
            this.addUppercaseCheckBox.Text = "Add UpperCase";
            this.addUppercaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // addSpecialCharsCheckBox
            // 
            this.addSpecialCharsCheckBox.AutoSize = true;
            this.addSpecialCharsCheckBox.Location = new System.Drawing.Point(123, 56);
            this.addSpecialCharsCheckBox.Name = "addSpecialCharsCheckBox";
            this.addSpecialCharsCheckBox.Size = new System.Drawing.Size(113, 17);
            this.addSpecialCharsCheckBox.TabIndex = 5;
            this.addSpecialCharsCheckBox.Text = "Add Special Chars";
            this.addSpecialCharsCheckBox.UseVisualStyleBackColor = true;
            // 
            // setMaxLengthCheckBox
            // 
            this.setMaxLengthCheckBox.AutoSize = true;
            this.setMaxLengthCheckBox.Location = new System.Drawing.Point(243, 56);
            this.setMaxLengthCheckBox.Name = "setMaxLengthCheckBox";
            this.setMaxLengthCheckBox.Size = new System.Drawing.Size(101, 17);
            this.setMaxLengthCheckBox.TabIndex = 6;
            this.setMaxLengthCheckBox.Text = "Set Max Length";
            this.setMaxLengthCheckBox.UseVisualStyleBackColor = true;
            // 
            // maxLengthNumUpDown
            // 
            this.maxLengthNumUpDown.Location = new System.Drawing.Point(341, 55);
            this.maxLengthNumUpDown.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.maxLengthNumUpDown.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.maxLengthNumUpDown.Name = "maxLengthNumUpDown";
            this.maxLengthNumUpDown.Size = new System.Drawing.Size(46, 20);
            this.maxLengthNumUpDown.TabIndex = 7;
            this.maxLengthNumUpDown.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // AddSiteForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 114);
            this.Controls.Add(this.maxLengthNumUpDown);
            this.Controls.Add(this.setMaxLengthCheckBox);
            this.Controls.Add(this.addSpecialCharsCheckBox);
            this.Controls.Add(this.addUppercaseCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SiteTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddSiteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Site";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddSiteForm_FormClosing);
            this.Shown += new System.EventHandler(this.AddSiteForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.maxLengthNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox SiteTextBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox addUppercaseCheckBox;
        public System.Windows.Forms.CheckBox addSpecialCharsCheckBox;
        public System.Windows.Forms.CheckBox setMaxLengthCheckBox;
        public System.Windows.Forms.NumericUpDown maxLengthNumUpDown;
    }
}