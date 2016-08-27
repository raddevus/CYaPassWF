using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DragPass
{
    public partial class MainForm : Form
    {
        private byte[] saltBytes;
        private Point previousPoint = new Point();
        private int postWidth = 10;
        private int centerPoint = 50;
        private List<Point> allPosts;
        private List<Point> userShape = new List<Point>();
        private int offset = 5;
        private Point MouseLoc = new Point();
        private LineSegments LineSegments = new LineSegments();
        private StringBuilder pwdBuilder;
        private StringBuilder remoteFileData;
        private SiteKeys allSites = new SiteKeys();


        public MainForm()
        {
            InitializeComponent();
            passwordGroupBox.AllowDrop = true;
            passwordGroupBox.DragEnter += new DragEventHandler(MainForm_DragEnter);
            passwordGroupBox.DragDrop += new DragEventHandler(MainForm_DragDrop);

            SaltGroupBox.AllowDrop = true;
            SaltGroupBox.DragEnter += new DragEventHandler(SaltGroupBox_DragEnter);
            SaltGroupBox.DragDrop += new DragEventHandler(SaltGroupBox_DragDrop);
            groupBox3.AllowDrop = true;
            GenerateAllPosts();
            LoadAllSites();
        }


        void LoadAllSites()
        {
            if (File.Exists(allSites.fileName))
            {
                String allJson = File.ReadAllText(allSites.fileName);
                allSites = (SiteKeys)JsonConvert.DeserializeObject(allJson, allSites.GetType());
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
                SaltIsSetCheckBox.Checked = true;
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
                if (SaltIsSetCheckBox.Checked) {
                    allBytes = new byte[fileBytes.Length + saltBytes.Length];
                    fileBytes.CopyTo(allBytes, 0);
                    saltBytes.CopyTo(allBytes, fileBytes.Length - 1);
                }
                else
                {
                    allBytes = fileBytes;
                }
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

        private void clearSaltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saltBytes = null;
            SaltIsSetCheckBox.Checked = false;
        }

        private void GridPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawGridLines(g);
            DrawPosts(g);
            DrawUserShape(g);
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

        private void DrawUserShapeOrig()
        {
            previousPoint = new Point();
            foreach (Point Pt in userShape)
            {
                DrawLine(Pt.X, Pt.Y);
                previousPoint = Pt;
            }
        }

        private void DrawUserShape(Graphics g)
        {
            //Graphics g = GridPictureBox.CreateGraphics();
            Pen p = new Pen(Color.Green);
            p.Width = 5;
            foreach (LineSegment l in LineSegments)
            {
                g.DrawLine(p, l.Start.X + offset, l.Start.Y + offset, l.End.X + offset, l.End.Y + offset);
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

        private Point HitTest(Point p)
        {
            foreach (Point Pt in allPosts)
            {
                if ((p.X >= (Pt.X + offset) - postWidth) && (p.X <= (Pt.X + offset) + postWidth))
                {
                    if ((p.Y >= (Pt.Y + offset) - postWidth) && (p.Y <= (Pt.Y + offset) + postWidth))
                    {
                        return Pt;
                    }
                }
            }

            return new Point();
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

        private bool IsNewPoint(Point currentPoint)
        {
            if (userShape.Count > 0)
            {
                if (userShape.Count > 1)
                {
                    if (!((currentPoint.X == userShape[userShape.Count - 1].X && currentPoint.Y == userShape[userShape.Count - 1].Y)
                        || (currentPoint.X == userShape[userShape.Count - 2].X || currentPoint.Y == userShape[userShape.Count - 2].Y)))
                    {
                        return true;
                    }
                }
                if (!(currentPoint.X == userShape[userShape.Count - 1].X && currentPoint.Y == userShape[userShape.Count - 1].Y))
                {
                    return true;
                }
            }
            else { return true; }
            return false;
        }

        private bool IsNewLineSegment(LineSegment l)
        {
            LineSegment duplicate = LineSegments.Find(ls => (ls.Start.X == l.Start.X && ls.Start.Y == l.Start.Y) && (ls.End.X == l.End.X && ls.End.Y == l.End.Y) || (ls.End.X == l.Start.X && ls.End.Y == l.Start.Y) && (ls.Start.X == l.End.X && ls.Start.Y == l.End.Y));
            if (duplicate == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SelectNewPoint()
        {
            Point currentPoint = HitTest(new Point(MouseLoc.X, MouseLoc.Y));
            if (!currentPoint.IsEmpty)
            {
                DrawLine(currentPoint.X, currentPoint.Y);
                if (!currentPoint.IsEmpty && IsNewPoint(currentPoint))
                {
                    if (userShape.Count > 0)
                    {
                        if (IsNewLineSegment(new LineSegment(userShape[userShape.Count - 1], currentPoint))) // never allow a duplicate line segment in the list
                        {
                            LineSegments.Add(new LineSegment(userShape[userShape.Count - 1], currentPoint));
                        }
                    }
                    userShape.Add(currentPoint);
                    DrawHighlight();
                    if (SiteListBox.SelectedItems.Count > 0 && userShape.Count > 1)
                    {
                        GenPassword();
                    }  
                }

                previousPoint = currentPoint;
            }
        }

        private void DrawHighlight()
        {
            Graphics g = GridPictureBox.CreateGraphics();
            Pen p = new Pen(Color.Orange);
            p.Width = 2;
            
            g.DrawArc(p, userShape[0].X - offset, userShape[0].Y - offset,  postWidth+10,postWidth+10, 0f, (float)(360));
        }

        private void GridPictureBox_Click(object sender, EventArgs e)
        {
            SelectNewPoint();
        }

        private void GridPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                LineSegments.Clear();
                GridPictureBox.Invalidate();
                return;
            }

            MouseLoc = new Point(e.X, e.Y);
        }

        private void CalculateGeometricSaltValue()
        {
            LineSegments.PostPoints = String.Empty;
            LineSegments.PostValue = 0;

            foreach (LineSegment l in LineSegments)
            {
                for (int x = 0; x < allPosts.Count; x++)
                {
                    if (l.Start.X == allPosts[x].X && l.Start.Y == allPosts[x].Y)
                    {
                        System.Diagnostics.Debug.Print(string.Format("START x : {0}", x));
                        LineSegments.AddOn(x);
                    }
                    if (l.End.X == allPosts[x].X && l.End.Y == allPosts[x].Y)
                    {
                        System.Diagnostics.Debug.Print(string.Format("END x : {0}", x));
                        LineSegments.AddOn(x);
                    }
                }
            }
            System.Diagnostics.Debug.Print(String.Format("Value : {0}",LineSegments.PostValue));
            System.Diagnostics.Debug.Print(LineSegments.PostPoints);
        }

        private void MainForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //DrawUserShape();
            CalculateGeometricSaltValue();
        }

        private void ClearGridButton_Click(object sender, EventArgs e)
        {
            LineSegments.Clear();
            previousPoint = new Point();
            userShape = new List<Point>();
            GridPictureBox.Invalidate();
            Graphics g = GridPictureBox.CreateGraphics();
            DrawGridLines(g);
            DrawPosts(g);
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
            var patternBytes = System.Text.Encoding.UTF8.GetBytes(LineSegments.PostValue.ToString());
            var selItemText = SiteListBox.SelectedItem.ToString();
            var siteBytes = System.Text.Encoding.UTF8.GetBytes(selItemText);
            byte[] allBytes = null;
            if (SaltIsSetCheckBox.Checked)
            {
                allBytes = new byte[patternBytes.Length + siteBytes.Length + saltBytes.Length];
                patternBytes.CopyTo(allBytes, 0);
                siteBytes.CopyTo(allBytes, patternBytes.Length);
                saltBytes.CopyTo(allBytes, patternBytes.Length + siteBytes.Length);
            }
            else {
                allBytes = new byte[patternBytes.Length + siteBytes.Length];
                patternBytes.CopyTo(allBytes, 0);
                siteBytes.CopyTo(allBytes, patternBytes.Length);
            }

            if (remoteFileUrlTextBox.Text != string.Empty && remoteFileData.Length > 0)
            {
                if (remoteFileData.Length > 0)
                {
                    var remoteBytes = System.Text.Encoding.UTF8.GetBytes(remoteFileData.ToString());
                    byte [] tempBuffer = new byte[allBytes.Length + remoteBytes.Length];
                    allBytes.CopyTo(tempBuffer, 0);
                    remoteBytes.CopyTo(tempBuffer, allBytes.Length);
                    allBytes = tempBuffer;
                }
            }

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

        private void RetrieveRemoteFile()
        {
            string strUri = remoteFileUrlTextBox.Text;
            remoteFileData = new StringBuilder();
            if (strUri.Length == 0)
                return;

            // Call helper method to insure that the URL
            // is valid -- check it starts with http:// or https://
            strUri = CheckForUrlPrefix(strUri);

            //urlComboBox.Text = strUri;

            System.Net.WebRequest webreq;
            System.Net.WebResponse webres;
            try
            {
                // The WebRequest.Create method is a factory : you send
                // in a URL and it creates a webreq obj.
                webreq = System.Net.WebRequest.Create(strUri);
                // call the GetResponse() method to get the bytes
                // that the server is sending for the resource
                webres = webreq.GetResponse();
            }
            catch (Exception exc)
            {
                // If we get any error, just throw
                // the error message into the main content area. 
                MessageBox.Show(exc.Message);
                return;
            }
            // Generate a stream object we can get the bytes from
            Stream stream = webres.GetResponseStream();

            // This allows us to read the stream one line at a time.
            // There are probably better ways, but this is just easy.
            StreamReader strrdr = new StreamReader(stream);
            string strLine;
            int line = 1;

            // check to see if we're at the end of the stream
            while ((strLine = strrdr.ReadLine()) != null )
            {
                // read a line and append a NewLine for multi-line text output.
                remoteFileData.Append(string.Format("{0}{1}", strLine, Environment.NewLine));
                // increment the line counter
                ++line;
            }
        }

        private void GenPassword()
        {
            CalculateGeometricSaltValue();
            if (SiteListBox.SelectedIndex < 0)
            {
                MessageBox.Show("You must select a Site/Key item to generate a password.");

                return;

            }
            if (LineSegments.PostValue == 0)
            {
                MessageBox.Show("You must create a pattern to generate a password.");
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
        private void GenPasswordButton_Click(object sender, EventArgs e)
        {
            GenPassword();
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
            //asf = null;
            asf.Dispose();
        }

        private void handleUrlDrop(DragEventArgs e)
        {
            //var itemText = e.Data.GetData(DataFormats.Text);
            string stringData = e.Data.GetData(typeof(string)) as string;
            remoteFileUrlTextBox.Text = stringData;
            RetrieveRemoteFile();

        }

        private void remoteFileUrlTextBox_DragDrop(object sender, DragEventArgs e)
        {
            handleUrlDrop(e);

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

        private void groupBox3_DragDrop(object sender, DragEventArgs e)
        {
            handleUrlDrop(e);
        }

        private void reloadFileMenuItem_Click(object sender, EventArgs e)
        {
            RetrieveRemoteFile();
        }

        private void unloadFileMenuItem_Click(object sender, EventArgs e)
        {
            remoteFileData = new StringBuilder();
        }

        private void DeleteTextMenuItem_Click(object sender, EventArgs e)
        {
            remoteFileUrlTextBox.Text = String.Empty;
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
            }
        }

        private void addUpperCaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (userShape.Count > 0 && SiteListBox.SelectedIndex >= 0)
            {
                GenPassword();
            }
        }

        private void AddSpecialCharsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (userShape.Count > 0 && SiteListBox.SelectedIndex >= 0)
            {
                GenPassword();
            }
        }

        private void SetMaxLengthCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (userShape.Count > 0 && SiteListBox.SelectedIndex >= 0)
            {
                GenPassword();
            }
        }

        private void AddSpecialCharsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (userShape.Count > 0 && SiteListBox.SelectedIndex >= 0)
            {
                if (AddSpecialCharsCheckBox.Checked)
                {
                    GenPassword();
                }
            }
        }

        private void MaxLengthUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (userShape.Count > 0 && SiteListBox.SelectedIndex >= 0)
            {
                if (SetMaxLengthCheckBox.Checked)
                {
                    GenPassword();
                }
            }
        }

        private void SiteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userShape.Count > 0)
            {
                GenPassword();
            }
        }
    }
}
