using assignment.Repositories;
using System;
using System.Data;
using System.Windows.Forms;

namespace assignment
{
    // Displays all user accounts in a DataGridView.
    // Uses both the auto-generated TableAdapter for initial load
    // and UserRepository for any additional filtering or stat display.
    public partial class frmViewAllAccounts : Form
    {
        private readonly UserRepository _userRepository;

        public frmViewAllAccounts()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        // ─── Form Load ────────────────────────────────────────────────

        private void view_all_accounts_Load(object sender, EventArgs e)
        {
            LoadAccounts();
        }

        // Loads all accounts into the DataGridView
        // Keeps the TableAdapter fill (auto-generated) but wraps it in a named method
        // so it can be called again after any changes (add/remove/update)
        private void LoadAccounts()
        {
            // Replace TableAdapter with UserRepository (consistent with OOP approach)
            var users = _userRepository.GetAllUsers();

            // Build a clean DataTable to display — hides password column entirely
            DataTable dt = new DataTable();
            dt.Columns.Add("Username");
            dt.Columns.Add("Role");
            dt.Columns.Add("Email");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Gender");

            foreach (var user in users)
            {
                dt.Rows.Add(
                    user.Username,
                    user.Role,
                    user.Email,
                    user.PhoneNumber,
                    user.Gender
                );
            }

            dataGridView1.DataSource = dt;


            // Hide the password column from the grid for security
            // Passwords (even hashed) should never be visible in a UI grid
            if (dataGridView1.Columns["Password"] != null)
                dataGridView1.Columns["Password"].Visible = false;
        }

        // Updates the summary labels at the top of the form
        /*
        private void UpdateStatLabels()
        {
            lblTotalAccounts.Text = "Total accounts: " + _userRepository.GetTotalUserCount();
            lblTotalStaff.Text = "Staff accounts: " + _userRepository.GetStaffCount();
            lblTotalCustomers.Text = "Customer accounts: " + _userRepository.GetCustomerCount();
            lblActiveAccounts.Text = "Active: " + _userRepository.GetActiveUserCount();
            lblInactiveAccounts.Text = "Inactive: " + _userRepository.GetInactiveUserCount();
        }
        */
        // ─── Search / Filter ──────────────────────────────────────────

        // Filters the DataGridView rows by username as the admin types
        // No extra database call needed — filters the already-loaded data in memory
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string username = row.Cells["Username"].Value?.ToString().ToLower() ?? "";
                string role = row.Cells["Role"].Value?.ToString().ToLower() ?? "";

                row.Visible = username.Contains(search) || role.Contains(search);
            }
        }

        // ─── Navigation Buttons ───────────────────────────────────────

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddUser frmAddUser = new frmAddUser();
            frmAddUser.ShowDialog();
            // Reload after returning in case a new user was added
            LoadAccounts();
            this.Show();
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveUser frmRemoveUser = new frmRemoveUser();
            frmRemoveUser.ShowDialog();
            LoadAccounts();
            this.Show();
        }

        private void btnUpdateUserProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateUserProfiles frmUpdateUserProfiles = new frmUpdateUserProfiles();
            frmUpdateUserProfiles.ShowDialog();
            LoadAccounts();
            this.Show();
        }

        private void pictureBoxBackToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ─── Other Events ─────────────────────────────────────────────

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}