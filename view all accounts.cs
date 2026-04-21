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
    public partial class frmViewAllAccounts : Form
    {
        public frmViewAllAccounts()
        {
            InitializeComponent();
        }

        private void pictureBoxBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSystemAdmin frmSystemAdmin = new frmSystemAdmin();
            frmSystemAdmin.ShowDialog();
        }

        private void view_all_accounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gR8FoodDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.gR8FoodDataSet.Users);

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddUser frmAddUser = new frmAddUser();
            frmAddUser.ShowDialog();
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveUser frmRemoveUser = new frmRemoveUser();
            frmRemoveUser.ShowDialog();
        }

        private void btnUpdateUserProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateUserProfiles frmUpdateUserProfiles = new frmUpdateUserProfiles();
            frmUpdateUserProfiles.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
