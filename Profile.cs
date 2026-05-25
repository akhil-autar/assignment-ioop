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

namespace Gr8FoodSystem_Final
{
    public partial class Profile : Form
    {
        string connectionString = "Data Source=localhost;Initial Catalog=GR8Food;Integrated Security=True;TrustServerCertificate=True";
        public Profile()
        {
            InitializeComponent();

            panelChange.MouseEnter += (s, e) => panelChange.BackColor = Color.LightGray;
            panelChange.MouseLeave += (s, e) => panelChange.BackColor = Color.White;

            panelLogout.MouseEnter += (s, e) => panelLogout.BackColor = Color.MistyRose;
            panelLogout.MouseLeave += (s, e) => panelLogout.BackColor = Color.White;

            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }


        private void Profile_Load(object sender, EventArgs e)
        {
            using (SqlConnection con =
    new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT Balance FROM Wallet WHERE CustomerID = 4", con);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    lblWallet.Text =
                        "Wallet Balance: RM " + result.ToString();
                }
            }
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out!");
        }

        private void labelChangePassword_MouseEnter(object sender, EventArgs e)
        {
            lblChangePassword.ForeColor = Color.Red;

        }

        private void labelChangePassword_MouseLeave(object sender, EventArgs e)
        {
            lblChangePassword.ForeColor = Color.Black;
        }

        private void labelLogout_MouseEnter(object sender, EventArgs e)
        {
            labelLogout.ForeColor = Color.DarkGreen;
        }

        private void labelLogout_MouseLeave(object sender, EventArgs e)
        {
            labelLogout.ForeColor = Color.Green;
        }
    }
}
   
