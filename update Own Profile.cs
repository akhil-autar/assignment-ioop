using assignment.Helpers;
using assignment.Models;
using assignment.Repositories;
using System;
using System.Windows.Forms;

namespace assignment
{
    public partial class frmUpdateOwnProfile : Form
    {
        // ─── Dependencies ─────────────────────────────────────────────
        private readonly string _connectionString = "Data Source=localhost;Initial Catalog=GR8Food;Integrated Security=True;TrustServerCertificate=True";
        private readonly UserRepository _userRepository;

        // ─── State ────────────────────────────────────────────────────
        // Username pulled from session — identifies who is logged in
        private readonly string _sessionUsername = SessionManager.CurrentUser.Username;
        private User _currentAccount = null;

        public frmUpdateOwnProfile()
        {
            InitializeComponent();
            _userRepository = new UserRepository(_connectionString);
            LoadAccountDetails();
            btnUpdate.Enabled = false;
            btnUpdatePassword.Enabled = false;
            chkConfirmPasswordUpdate.Enabled = false;
        }

        // ─── Load Account Details ─────────────────────────────────────

        // Loads and displays the current logged-in user's details
        private void LoadAccountDetails()
        {
            _currentAccount = _userRepository.GetUserByUsername(_sessionUsername);
            
            /*
            if (_currentAccount == null)
            {
                MessageBox.Show("Could not load account details.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            */

            lblCurrentAccountName.Text = _currentAccount.Username;
            lblCurrentEmailName.Text = _currentAccount.Email;
            lblCurrentPhoneNumber.Text = _currentAccount.PhoneNumber;
            lblCurrentRoleName.Text = _currentAccount.Role;
            lblCurrentGenderName.Text = _currentAccount.Gender;
        }

        // ─── Update Profile Button ────────────────────────────────────

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClearErrors();

            // ── Email validation (only if changed) ──
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (!Validator.ValidateEmail(txtEmail.Text.Trim(), out string emailError))
                {
                    lblErrorEmail.Text = emailError;
                    return;
                }
            }

            // ── Phone validation (only if changed) ──
            if (!string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                if (!Validator.ValidatePhone(txtPhoneNumber.Text.Trim(), out string phoneError))
                {
                    lblErrorPhone.Text = phoneError;
                    return;
                }
            }

            // ── Username validation (only if changed) ──
            if (!string.IsNullOrWhiteSpace(txtNewUsername.Text) &&
                txtNewUsername.Text.Trim() != _currentAccount.Username)
            {
                if (!Validator.ValidateUsernameExists(txtNewUsername.Text.Trim(), _connectionString, out string usernameError))
                {
                    lblErrorUsername.Text = usernameError;
                    return;
                }
            }

            // Build updated User object — blank fields keep existing values
            User updatedUser = new User
            {
                Id = _currentAccount.Id,
                Username = string.IsNullOrWhiteSpace(txtNewUsername.Text) ? _currentAccount.Username : txtNewUsername.Text.Trim(),
                Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? _currentAccount.Email : txtEmail.Text.Trim(),
                PhoneNumber = string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ? _currentAccount.PhoneNumber : txtPhoneNumber.Text.Trim(),
                Role = _currentAccount.Role, // admin cannot change their own role
                Gender = radioButtonMale.Checked ? "Male"
                            : radioButtonFemale.Checked ? "Female"
                            : _currentAccount.Gender,
                IsActive = _currentAccount.IsActive
            };

            bool profileUpdated = _userRepository.UpdateUser(updatedUser);

            if (profileUpdated)
            {
                // Update SessionManager so the dashboard reflects the new username immediately
                SessionManager.Login(updatedUser);

                MessageBox.Show($"Profile updated successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                // Reload the display labels with the new values
                LoadAccountDetails();
            }
            else
            {
                MessageBox.Show("Update failed. Please try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Update Password Button ───────────────────────────────────

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            ClearErrors();

            // Verify current password before allowing change
            if (!PasswordHelper.VerifyPassword(txtCurrentPassword.Text.Trim(), _currentAccount.Password))
            {
                lblErrorCurrentPassword.Text = "Current password does not match.";
                return;
            }

            // Validate new password strength
            if (!Validator.ValidatePassword(txtNewPassword.Text.Trim(), out string passwordError))
            {
                lblErrorNewPassword.Text = passwordError;
                return;
            }

            // Confirm passwords match
            if (txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                lblErrorConfirmPassword.Text = "Passwords do not match.";
                return;
            }

            bool passwordUpdated = _userRepository.ResetPassword(_currentAccount.Id, txtNewPassword.Text.Trim());

            if (passwordUpdated)
            {
                MessageBox.Show("Password updated successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetPasswordFields();
            }
            else
            {
                MessageBox.Show("Password update failed. Please try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Form Validation ──────────────────────────────────────────

        private void UpdateButtonState()
        {
            // Uses UpdateButtonState consistently — no blind enables
            btnUpdate.Enabled = chkConfirmUpdate.Checked && IsFormValid();
        }

        private bool IsFormValid()
        {
            if (!string.IsNullOrWhiteSpace(txtNewUsername.Text) && lblErrorUsername.Text != "") return false;
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && lblErrorEmail.Text != "") return false;
            if (!string.IsNullOrWhiteSpace(txtPhoneNumber.Text) && lblErrorPhone.Text != "") return false;

            bool anyChange = !string.IsNullOrWhiteSpace(txtNewUsername.Text)
                          || !string.IsNullOrWhiteSpace(txtEmail.Text)
                          || !string.IsNullOrWhiteSpace(txtPhoneNumber.Text)
                          || comboBox1.SelectedIndex != -1
                          || radioButtonMale.Checked
                          || radioButtonFemale.Checked;

            return anyChange;
        }

        // Enables password update button only when all three fields are filled
        // AND new password matches confirm password
        private void EnableUpdatePassword()
        {
            bool allFilled = !string.IsNullOrEmpty(txtCurrentPassword.Text)
                           && !string.IsNullOrEmpty(txtNewPassword.Text)
                           && !string.IsNullOrEmpty(txtConfirmPassword.Text);

            bool passwordsMatch = txtNewPassword.Text.Trim() == txtConfirmPassword.Text.Trim();

            chkConfirmPasswordUpdate.Enabled = allFilled && passwordsMatch;
            btnUpdatePassword.Enabled = allFilled && passwordsMatch && chkConfirmPasswordUpdate.Checked;
        }

        // ─── Field Change Events ──────────────────────────────────────

        private void txtNewUsername_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewUsername.Text)) { lblErrorUsername.Text = ""; UpdateButtonState(); return; }
            lblErrorUsername.Text = Validator.ValidateUsernameExists(txtNewUsername.Text.Trim(), _connectionString, out string err) ? "" : err;
            UpdateButtonState();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text)) { lblErrorEmail.Text = ""; UpdateButtonState(); return; }
            lblErrorEmail.Text = Validator.ValidateEmail(txtEmail.Text.Trim(), out string err) ? "" : err;
            UpdateButtonState();
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text)) { lblErrorPhone.Text = ""; UpdateButtonState(); return; }
            lblErrorPhone.Text = Validator.ValidatePhone(txtPhoneNumber.Text.Trim(), out string err) ? "" : err;
            UpdateButtonState();
        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                lblErrorCurrentPassword.Text = "";
                EnableUpdatePassword();
                return;
            }

            lblErrorCurrentPassword.Text = PasswordHelper.VerifyPassword(
                txtCurrentPassword.Text.Trim(), _currentAccount.Password)
                ? "" : "Current password does not match.";

            EnableUpdatePassword();
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text)) { lblErrorNewPassword.Text = ""; EnableUpdatePassword(); return; }
            string strength = PasswordHelper.GetStrength(txtNewPassword.Text.Trim());
            lblErrorNewPassword.Text = $"Strength: {strength}";
            EnableUpdatePassword();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            lblErrorConfirmPassword.Text = txtNewPassword.Text.Trim() == txtConfirmPassword.Text.Trim()
                ? "" : "Passwords do not match.";
            EnableUpdatePassword();
        }

        private void chkConfirmUpdate_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void chkConfirmPasswordUpdate_CheckedChanged(object sender, EventArgs e)
        {
            EnableUpdatePassword();
        }

        // ─── Show/Hide Password Checkboxes ───────────────────────────

        private void chkCurrentPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtCurrentPassword.UseSystemPasswordChar = !chkCurrentPassword.Checked;
        }

        private void chkNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = !chkNewPassword.Checked;
        }

        private void chkConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = !chkConfirmPassword.Checked;
        }

        // ─── Helper Methods ───────────────────────────────────────────

        private void ResetForm()
        {
            txtNewUsername.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            comboBox1.SelectedIndex = -1;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            chkConfirmUpdate.Checked = false;
            btnUpdate.Enabled = false;
            ClearErrors();
        }

        private void ResetPasswordFields()
        {
            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
            chkConfirmPasswordUpdate.Checked = false;
            chkConfirmPasswordUpdate.Enabled = false;
            btnUpdatePassword.Enabled = false;
            lblErrorCurrentPassword.Text = "";
            lblErrorNewPassword.Text = "";
            lblErrorConfirmPassword.Text = "";
        }

        private void ClearErrors()
        {
            lblErrorUsername.Text = "";
            lblErrorEmail.Text = "";
            lblErrorPhone.Text = "";
            lblErrorCurrentPassword.Text = "";
            lblErrorNewPassword.Text = "";
            lblErrorConfirmPassword.Text = "";
        }

        // ─── Navigation ───────────────────────────────────────────────

        private void pictureBoxBackToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateOwnProfile_Load(object sender, EventArgs e)
        {

        }
    }
}