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

        public string localItem;
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
            localItem = SiteTextBox.Text;
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
