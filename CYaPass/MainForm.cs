using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Reflection;

namespace CYaPass
{
    public partial class MainForm : Form
    {
        private byte[] saltBytes;
        private Point previousPoint = new Point();
        private int postWidth = 10;
        private int centerPoint = 50;
        private List<Point> allPosts;
        private int offset = 5;
        private Point MouseLoc = new Point();
        private StringBuilder pwdBuilder;
        private StringBuilder remoteFileData;
        private SiteKeys allSites;
        private UserPath us = new UserPath();
        private int hitTestIdx;
        private String appHomeFolder;
        private String appDataLocal;

        public MainForm()
        {
            InitializeComponent();
            var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);

            appHomeFolder = versionInfo.CompanyName;
            appDataLocal = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            allSites = new SiteKeys(Path.Combine(appDataLocal, appHomeFolder));
            if (!Directory.Exists(Path.Combine(appDataLocal,appHomeFolder)))
            {
                Directory.CreateDirectory(Path.Combine(appDataLocal, appHomeFolder));
            }
            GenerateAllPosts();
            LoadAllSites();
        }


        void LoadAllSites()
        {
            if (File.Exists( allSites.fileName))
            {
                String allJson = File.ReadAllText(Path.Combine(appDataLocal,allSites.fileName));
                String tempPath = allSites.fileName;
                allSites = (SiteKeys)JsonConvert.DeserializeObject(allJson, allSites.GetType());
                allSites.fileName = tempPath;
            }
        }

        void SaltGroupBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void SaltGroupBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                var m256 = SHA256Managed.Create();
                byte[] allBytes = File.ReadAllBytes(file);
                saltBytes = m256.ComputeHash(allBytes);
            }
        }

        void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                var m256 = SHA256Managed.Create();
                byte[] fileBytes = File.ReadAllBytes(file);
                byte[] allBytes = null;
                
                allBytes = fileBytes;
                
                byte[] hashBytes = m256.ComputeHash(allBytes);
                StringBuilder pwd = new StringBuilder();
                // create a string of hex values for output
                foreach (byte b in hashBytes) { pwd.AppendFormat("{0:x2}", b); }

                if (showPasswordCheckBox.Checked)
                {
                    passwordTextBox.Text = pwd.ToString();
                }
                Clipboard.SetText(pwd.ToString());
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!showPasswordCheckBox.Checked)
            {
                passwordTextBox.Text = string.Empty;
            }
        }

        private void GridPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawGridLines(g);
            DrawPosts(g);
            DrawUserShape();
            g = null;
        }

        private void DrawGridLines(Graphics g)
        {
            int numOfCells = 6;
            int cellSize = 50;
            Pen p = new Pen(Color.Black);

            for (int y = 0; y < numOfCells; ++y)
            {
                g.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
            }

            for (int x = 0; x < numOfCells; ++x)
            {
                g.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
            }
        }

        private void DrawUserShape()
        {
            Graphics g = GridPictureBox.CreateGraphics();
            Pen p = new Pen(Color.Green);
            p.Width = 5;

            foreach (Segment s in us.allSegments)
            {
                g.DrawLine(p,s.Begin.X + offset, s.Begin.Y + offset, s.End.X + offset, s.End.Y + offset);
            }
           
            g = null;

        }

        private void GenerateAllPosts()
        {
            allPosts = new List<Point>();
            for (int x = 0; x < 6; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    allPosts.Add(new Point((centerPoint * x) - (postWidth / 2), (centerPoint * y) - (postWidth / 2)));

                }
            }
        }

        private void DrawPosts(Graphics g)
        {
            Pen p = new Pen(Color.OrangeRed);
            p.Width = 1;
            foreach (Point Pt in allPosts) {
                //g.DrawArc(p, Pt.X, Pt.Y, postWidth,postWidth, 0f, (float)(360));
                g.FillPie(p.Brush, new Rectangle(Pt.X, Pt.Y, 10, 10), 0f, (float)360);
            }
        }

        private bool HitTest(ref Point p)
        {
            int loopcount = 0;
            foreach (Point Pt in allPosts)
            {
                if ((p.X >= (Pt.X + offset) - postWidth) && (p.X <= (Pt.X + offset) + postWidth))
                {
                    if ((p.Y >= (Pt.Y + offset) - postWidth) && (p.Y <= (Pt.Y + offset) + postWidth))
                    {
                        p = Pt;
                        hitTestIdx = loopcount;
                        return true;
                    }
                }
                loopcount++;
            }

            return false;
        }

        private void DrawLine(int x, int y)
        {
            if (previousPoint.IsEmpty) { return; }
            Graphics g = GridPictureBox.CreateGraphics();
            Pen p = new Pen(Color.Green);
            p.Width = 5;
            g.DrawLine(p, x + offset, y + offset, previousPoint.X + offset, previousPoint.Y + offset);

            g = null;
        }

        private void SelectNewPoint()
        {
            Point currentPoint = new Point(MouseLoc.X, MouseLoc.Y);
            if (!HitTest(ref currentPoint))
            {
                return;
            }

            us.append(currentPoint, hitTestIdx + (hitTestIdx * (hitTestIdx / 6) * 10));
            us.CalculateGeometricValue();
        }

        private void DrawHighlight()
        {
            Graphics g = GridPictureBox.CreateGraphics();
            Pen p = new Pen(Color.Orange);
            p.Width = 2;
            
            g.DrawArc(p, us.allPoints[0].X - offset, us.allPoints[0].Y - offset,  postWidth+10,postWidth+10, 0f, (float)(360));
        }

        private void GridPictureBox_Click(object sender, EventArgs e)
        {
            SelectNewPoint();
            DrawHighlight();
            DrawUserShape();
            GeneratePassword();
        }

        private void GridPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            MouseLoc = new Point(e.X, e.Y);
        }

        private void ClearGridButton_Click(object sender, EventArgs e)
        {
            us = new UserPath();
            GridPictureBox.Invalidate();
            Graphics g = GridPictureBox.CreateGraphics();
            DrawGridLines(g);
            DrawPosts(g);
            ClearPasswordInfo();
        }

        private void ClearPasswordInfo(){
            Clipboard.Clear();
            passwordTextBox.Text = String.Empty;
        }

        private void AddUpperCaseLetter(StringBuilder pwd)
        {
            int index = -1;
            string target = string.Empty;
            foreach (Char c in pwd.ToString())
            {
                index++;
                if (Char.IsLetter(c))
                {
                    target = c.ToString();
                    break;
                }
            }
            pwd[index] = Convert.ToChar(target.ToUpper());
        }

        private string AddSpecialChars(string pwd)
        {
            if (AddSpecialCharsTextBox.Text == string.Empty)
            {
                return pwd;
            }
            string temp = pwd;
            int charOffset = 2;
            pwd = temp.Substring(0, charOffset);
            pwd += AddSpecialCharsTextBox.Text;
            pwd += temp.Substring(2, temp.Length - charOffset);
            return pwd;
        }

        private void ComputeHashBytes()
        {
            var m256 = SHA256Managed.Create();
            var patternBytes = System.Text.Encoding.UTF8.GetBytes(us.PointValue.ToString());
            var selItemText = SiteListBox.SelectedItem.ToString();
            var siteBytes = System.Text.Encoding.UTF8.GetBytes(selItemText);
            byte[] allBytes = null;

            allBytes = new byte[patternBytes.Length + siteBytes.Length];
            patternBytes.CopyTo(allBytes, 0);
            siteBytes.CopyTo(allBytes, patternBytes.Length);

            byte[] hashBytes = m256.ComputeHash(allBytes);
            pwdBuilder = new StringBuilder();
            // create a string of hex values for output
            foreach (byte b in hashBytes) { pwdBuilder.AppendFormat("{0:x2}", b); }
        }

        private string CheckForUrlPrefix(string inUrl)
        {
   			if ((inUrl.IndexOf("http://", StringComparison.OrdinalIgnoreCase) == 0) ||
   				(inUrl.IndexOf("https://", StringComparison.OrdinalIgnoreCase) == 0))
   			{
   				return inUrl;
   			}
   			else
   			{
   				return string.Format("http://{0}", inUrl);
   			}
   		}		

        private void GeneratePassword()
        {
            if (SiteListBox.SelectedIndex < 0)
            {
                return;
            }

            if (us.allSegments.Count <= 0)
            {
                return;
            }

            ComputeHashBytes();

            if (addUpperCaseCheckBox.Checked)
            {
                AddUpperCaseLetter(pwdBuilder);
            }
            String pwd = pwdBuilder.ToString();


            if (AddSpecialCharsCheckBox.Checked)
            {
                pwd = AddSpecialChars(pwd);
            }

            // this trimming code should be called after everything else
            if (SetMaxLengthCheckBox.Checked)
            {
                // Math.Min insures we don't overflow bounds of string
                pwd = pwd.Substring(0, Math.Min((int)MaxLengthUpDown.Value, pwd.Length));
            }

            if (showPasswordCheckBox.Checked)
            {
                passwordTextBox.Text = pwd.ToString();
            }
            Clipboard.SetText(pwd.ToString());
        }

        private void AddSiteKeyButton_Click(object sender, EventArgs e)
        {
            string item = string.Empty;
            AddSiteForm asf = new AddSiteForm();
            DialogResult dr = asf.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            SiteListBox.Items.Add(asf.localItem);
            allSites.Add(new SiteKey(asf.localItem));
            allSites.Save();
            SiteListBox.SelectedIndex = SiteListBox.Items.Count - 1;
            asf.Dispose();
        }

        private void remoteFileUrlTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.All) != 0 && e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void groupBox3_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.All) != 0 && e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void unloadFileMenuItem_Click(object sender, EventArgs e)
        {
            remoteFileData = new StringBuilder();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (SiteKey s in allSites)
            {
                SiteListBox.Items.Add(s.Key);
            }
        }

        private void deleteSiteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Delete item?",
                "Are you sure you want to delete the item?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Asterisk,
                MessageBoxDefaultButton.Button2);
            if (DialogResult.Yes == dr)
            {
                allSites.Remove(allSites.Find(s => s.Key == SiteListBox.SelectedItem.ToString()));
                SiteListBox.Items.Remove(SiteListBox.SelectedItem);
                allSites.Save();
                ClearPasswordInfo();
            }
        }

        private void addUpperCaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (us.allSegments.Count > 0 && SiteListBox.SelectedIndex >= 0)
            {
                GeneratePassword();
            }
        }

        private void AddSpecialCharsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (us.allSegments.Count > 0 && SiteListBox.SelectedIndex >= 0)
            {
                GeneratePassword();
            }
        }

        private void SetMaxLengthCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (us.allSegments.Count > 0 && SiteListBox.SelectedIndex >= 0)
            {
                GeneratePassword();
            }
        }

        private void AddSpecialCharsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (us.allSegments.Count > 0 && SiteListBox.SelectedIndex >= 0)
            {
                if (AddSpecialCharsCheckBox.Checked)
                {
                    GeneratePassword();
                }
            }
        }

        private void MaxLengthUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (us.allSegments.Count > 0 && SiteListBox.SelectedIndex >= 0)
            {
                if (SetMaxLengthCheckBox.Checked)
                {
                    GeneratePassword();
                }
            }
        }

        private void SiteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Fixes an odd bug where the control gets focus but no item is actually selected.
            if (SiteListBox.SelectedIndex <= -1) { return; }

            if (us.allSegments.Count > 0)
            {
                GeneratePassword();
            }
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm ab = new CYaPass.AboutForm();
            ab.ShowDialog();
        }
    }
}
