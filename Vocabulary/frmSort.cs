using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocabulary
{
    public partial class frmSort : Form
    {
        public frmSort()
        {
            InitializeComponent();
        }

        private void frmSort_Load(object sender, EventArgs e)
        {
            cmbSortBy.SelectedIndex = 0;
        }

        private void frmSort_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStart frm = new frmStart();
            this.Hide();
            frm.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            #region getData

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

            #endregion //Get data

            #region Slove

            string[] Str = new string[str.Length];

            switch (cmbSortBy.SelectedIndex)
            {
                case 0: //ENG A-> Z
                    for (int i = 0; i < eng.Length; i++)
                    {
                        for (int j = i + 1; j < eng.Length; j++)
                        {
                            if (eng[i].CompareTo(eng[j]) > 0)
                            {
                                Swap(eng[i], eng[j]);
                                Swap(vie[i], vie[j]);
                            }
                        }
                    }

                    //Write data to temp memory:
                    for (int i = 0; i < str.Length; i++)
                    {
                        Str[i] = eng[i];
                        Str[i] += " : ";
                        Str[i] += vie[i];
                    }
                    break;
                case 1: //VIE A->Z
                    for (int i = 0; i < vie.Length; i++)
                    {
                        for (int j = i + 1; j < vie.Length; j++)
                        {
                            if (vie[i].CompareTo(vie[j]) > 0)
                            {
                                Swap(eng[i], eng[j]);
                                Swap(vie[i], vie[j]);
                            }
                        }
                    }

                    //Write data to temp memory:
                    for (int i = 0; i < str.Length; i++)
                    {
                        Str[i] = vie[i];
                        Str[i] += " : ";
                        Str[i] += eng[i];
                    }
                    break;
                case 2: //ENG Z -> A
                    for (int i = 0; i < eng.Length; i++)
                    {
                        for (int j = i + 1; j < eng.Length; j++)
                        {
                            if (eng[i].CompareTo(eng[j]) < 0)
                            {
                                Swap(eng[i], eng[j]);
                                Swap(vie[i], vie[j]);
                            }
                        }
                    }
                    //Write data to temp memory:
                    for (int i = 0; i < str.Length; i++)
                    {
                        Str[i] = eng[i];
                        Str[i] += " : ";
                        Str[i] += vie[i];
                    }
                    break;
                case 3: //VIE Z -> A
                    for (int i = 0; i < vie.Length; i++)
                    {
                        for (int j = i + 1; j < vie.Length; j++)
                        {
                            if (vie[i].CompareTo(vie[j]) < 0)
                            {
                                Swap(eng[i], eng[j]);
                                Swap(vie[i], vie[j]);
                            }
                        }
                    }

                    //Write data to temp memory:
                    for (int i = 0; i < str.Length; i++)
                    {
                        Str[i] = vie[i];
                        Str[i] += " : ";
                        Str[i] += eng[i];
                    }
                    break;
            }

            #endregion //Slove

            #region Update file

            using (StreamWriter sw = new StreamWriter("vocabulary.txt"))
            {
                foreach (string s in Str)
                {
                    sw.WriteLine(s);
                }
            }

            #endregion //Update file

        }

        private void Swap(ref string v1, ref string v2)
        {
            string v = v1;
            v1 = v2;
            v2 = v;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frminfo frm = new frminfo();
            this.Hide();
            frm.Show();
        }
    }
}
