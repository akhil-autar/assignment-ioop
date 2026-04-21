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
    public partial class frmUpdateOwnProfile : Form
    {
        public frmUpdateOwnProfile()
        {
            InitializeComponent();
        }

        private void pictureBoxBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSystemAdmin frmSystemAdmin = new frmSystemAdmin();
            frmSystemAdmin.Show();
        }
    }
}
