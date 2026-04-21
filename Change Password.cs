using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace assignment
{
    public partial class frmChangePassword : Form
    {
        string connectionstring = "Data Source=localhost;Initial Catalog=GR8Food;Integrated Security=True;TrustServerCertificate=True";
        public frmChangePassword(string username)
        {
            InitializeComponent();
            btnUpdatePassword.Enabled = false;
        }

        private void pictureBoxBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateUserProfiles frmUpdateUserProfiles = new frmUpdateUserProfiles();
            frmUpdateUserProfiles.ShowDialog();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void chkShowPassword2_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmNewPassword.UseSystemPasswordChar = !chkShowPassword2.Checked;
        }

        
        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT Username, Password FROM Users WHERE Username = @username";
            string password = "";
            string currentusername = "";
            string userID = "akhil";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    {
                        cmd.Parameters.AddWithValue("@username", userID);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            currentusername = reader["Username"].ToString();
                            password = reader["Password"].ToString();
                        }
                    }
                }
            }

            //errorusername = " ";
            //return true;

            if (txtCurrentPassword.Text.Trim() != password)
            {
                lblErrorCurrentPassword.Text = "Incorrect current password.";
                btnUpdatePassword.Enabled = false;
            }
            else
            {
                lblErrorCurrentPassword.Text = "";
                btnUpdatePassword.Enabled = true;
            }
    }
    }
}

        