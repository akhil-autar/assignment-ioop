using System;
using System.Windows.Forms;
using assignment.Helpers;
using assignment.Repositories;

namespace assignment
{
    // The dashboard form is only responsible for displaying data and navigating to other forms.
    // All data retrieval is delegated to UserRepository (Separation of Concerns)
    public partial class frmSystemAdmin : Form
    {
        private readonly UserRepository _userRepository;

        public frmSystemAdmin()
        {
            InitializeComponent();
            _userRepository = new UserRepository();

            LoadDashboard();
        }

        // ─── Dashboard Load ───────────────────────────────────────────

        // Loads all dashboard data in one place — easy to maintain and extend
        private void LoadDashboard()
        {
            ShowWelcomeMessage();
            ShowLoginTime();
            LoadStatCards();
        }

        // Uses SessionManager to greet the logged-in admin by name
        private void ShowWelcomeMessage()
        {
            if (SessionManager.IsLoggedIn())
            {
                lblWelcome.Text = $"Welcome, {SessionManager.CurrentUser.Username}";
            }
        }

        private void ShowLoginTime()
        {
            lblTime.Text = "Login time: " + DateTime.Now.ToString("dd MMM yyyy, hh:mm tt");
        }

        // Loads all stat card values using UserRepository methods
        // The form does not write any SQL — that is the repository's job (Abstraction)
        private void LoadStatCards()
        {
            lblTotalNumberofUsers.Text = "Total staff accounts: " + _userRepository.GetStaffCount();
            lblNumberofCustomers.Text = "Total customer accounts: " + _userRepository.GetCustomerCount();
            lblTotalActiveUsers.Text = "Active accounts: " + _userRepository.GetActiveUserCount();
            lblTotalInactiveUsers.Text = "Inactive accounts: " + _userRepository.GetInactiveUserCount();
        }

        private void frmSystemAdmin_Load(object sender, EventArgs e)
        {

        }

        // ─── Navigation Buttons ───────────────────────────────────────

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddUser frmAddUser = new frmAddUser();
            frmAddUser.ShowDialog();
            // Reload stat cards when returning — user count may have changed
            LoadStatCards();
            this.Show();
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveUser frmRemoveUser = new frmRemoveUser();
            frmRemoveUser.ShowDialog();
            LoadStatCards();
            this.Show();
        }

        private void btnUpdateUserProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateUserProfiles frmUpdateUserProfiles = new frmUpdateUserProfiles();
            frmUpdateUserProfiles.ShowDialog();
            this.Show();
        }

        private void btnViewAllAccounts_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewAllAccounts frmViewAllAccounts = new frmViewAllAccounts();
            frmViewAllAccounts.ShowDialog();
            this.Show();
        }

        // ─── Menu Strip ───────────────────────────────────────────────

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (response == DialogResult.Yes)
            {
                // Clear the session on logout
                SessionManager.Logout();
                this.Hide();
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
                this.Close();
            }
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (response == DialogResult.Yes)
                this.Close();
        }

        private void menuUpdateProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateOwnProfile frmUpdateOwnProfiles = new frmUpdateOwnProfile();
            frmUpdateOwnProfiles.ShowDialog();
            this.Show();
        }

        private void menuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnViewSalesReport_Click(object sender, EventArgs e)
        {
            frmSalesReport frmSalesReport = new frmSalesReport();
            frmSalesReport.ShowDialog();
            this.Close();
        }
    }
}