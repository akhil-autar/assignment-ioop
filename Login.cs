using System;
using System.Windows.Forms;
using assignment.Helpers;
using assignment.Models;
using assignment.Repositories;
using CHEF;
using Gr8FoodSystem_Final;
using prac;

namespace assignment
{
    public partial class frmLogin : Form
    {
        private readonly UserRepository _userRepository;

        // ─── State ────────────────────────────────────────────────────
        private int _attemptsRemaining = 3;

        public frmLogin()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        // ─── Show/Hide Password ───────────────────────────────────────

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        // ─── Login Button ─────────────────────────────────────────────
        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Basic empty field check
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblError.Text = "Please enter your username and password.";
                return;
            }

            // Retrieve user from database via UserRepository
            // The form does not write any SQL — that is the repository's job (Separation of Concerns)
            User user = _userRepository.GetUserByUsername(username);

            // Check if user exists
            if (user == null)
            {
                MessageBox.Show("User does not exist.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if account has been disabled by admin
            if (!user.IsActive)
            {
                MessageBox.Show(
                    "Your account has been disabled.\nPlease contact the system administrator.",
                    "Account Disabled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Verify password using PasswordHelper
            // PasswordHelper hashes the entered password and compares it to the stored hash
            // Passwords are never stored or compared as plain text (Security best practice)
            if (PasswordHelper.VerifyPassword(password, user.Password))
            {
                // Store the logged-in user globally using SessionManager
                // This allows all other forms to access the current user without passing it manually
                SessionManager.Login(user);

                MessageBox.Show($"Welcome, {user.Username}!", "Login Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                OpenRoleForm(user.Role);
            }
            else
            {
                HandleFailedAttempt();
            }
        }

        // ─── Role Routing ─────────────────────────────────────────────

        // Directs the user to the correct dashboard based on their role
        // Uses a switch statement so adding new roles only requires one new case here
        private void OpenRoleForm(string role)
        {
            Form nextForm;

            switch (role)
            {
                case "System Admin":
                    nextForm = new frmSystemAdmin();
                    break;
                
                case "Customer":
                    nextForm = new Form1();
                    break;
                case "Manager":
                    nextForm = new Managerdashboard();
                    break;
                case "Chef":
                    nextForm = new Chef_Dashboard();
                    break;
                
                    /*
            case "Cashier":
                nextForm = new frmCashier();
                break;
            case "Kitchen Staff":
                nextForm = new frmKitchen();
                break;
                */
                default:
                    MessageBox.Show($"No dashboard found for role: {role}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Show();
                    return;
            }

            nextForm.ShowDialog();
            this.Close();
        }

        // ─── Failed Login Handler ─────────────────────────────────────

        // Handles decrementing attempts and locking the form after 3 failures
        private void HandleFailedAttempt()
        {
            _attemptsRemaining--;

            if (_attemptsRemaining <= 0)
            {
                lblError.Text = "Account locked. Too many failed attempts.";
                btnLogin.Enabled = false;
                MessageBox.Show(
                    "You have exceeded the maximum number of login attempts.\nPlease contact the system administrator.",
                    "Account Locked",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                lblError.Text = $"Incorrect password. {_attemptsRemaining} attempt(s) remaining.";
            }
        }

        // ─── Menu Strip ───────────────────────────────────────────────

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult userResponse = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (userResponse == DialogResult.Yes)
                this.Close();
        }

        // ─── Back to Entrance ─────────────────────────────────────────

        private void lblRegisterNewAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEntrance frmEntrance = new frmEntrance();
            frmEntrance.ShowDialog();
            this.Close();
        }
    }
}