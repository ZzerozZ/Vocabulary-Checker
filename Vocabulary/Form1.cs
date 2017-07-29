using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocabulary
{
    public partial class frmStart : Form
    {

        public static StringBuilder Str = new StringBuilder();
        public static int sec = 0;

        public frmStart()
        {
            InitializeComponent();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            appPath += "//vocabulary.txt";

            string[] str = File.ReadAllLines(appPath);

            string[] eng = new string[str.Length];
            string[] vie = new string[str.Length];

            int index = 0;
            for(int i = 0; i < str.Length; i++)
            {
                index = str[i].IndexOf(":");
                eng[i] = str[i].Substring(0, index).Trim();
                vie[i] = str[i].Substring(index + 1, str[i].Length - index - 1).Trim();
            }

           

            for (int i = 0; i < str.Length; i++)
            {
                Str.Append(eng[i]);
                Str.Append(" : ");
                Str.Append(vie[i]);
                Str.Append("\n\n");
            }

            frminfo inf = new frminfo();
            this.Hide();
            inf.Show();
          //  MessageBox.Show(Str.ToString(), "All word");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            appPath += "//vocabulary.txt";

            Process.Start(appPath);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmText.total++;
            frmText test = new frmText();
            test.Show();
            this.Hide();
            //this.Enabled = false;
        }

        private void frmStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            cmbTimePerWord.SelectedIndex = 2;
            btnStart.Focus();
        }

        private void cmbTimePerWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            sec = 4 * int.Parse(cmbTimePerWord.SelectedItem.ToString());
        }

        private void llbAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.llbAuthor.LinkVisited = true;
            Process.Start("http://fb.com/zzerodev");
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            frmSort frm = new frmSort();
            this.Hide();
            frm.Show();
        }
    }
}
