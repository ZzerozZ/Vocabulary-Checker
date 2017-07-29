using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocabulary
{
    public partial class frmText : Form
    {

        public frmText()
        {
            InitializeComponent();
        }

        int time = frmStart.sec;
        public static int total = 0;

        bool answer = false;

        static int numCorrect = 0, countCorrect = 0;
        string correct1 = "", correct2 = "", correct3 = "", correct4 = "";

        string linkBuild1 = "", linkBuild2 = "", linkBuild3 = "", linkBuild4 = "";

        //static string link = "https://translate.google.com/#en/vi/";
        private void frmText_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStart start = new frmStart();
            start.Show();
            this.Hide();
        }

        private void frmText_Load(object sender, EventArgs e)
        {
            answer = false;
            btnNext.Enabled = false;
            time = frmStart.sec;
            timer1.Start();
            lblTimeLeft.Text = "00:" + time.ToString();
            btnClean_Click(sender, e);

            ///<summary>
            ///Read all data from vocabulary.txt
            /// </summary>
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            appPath += "//vocabulary.txt";

            string[] str = File.ReadAllLines(appPath);

            string[] eng = new string[str.Length];
            string[] vie = new string[str.Length];

            int index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                index = str[i].IndexOf(":");
                eng[i] = str[i].Substring(0, index).Trim();
                vie[i] = str[i].Substring(index + 1, str[i].Length - index - 1).Trim();
            }

            string strToRemove = "", engToRemove = "", vieToRemove = "";


            int textIndex = 0, lanIndex = 0;
            Random rdText = new Random();
            Random rdLan = new Random();


            //Text 1:
            lanIndex = rdLan.Next(0, 1000);
            textIndex = rdText.Next(0, str.Length - 1);
            //lbltext1.Text = (lanIndex%2 == 0) ? eng[textIndex] : vie[textIndex];
            //correct1 = (lanIndex%2 == 0) ? vie[textIndex] : eng[textIndex];
            if(lanIndex%2 == 0)
            {
                lbltext1.Text = linkBuild1 = eng[textIndex];
                correct1 = vie[textIndex];
                
            }
            else
            {
                lbltext1.Text = vie[textIndex];
                correct1 = linkBuild1 = eng[textIndex];
            }
            strToRemove = str[textIndex];
            engToRemove = eng[textIndex];
            vieToRemove = vie[textIndex];

            str = str.Where(val => val != strToRemove).ToArray();
            eng = eng.Where(val => val != engToRemove).ToArray();
            vie = vie.Where(val => val != vieToRemove).ToArray();

            //Text 2:
            lanIndex = rdLan.Next(0, 1000);
            textIndex = rdText.Next(0, str.Length - 1);
            if (lanIndex % 2 == 0)
            {
                lbltext2.Text = linkBuild2 = eng[textIndex];
                correct2 = vie[textIndex];
            }
            else
            {
                lbltext2.Text = vie[textIndex];
                correct2 = linkBuild2 = eng[textIndex];
            }
            strToRemove = str[textIndex];
            engToRemove = eng[textIndex];
            vieToRemove = vie[textIndex];

            str = str.Where(val => val != strToRemove).ToArray();
            eng = eng.Where(val => val != engToRemove).ToArray();
            vie = vie.Where(val => val != vieToRemove).ToArray();

            //Text 3:
            lanIndex = rdLan.Next(0, 1000);
            textIndex = rdText.Next(0, str.Length - 1);
            if (lanIndex % 2 == 0)
            {
                lbltext3.Text = linkBuild3 = eng[textIndex];
                correct3 = vie[textIndex];
            }
            else
            {
                lbltext3.Text = vie[textIndex];
                correct3 = linkBuild3 = eng[textIndex];
            }
            strToRemove = str[textIndex];
            engToRemove = eng[textIndex];
            vieToRemove = vie[textIndex];

            str = str.Where(val => val != strToRemove).ToArray();
            eng = eng.Where(val => val != engToRemove).ToArray();
            vie = vie.Where(val => val != vieToRemove).ToArray();

            //Text 4:
            lanIndex = rdLan.Next(0, 1000);
            textIndex = rdText.Next(0, str.Length - 1);
            if (lanIndex % 2 == 0)
            {
                lbltext4.Text = linkBuild4 = eng[textIndex];
                correct4 = vie[textIndex];
            }
            else
            {
                lbltext4.Text = vie[textIndex];
                correct4 = linkBuild4 = eng[textIndex];
            }
            strToRemove = str[textIndex];
            engToRemove = eng[textIndex];
            vieToRemove = vie[textIndex];

            str = str.Where(val => val != strToRemove).ToArray();
            eng = eng.Where(val => val != engToRemove).ToArray();
            vie = vie.Where(val => val != vieToRemove).ToArray();

        }

        private void btnViewAnswer_Click(object sender, EventArgs e)
        {
            ///<summary>
            ///Read all data from vocabulary.txt
            /// </summary>
            
            numCorrect -= 4;
            countCorrect -= 4;
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            appPath += "//vocabulary.txt";

            string[] str = File.ReadAllLines(appPath);

            string[] eng = new string[str.Length];
            string[] vie = new string[str.Length];

            int index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                index = str[i].IndexOf(":");
                eng[i] = str[i].Substring(0, index).Trim();
                vie[i] = str[i].Substring(index + 1, str[i].Length - index - 1).Trim();
            }


            //Answer 1:
            for(int i = 0; i < eng.Length; i++)
            {
                if(lbltext1.Text == eng[i])
                {
                    txt1.Text = vie[i];
                    break;
                }
            }

            for (int i = 0; i < vie.Length; i++)
            {
                if (lbltext1.Text == vie[i])
                {
                    txt1.Text = eng[i];
                    break;
                }
            }

            //Answer 2:
            for (int i = 0; i < eng.Length; i++)
            {
                if (lbltext2.Text == eng[i])
                {
                    txt2.Text = vie[i];
                    break;
                }
            }

            for (int i = 0; i < vie.Length; i++)
            {
                if (lbltext2.Text == vie[i])
                {
                    txt2.Text = eng[i];
                    break;
                }
            }

            //Answer 3:
            for (int i = 0; i < eng.Length; i++)
            {
                if (lbltext3.Text == eng[i])
                {
                    txt3.Text = vie[i];
                    break;
                }
            }

            for (int i = 0; i < vie.Length; i++)
            {
                if (lbltext3.Text == vie[i])
                {
                    txt3.Text = eng[i];
                    break;
                }
            }

            //Answer 4:
            for (int i = 0; i < eng.Length; i++)
            {
                if (lbltext4.Text == eng[i])
                {
                    txt4.Text = vie[i];
                    break;
                }
            }

            for (int i = 0; i < vie.Length; i++)
            {
                if (lbltext4.Text == vie[i])
                {
                    txt4.Text = eng[i];
                    break;
                }
            }
        }

        private void btnTranslateWord1_Click(object sender, EventArgs e)
        {
            string str = "https://" + "translate.google.com/#en/vi/" + linkBuild1;
            Process.Start(str);
        }

        private void btnTranslateWord2_Click(object sender, EventArgs e)
        {
            string str = "https://" + "translate.google.com/#en/vi/" + linkBuild2;
            Process.Start(str);
        }

        private void btnTranslateWord3_Click(object sender, EventArgs e)
        {
            string str = "https://" + "translate.google.com/#en/vi/" + linkBuild3;
            Process.Start(str);
        }

        private void btnTranslateWord4_Click(object sender, EventArgs e)
        {
            string str = "https://" + "translate.google.com/#en/vi/" + linkBuild4;
            Process.Start(str);
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter && !answer)
            {
                btnCheck_Click(sender, e);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnCheck.Enabled = true; 
            //Continue:
            frmText_Load(sender, e);

            txt1.Focus();
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !answer)
            {
                btnCheck_Click(sender, e);
            }
        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !answer)
            {
                btnCheck_Click(sender, e);
            }
        }

        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !answer)
            {
                btnCheck_Click(sender, e);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txt1.Text = txt2.Text = txt3.Text = txt4.Text = "";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            answer = true;
            
            if (correct1.IndexOf(txt1.Text.ToString().Trim()) >= 0 && correct1.Length < txt1.Text.Trim().Length * 1.5) { countCorrect++; numCorrect++; }
            if (correct2.IndexOf(txt2.Text.ToString().Trim()) >= 0 && correct2.Length < txt2.Text.Trim().Length * 1.5) { countCorrect++; numCorrect++; }
            if (correct3.IndexOf(txt3.Text.ToString().Trim()) >= 0 && correct3.Length < txt3.Text.Trim().Length * 1.5) { countCorrect++; numCorrect++; }
            if (correct4.IndexOf(txt4.Text.ToString().Trim()) >= 0 && correct4.Length < txt4.Text.Trim().Length * 1.5) { countCorrect++; numCorrect++; }


            ///<summary>
            ///Show correct answer
            /// </summary>
            txt1.Text = "[" + correct1 + "] " + txt1.Text;
            txt2.Text = "[" + correct2 + "] " + txt2.Text;
            txt3.Text = "[" + correct3 + "] " + txt3.Text;
            txt4.Text = "[" + correct4 + "] " + txt4.Text;

            MessageBox.Show("You do the right " + countCorrect + "/4(" +numCorrect.ToString() + "/" + 4 * total + " at all) sentences");

            total++;
            countCorrect = 0;

            btnCheck.Enabled = false;
           
            btnNext.Enabled = true;

            btnNext.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            lblTimeLeft.Text = "00:" + ((time > 9) ? time.ToString() : ("0" + time.ToString()));

            if (time == 0)
            {
                btnCheck_Click(sender, e);
            }

        }
    }
}
