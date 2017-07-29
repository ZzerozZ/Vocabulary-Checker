using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocabulary
{
    public partial class frminfo : Form
    {
        public frminfo()
        {
            InitializeComponent();
        }

        private void frminfo_Load(object sender, EventArgs e)
        {
            rtbInfo.Text = frmStart.Str.ToString();
        }

        private void frminfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            rtbInfo.Text = "";
            frmStart frm = new frmStart();
            this.Hide();
            frm.Show();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We will update this function at next program version", "Function unavailable now", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //frmSort frm = new frmSort();
            //this.Hide();
            //frm.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            frmStart frm = new frmStart();
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We will update this function at next program version", "Function unavailable now", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
