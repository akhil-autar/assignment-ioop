using System;
using System.Data;
using System.Windows.Forms;
using assignment.Helpers;
using assignment.Repositories;

namespace assignment
{
    // This form is only responsible for UI interaction.
    // All database operations are delegated to UserRepository (Separation of Concerns)
    public partial class frmRemoveUser : Form
    {
        // ─── Dependencies ─────────────────────────────────────────────
        private readonly string _connectionString = "Data Source=localhost;Initial Catalog=GR8Food;Integrated Security=True;TrustServerCertificate=True";
        private readonly UserRepository _userRepository;

        public frmRemoveUser()
        {
            InitializeComponent();
            _userRepository = new UserRepository(_connectionString);
        }

        // ─── Find User ────────────────────────────────────────────────

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            ClearErrors();
            string username = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                lblError.Text = "*Field cannot be empty.";
                return;
            }

            // Delegate the search to UserRepository — no SQL in the form
            var user = _userRepository.GetUserByUsername(username);

            if (user != null)
            {
                // Display results in DataGridView by building a DataTable from the User object
                // This avoids exposing raw database columns directly to the UI
                DataTable dt = new DataTable();
                dt.Columns.Add("Username");
                dt.Columns.Add("Role");
                dt.Columns.Add("Email");
                dt.Columns.Add("Phone");
                dt.Columns.Add("Gender");
                dt.Columns.Add("Status");

                dt.Rows.Add(
                    user.Username,
                    user.Role,
                    user.Email,
                    user.PhoneNumber,
                    user.Gender,
                    user.IsActive ? "Active" : "Inactive"
                );

                dataGridView1.DataSource = dt;
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "User not found.";
                dataGridView1.DataSource = null;
            }
        }

        // ─── Delete User ──────────────────────────────────────────────

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            ClearErrors();

            // Check confirm checkbox first
            if (!chkConfirmDelete.Checked)
            {
                lblError2.Text = "*Please confirm deletion by checking the box.";
                return;
            }

            string username = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                lblError.Text = "*Field cannot be empty.";
                return;
            }

            // Retrieve the user to get their Id for deletion
            // We delete by Id rather than username for safety — Id is unique and cannot be spoofed
            var user = _userRepository.GetUserByUsername(username);

            if (user == null)
            {
                lblError.Text = "User not found.";
                return;
            }

            // Prevent admin from deleting their own account
            if (SessionManager.IsLoggedIn() && user.Username == SessionManager.CurrentUser.Username)
            {
                lblError.Text = "You cannot delete your own account.";
                return;
            }

            // Final confirmation dialog before permanent deletion
            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to permanently delete '{user.Username}'?\nThis action cannot be undone.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            // Delegate the deletion to UserRepository
            bool success = _userRepository.DeleteUser(user.Id);

            if (success)
            {
                MessageBox.Show($"User '{user.Username}' deleted successfully.",
                    "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            else
            {
                lblError.Text = "Could not delete user. Please try again.";
            }
        }

        // ─── Helper Methods ───────────────────────────────────────────

        // Resets the entire form back to its default state
        private void ResetForm()
        {
            txtUsername.Clear();
            dataGridView1.DataSource = null;
            chkConfirmDelete.Checked = false;
            ClearErrors();
        }

        private void ClearErrors()
        {
            lblError.Text = "";
            lblError2.Text = "";
        }

        // ─── Navigation ───────────────────────────────────────────────

        private void pictureBoxBackToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ─── Other Events ─────────────────────────────────────────────

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // Clear errors and reset grid when user starts typing a new search
            ClearErrors();
            if (string.IsNullOrEmpty(txtUsername.Text))
                dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Remove_User_Load(object sender, EventArgs e)
        {

        }
    }
}