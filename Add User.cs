using System;
using System.Drawing;
using System.Windows.Forms;
using assignment.Helpers;
using assignment.Models;
using assignment.Repositories;

namespace assignment
{
    // The form is only responsible for UI interaction.
    // All logic is delegated to UserRepository, Validator, and PasswordHelper (Separation of Concerns)
    public partial class frmAddUser : Form
    {
        // Dependencies injected via constructor (Dependency principle)
        private readonly UserRepository _userRepository;
        private readonly string _connectionString = "Data Source=localhost;Initial Catalog=GR8Food;Integrated Security=True;TrustServerCertificate=True";

        public frmAddUser()
        {
            InitializeComponent();
            _userRepository = new UserRepository(_connectionString);
            btnAddUser.Enabled = false;
        }

        // ─── Navigation ───────────────────────────────────────────────

        private void pictureBoxBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSystemAdmin frmSystemAdmin = new frmSystemAdmin();
            frmSystemAdmin.ShowDialog();
            this.Close();
        }

        // ─── Add User Button ──────────────────────────────────────────

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Build a User object from the form fields (using the User model class)
            User newUser = new User(
                username: txtUsername.Text.Trim(),
                password: txtPassword.Text.Trim(),
                role: comboBox1.SelectedItem.ToString(),
                email: txtEmail.Text.Trim(),
                phoneNumber: txtPhoneNumber.Text.Trim(),
                gender: radioButtonMale.Checked ? "Male" : "Female"
            );

            // Delegate the database operation to UserRepository (not the form's responsibility)
            bool success = _userRepository.AddUser(newUser);

            if (success)
            {
                MessageBox.Show($"User '{newUser.Username}' added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to add user. Please try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Form Validation ──────────────────────────────────────────

        // Central validation method — enables the Add button only when all fields are valid.
        // Called on every field change event below.
        private void ValidateForm()
        {
            string error;

            bool usernameOk = Validator.ValidateUsernameExists(txtUsername.Text.Trim(), _connectionString, out error);
            bool emailOk = Validator.ValidateEmail(txtEmail.Text.Trim(), out error);
            bool passwordOk = Validator.ValidatePassword(txtPassword.Text.Trim(), out error);
            bool phoneOk = Validator.ValidatePhone(txtPhoneNumber.Text.Trim(), out error);
            bool confirmOk = txtConfirmPassword.Text.Trim() == txtPassword.Text.Trim()
                                   && !string.IsNullOrEmpty(txtConfirmPassword.Text.Trim());
            bool roleOk = comboBox1.SelectedIndex != -1;
            bool genderOk = radioButtonMale.Checked || radioButtonFemale.Checked;

            btnAddUser.Enabled = usernameOk && emailOk && passwordOk && phoneOk && confirmOk && roleOk && genderOk;
        }

        // ─── Helper Methods ───────────────────────────────────────────

        // Resets all fields back to empty after a successful add
        private void ClearForm()
        {
            txtUsername.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            comboBox1.SelectedIndex = -1;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            lblPasswordStrength.Text = "";
            lblErrorUsername.Text = "";
            lblErrorEmail.Text = "";
            lblErrorPhone.Text = "";
            lblError3.Text = "";
            btnAddUser.Enabled = false;
        }

        // ─── Field Change Events ──────────────────────────────────────

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
            lblErrorUsername.Text = Validator.ValidateUsernameExists(txtUsername.Text.Trim(), _connectionString, out string err)
                ? "" : err;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
            lblErrorEmail.Text = Validator.ValidateEmail(txtEmail.Text.Trim(), out string err) ? "" : err;
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
            lblErrorPhone.Text = Validator.ValidatePhone(txtPhoneNumber.Text.Trim(), out string err) ? "" : err;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();

            // Show password strength using PasswordHelper (delegating logic to the helper class)
            string strength = PasswordHelper.GetStrength(txtPassword.Text.Trim());
            lblPasswordStrength.Text = string.IsNullOrEmpty(strength) ? "" : $"Strength: {strength}";
            if (strength == "Weak") lblPasswordStrength.ForeColor = Color.Red;
            else if (strength == "Fair") lblPasswordStrength.ForeColor = Color.Orange;
            else if (strength == "Good") lblPasswordStrength.ForeColor = Color.DodgerBlue;
            else if (strength == "Strong") lblPasswordStrength.ForeColor = Color.Green;
            else lblPasswordStrength.ForeColor = Color.Gray;

            // Re-validate confirm password if it already has a value
            if (!string.IsNullOrEmpty(txtConfirmPassword.Text))
                txtConfirmPassword_TextChanged(sender, e);
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
            lblError3.Text = txtConfirmPassword.Text.Trim() == txtPassword.Text.Trim()
                ? "" : "Passwords do not match.";
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e) => ValidateForm();
        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e) => ValidateForm();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) => ValidateForm();

        private void btnClear_Click(object sender, EventArgs e) => ClearForm();
    }
}