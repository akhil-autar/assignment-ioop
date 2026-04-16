using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class frmSystemAdmin : Form
    {
        public frmSystemAdmin()
        {
            InitializeComponent();
            lblTime.Text = ("Login Time: " + DateTime.Now.ToString());
        }

        private void frmSystemAdmin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void menuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
