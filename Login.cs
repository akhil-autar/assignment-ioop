using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace assignment
{
    public partial class frmLogin : Form
    {
        int _errorcounter = 3;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //used to show or hide the password characters in the password textbox
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //initializing variables
            lblError.Text = "";
            string loginID = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            //checking if username or password is empty
            if (string.IsNullOrWhiteSpace(loginID) || string.IsNullOrWhiteSpace(password))
            {
                lblError.Text = "Please enter Username and Password.";
                return;
            }


            //SECTION TO VALIDATE IN DATABASE
            //connecting to database and defining query
            string connectionstring = "Data Source = localhost; Initial Catalog = GR8Food; Integrated Security = True; TrustServerCertificate = True";
            string query = "SELECT Password FROM Users WHERE Username = @username";

            //using "using" because it automatically closes the connection when done
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                //opens the connection
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    //using this method as it is safer.(refer to documentation --> through research)
                    cmd.Parameters.AddWithValue("@username", loginID);
                    
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // user exists → now validate password
                        string storedPassword = reader["Password"].ToString();

                        if (password == storedPassword)
                        {
                            MessageBox.Show("Login successful!");
                            this.Hide();
                            frmSystemAdmin frmSystemAdmin = new frmSystemAdmin();
                            frmSystemAdmin.ShowDialog();

                            //TO REPLACE WITH CASE TO CALL EACH ROLE'S PAGE
                        }
                        else
                        {
                            //checking and updating the number of attempts
                            _errorcounter -= 1;
                            MessageBox.Show($"Incorrect password.You have {_errorcounter} attemps left.");
                            lblError.Text = ($"Remaining Attempts: {_errorcounter}");
                            if (_errorcounter == 0)
                            {
                                DialogResult userResponse = MessageBox.Show("You have exceeded the number of attempts.Please try again later.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        DialogResult userResponse = MessageBox.Show("You have exceeded the number of attempts.Please try again later.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRegisterNewAccount_Click(object sender, EventArgs e)
        {
            //redirects user to the registration form
            this.Hide();
            frmEntrance frmEntrance = new frmEntrance();
            frmEntrance.ShowDialog();
        }
    }
}
