using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYaPass
{
    public partial class AddSiteForm : Form
    {

        public SiteKey localItem;
        bool dontClose;

        public AddSiteForm()
        {
            InitializeComponent();
        }

        public AddSiteForm(SiteKey sk)
        {
            InitializeComponent();
            addSpecialCharsCheckBox.Checked = sk.HasSpecialChars;
            addUppercaseCheckBox.Checked = sk.HasUpperCase;
            if (sk.MaxLength > 0)
            {
                setMaxLengthCheckBox.Checked = true;
                maxLengthNumUpDown.Value = sk.MaxLength;
            }
            SiteTextBox.Text = sk.Key;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (SiteTextBox.Text == String.Empty)
            {
                MessageBox.Show(this, "You must provide at least one character for the site.", "Blank entries not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dontClose = true;
                return;
            }
            localItem = SiteKeys.GetItemByKey(SiteTextBox.Text, MainForm.allSites);
            // set new options on found item
            if (localItem != null)
            {
                localItem.HasSpecialChars = addSpecialCharsCheckBox.Checked;
                localItem.HasUpperCase = addUppercaseCheckBox.Checked;
                localItem.MaxLength = setMaxLengthCheckBox.Checked ? Convert.ToInt32(maxLengthNumUpDown.Value) : 0;
            }
            else
            {
                localItem = new SiteKey(SiteTextBox.Text,
                    this.setMaxLengthCheckBox.Checked ?
                Convert.ToInt32(this.maxLengthNumUpDown.Value) : 0,
                this.addSpecialCharsCheckBox.Checked,
                this.addUppercaseCheckBox.Checked);
            }
            dontClose = false;
        }

        private void AddSiteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dontClose)
            {
                e.Cancel = true;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            dontClose = false;
        }

        private void AddSiteForm_Shown(object sender, EventArgs e)
        {
            SiteTextBox.Focus();
        }
    }
}
