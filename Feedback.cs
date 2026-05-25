using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gr8FoodSystem_Final
{
    public partial class Feedback : Form
    {
        string connectionString = "Data Source=localhost;Initial Catalog=GR8Food;Integrated Security=True;TrustServerCertificate=True";
        public Feedback()
        {
            InitializeComponent();
            LoadCompletedOrders();
            this.TopLevel = false;
            this.FormBorderStyle =
                FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

        }
        private void LoadCompletedOrders()
        {
            using (SqlConnection con =
                new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"SELECT OrderID
              FROM Orders
              WHERE CustomerID = 4
              AND Status = 'Completed'", con);

                SqlDataReader reader =
                    cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbOrders.Items.Add(
                        reader["OrderID"].ToString());
                }

                reader.Close();
            }
        }
        private void Feedback_Load(object sender, EventArgs e)
        {

        }

        private void txtFeedback_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbOrders.SelectedItem == null)
            {
                MessageBox.Show("Select an order.");
                return;
            }
            if (txtFeedback.Text.Trim() == "")
            {
                MessageBox.Show("Please enter feedback.");

                return;
            }

            if (!radioGood.Checked &&
              !radioBad.Checked &&
              !radioNeutral.Checked)
            {
                MessageBox.Show("Please select a rating.");

                return;
            }
            // RATING

            string rating = "";

            if (radioGood.Checked)
            {
                rating = "Good";
            }
            else if (radioBad.Checked)
            {
                rating = "Bad";
            }
            else if (radioNeutral.Checked)
            {
                rating = "Neutral";
            }

            // MESSAGE WITH RATING

            string message =
               txtFeedback.Text + "[" + rating + "] ";
            using (SqlConnection con =
                new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Feedback
            (OrderID, Message, Response, Status, Date)
            VALUES
            (@oid, @msg, @res, @status, @date)", con);

                cmd.Parameters.AddWithValue(
                    "@oid",
                    cmbOrders.SelectedItem.ToString());

                cmd.Parameters.AddWithValue(
                    "@msg",
                    message);

                cmd.Parameters.AddWithValue(
                    "@res",
                    "");

                cmd.Parameters.AddWithValue(
                    "@status",
                    "Pending");

                cmd.Parameters.AddWithValue(
                    "@date",
                    DateTime.Now);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Feedback submitted!");

                txtFeedback.Clear();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioGood_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }
    
