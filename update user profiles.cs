using System;
using System.Windows.Forms;
using assignment.Helpers;
using assignment.Models;
using assignment.Repositories;

namespace assignment
{
    // This form is only responsible for UI interaction.
    // All database operations are delegated to UserRepository (Separation of Concerns)
    public partial class frmUpdateUserProfiles : Form
    {
        // ─── Dependencies ─────────────────────────────────────────────
        private readonly string _connectionString = "Data Source=localhost;Initial Catalog=GR8Food;Integrated Security=True;TrustServerCertificate=True";
        private readonly UserRepository _userRepository;

        // ─── State ────────────────────────────────────────────────────
        // Stores the found user so we don't query the database twice
        private User _currentUser = null;

        public frmUpdateUserProfiles()
        {
            InitializeComponent();
            _userRepository = new UserRepository(_connectionString);
            SetFieldsEnabled(false);
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

            // Retrieve user via repository — no SQL in the form
            _currentUser = _userRepository.GetUserByUsername(username);

            if (_currentUser != null)
            {
                // Populate grid with found user's details
                PopulateGrid(_currentUser);
                SetFieldsEnabled(true);
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "User not found.";
                dataGridView1.DataSource = null;
                SetFieldsEnabled(false);
                _currentUser = null;
            }
        }

        // ─── Update Button ────────────────────────────────────────────

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClearErrors();

            if (_currentUser == null)
            {
                lblError.Text = "Please find a user first.";
                return;
            }

            // ── Password change validation ──
            // Only validate password section if the user is trying to change it
            if (!string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                // Verify current password using PasswordHelper (hashed comparison)
                if (!PasswordHelper.VerifyPassword(txtCurrentPassword.Text.Trim(), _currentUser.Password))
                {
                    lblErrorCurrentPassword.Text = "Current password does not match.";
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
                {
                    lblErrorNewPassword.Text = "Please enter a new password.";
                    return;
                }

                if (!Validator.ValidatePassword(txtNewPassword.Text.Trim(), out string passwordError))
                {
                    lblErrorNewPassword.Text = passwordError;
                    return;
                }

                if (txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
                {
                    lblErrorConfirmPassword.Text = "Passwords do not match.";
                    return;
                }
            }

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
                txtNewUsername.Text.Trim() != _currentUser.Username)
            {
                if (!Validator.ValidateUsernameExists(txtNewUsername.Text.Trim(), _connectionString, out string usernameError))
                {
                    lblErrorUsername.Text = usernameError;
                    return;
                }
            }

            // ── Build updated User object using current values as fallback ──
            // If a field is left blank, the existing value is kept (your original logic preserved)
            User updatedUser = new User
            {
                Id = _currentUser.Id,
                Username = string.IsNullOrWhiteSpace(txtNewUsername.Text) ? _currentUser.Username : txtNewUsername.Text.Trim(),
                Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? _currentUser.Email : txtEmail.Text.Trim(),
                PhoneNumber = string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ? _currentUser.PhoneNumber : txtPhoneNumber.Text.Trim(),
                Role = comboBox1.SelectedIndex == -1 ? _currentUser.Role : comboBox1.SelectedItem.ToString(),
                Gender = radioButtonMale.Checked ? "Male"
                            : radioButtonFemale.Checked ? "Female"
                            : _currentUser.Gender,
                IsActive = _currentUser.IsActive
            };

            // Delegate profile update to UserRepository
            bool profileUpdated = _userRepository.UpdateUser(updatedUser);

            // Delegate password update to UserRepository only if a new password was entered
            bool passwordUpdated = true;
            if (!string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                passwordUpdated = _userRepository.ResetPassword(updatedUser.Id, txtNewPassword.Text.Trim());
            }

            if (profileUpdated && passwordUpdated)
            {
                MessageBox.Show($"Profile for '{updatedUser.Username}' updated successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            else
            {
                MessageBox.Show("Update failed. Please try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Helper Methods ───────────────────────────────────────────

        // Enables or disables all editable fields at once
        private void SetFieldsEnabled(bool enabled)
        {
            txtNewUsername.Enabled = enabled;
            txtPhoneNumber.Enabled = enabled;
            txtEmail.Enabled = enabled;
            radioButtonFemale.Enabled = enabled;
            radioButtonMale.Enabled = enabled;
            comboBox1.Enabled = enabled;
            btnUpdate.Enabled = enabled;
            txtCurrentPassword.Enabled = enabled;
            txtNewPassword.Enabled = enabled;
            txtConfirmPassword.Enabled = enabled;
            chkConfirmDelete.Enabled = enabled;
        }

        // Builds a clean DataTable from the User object to display in the grid
        // Avoids exposing raw database columns and hides the password column
        private void PopulateGrid(User user)
        {
            var dt = new System.Data.DataTable();
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
        }

        private void ResetForm()
        {
            txtUsername.Clear();
            txtNewUsername.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
            comboBox1.SelectedIndex = -1;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            chkConfirmDelete.Checked = false;
            dataGridView1.DataSource = null;
            _currentUser = null;
            SetFieldsEnabled(false);
            ClearErrors();
        }

        private void ClearErrors()
        {
            lblError.Text = "";
            lblErrorUsername.Text = "";
            lblErrorEmail.Text = "";
            lblErrorPhone.Text = "";
            lblErrorCurrentPassword.Text = "";
            lblErrorNewPassword.Text = "";
            lblErrorConfirmPassword.Text = "";
            lblErrorUpdate.Text = "";
        }

        // ─── Field Change Events ──────────────────────────────────────

        private void txtNewUsername_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewUsername.Text)) { lblErrorUsername.Text = ""; return; }
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

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text)) { lblErrorNewPassword.Text = ""; UpdateButtonState(); return; }
            // Show password strength as the user types
            string strength = PasswordHelper.GetStrength(txtNewPassword.Text.Trim());
            lblErrorNewPassword.Text = $"Strength: {strength}";
            UpdateButtonState();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text)) { lblErrorConfirmPassword.Text = ""; return; }
            lblErrorConfirmPassword.Text = txtConfirmPassword.Text.Trim() == txtNewPassword.Text.Trim()
                ? "" : "Passwords do not match.";
            UpdateButtonState();
        }

        private void chkConfirmDelete_CheckedChanged(object sender, EventArgs e) => UpdateButtonState();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) => UpdateButtonState();
        private void radioButtonMale_CheckedChanged(object sender, EventArgs e) => UpdateButtonState();
        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e) => UpdateButtonState();

        // Enables the update button only when confirm checkbox is checked and form is valid
        private void UpdateButtonState()
        {
            btnUpdate.Enabled = chkConfirmDelete.Checked && IsFormValid();
        }

        private bool IsFormValid()
        {
            if (!string.IsNullOrWhiteSpace(txtNewUsername.Text) && lblErrorUsername.Text != "") return false;
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && lblErrorEmail.Text != "") return false;
            if (!string.IsNullOrWhiteSpace(txtPhoneNumber.Text) && lblErrorPhone.Text != "") return false;
            if (!string.IsNullOrWhiteSpace(txtCurrentPassword.Text) && lblErrorCurrentPassword.Text != "") return false;
            if (!string.IsNullOrWhiteSpace(txtConfirmPassword.Text) && lblErrorConfirmPassword.Text != "") return false;

            // At least one field must be changed
            bool anyChange = !string.IsNullOrWhiteSpace(txtNewUsername.Text)
                          || !string.IsNullOrWhiteSpace(txtEmail.Text)
                          || !string.IsNullOrWhiteSpace(txtPhoneNumber.Text)
                          || comboBox1.SelectedIndex != -1
                          || radioButtonMale.Checked
                          || radioButtonFemale.Checked
                          || !string.IsNullOrWhiteSpace(txtNewPassword.Text);

            return anyChange;
        }

        // ─── Show/Hide Password Checkboxes ────────────────────────────

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

        // ─── Navigation ───────────────────────────────────────────────

        private void pictureBoxBackToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateUserProfiles_Load(object sender, EventArgs e)
        {

        }
    }
}