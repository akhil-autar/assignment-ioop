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

namespace assignment
{
    public partial class frmEntrance : Form
    {
        public frmEntrance()
        {
            InitializeComponent();
        }
        private void frmEntrance_Load(object sender, EventArgs e)
        {

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult userResponse = MessageBox.Show("Do you want to exit the application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (userResponse == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void mnuBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //assigning data to the variables from the textbox
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone_number = txtPhoneNumber.Text.Trim();
            string password = txtPassword.Text.Trim();
            string gender = "";

            //getting the value of the gender
            if (radioButtonMale.Checked)
            {
                gender = radioButtonMale.Text.Trim();
            }
            else
            {
                gender = radioButtonFemale.Text.Trim();
            }


            //CONNECTION TO DATABASE
            //defining the query
            string query = "INSERT INTO Users (Username, Password, Role, Email, Phone, Gender) VALUES (@username, @password, @role, @email, @phone, @gender)";
            string connectionstring = "Data Source=localhost;Initial Catalog=GR8Food;Integrated Security=True;TrustServerCertificate=True";

            //connecting to the database
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", "Customer");
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone_number);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    
                    //sends query to the database. Returns 1 or 0. 1 if added, 0 if failed.
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("User added successfully!");
                        //redirecting to the login page to allow user to login
                        this.Hide();
                        frmLogin frmLogin2 = new frmLogin();
                        frmLogin2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add user.");
                    }
                }
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //used to show or hide the password characters in the password textbox
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
