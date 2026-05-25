using System;
using System.Drawing;
using System.Windows.Forms;
using assignment.Helpers;
using assignment.Models;
using assignment.Repositories;

namespace assignment
{
    // Customer self-registration form.
    // Role is hardcoded to "Customer" — customers cannot choose their own role.
    // All database operations delegated to UserRepository (Separation of Concerns)
    public partial class frmEntrance : Form
    {

        private readonly UserRepository _userRepository;

        public frmEntrance()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
            btnRegister.Enabled = false;
        }

        // ─── Register Button ──────────────────────────────────────────

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Build a User object from the form fields
            // Role is always "Customer" for self-registration — admin assigns all other roles
            User newCustomer = new User(
                username: txtUsername.Text.Trim(),
                password: txtPassword.Text.Trim(),
                role: "Customer",
                email: txtEmail.Text.Trim(),
                phoneNumber: txtPhoneNumber.Text.Trim(),
                gender: radioButtonMale.Checked ? "Male" : "Female"
            );

            // Delegate database operation to UserRepository
            // Password is hashed automatically inside AddUser()
            try
            {
                _userRepository.AddUser(newCustomer);
                MessageBox.Show($"User '{newCustomer.Username}' added successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        

        // ─── Form Validation ──────────────────────────────────────────

        // Enables the register button only when all fields are valid
        private void ValidateForm()
        {
            string error;

            bool usernameOk = Validator.ValidateUsernameExists(txtUsername.Text.Trim(), out error);
            bool emailOk = Validator.ValidateEmail(txtEmail.Text.Trim(), out error);
            bool passwordOk = Validator.ValidatePassword(txtPassword.Text.Trim(), out error);
            bool phoneOk = Validator.ValidatePhone(txtPhoneNumber.Text.Trim(), out error);
            bool confirmOk = txtConfirmPassword.Text.Trim() == txtPassword.Text.Trim()
                                   && !string.IsNullOrEmpty(txtConfirmPassword.Text.Trim());
            bool genderOk = radioButtonMale.Checked || radioButtonFemale.Checked;

            btnRegister.Enabled = usernameOk && emailOk && passwordOk && phoneOk && confirmOk && genderOk;
        }

        // ─── Field Change Events ──────────────────────────────────────

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
            lblErrorUsername.Text = Validator.ValidateUsernameExists(txtUsername.Text.Trim(), out string err)
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

            // Show password strength using PasswordHelper
            string strength = PasswordHelper.GetStrength(txtPassword.Text.Trim());
            lblPasswordStrength.Text = string.IsNullOrEmpty(strength) ? "" : $"Strength: {strength}";
            if (strength == "Weak") lblPasswordStrength.ForeColor = Color.Red;
            else if (strength == "Fair") lblPasswordStrength.ForeColor = Color.Orange;
            else if (strength == "Good") lblPasswordStrength.ForeColor = Color.DodgerBlue;
            else if (strength == "Strong") lblPasswordStrength.ForeColor = Color.Green;
            else lblPasswordStrength.ForeColor = Color.Gray;

            // Re-check confirm password if already filled
            if (!string.IsNullOrEmpty(txtConfirmPassword.Text))
                txtConfirmPassword_TextChanged(sender, e);
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
            lblErrorPassword.Text = txtConfirmPassword.Text.Trim() == txtPassword.Text.Trim()
                ? "" : "Passwords do not match.";
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e) => ValidateForm();
        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e) => ValidateForm();

        // ─── Show/Hide Password ───────────────────────────────────────

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        // ─── Menu Strip ───────────────────────────────────────────────

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show(
                "Do you want to exit the application?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (response == DialogResult.Yes)
                this.Close();
        }

        private void mnuBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void frmEntrance_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}