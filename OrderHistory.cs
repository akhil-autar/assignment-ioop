
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
    public partial class OrderHistory : Form
    {
        string connectionString = "Data Source=localhost;Initial Catalog=GR8Food;Integrated Security=True;TrustServerCertificate=True";
        public OrderHistory()
        {
            InitializeComponent();

            LoadOrderHistory();
            this.TopLevel = false;
            this.FormBorderStyle =
                FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {

        }
        private void LoadOrderHistory()
        {
          
            flowHistory.Controls.Clear();

            using (SqlConnection con =
                new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"SELECT *
              FROM Orders
              WHERE CustomerID = 4
              ORDER BY OrderID DESC", con);

                SqlDataReader reader =
                    cmd.ExecuteReader();

                while (reader.Read())
                {
                    int orderId =
                        Convert.ToInt32(reader["OrderID"]);

                    decimal total =
                        Convert.ToDecimal(reader["TotalAmount"]);

                    string status =
                        reader["Status"].ToString();

                    DateTime date =
                        Convert.ToDateTime(reader["OrderDateTime"]);

                    flowHistory.Controls.Add(
                        CreateHistoryCard(
                            orderId,
                            total,
                            status,
                            date));
                }

                reader.Close();
            }
        }
        private Panel CreateHistoryCard(
    int orderId,
    decimal total,
    string status,
    DateTime date)
        {
            Panel card = new Panel();

            card.Size = new Size(650, 120);
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(10);

            Label lblOrder = new Label();

            lblOrder.Text = "Order #" + orderId;
            lblOrder.Font =
                new Font("Segoe UI", 12, FontStyle.Bold);

            lblOrder.Location = new Point(20, 15);
            lblOrder.AutoSize = true;

            Label lblTotal = new Label();

            lblTotal.Text = "RM " + total;
            lblTotal.ForeColor = Color.Green;

            lblTotal.Location = new Point(20, 50);
            lblTotal.AutoSize = true;

            Label lblStatus = new Label();

            lblStatus.Text = "Status: " + status;
            if (status == "Completed")
            {
                lblStatus.ForeColor = Color.Green;
            }
            else if (status == "Pending")
            {
                lblStatus.ForeColor = Color.Orange;
            }
            else if (status == "Cancelled")
            {
                lblStatus.ForeColor = Color.Red;
            }

            lblStatus.Location = new Point(200, 50);
            lblStatus.AutoSize = true;

            Label lblDate = new Label();

            lblDate.Text = date.ToShortDateString();

            lblDate.Location = new Point(20, 80);
            lblDate.AutoSize = true;

            card.Controls.Add(lblOrder);
            card.Controls.Add(lblTotal);
            card.Controls.Add(lblStatus);
            card.Controls.Add(lblDate);
            if (status == "Pending")
            {
                Button btnCancel = new Button();

                btnCancel.Text = "Cancel Order";

                btnCancel.Size = new Size(130, 40);

                btnCancel.Location = new Point(480, 35);

                btnCancel.BackColor = Color.Crimson;

                btnCancel.ForeColor = Color.White;

                btnCancel.FlatStyle = FlatStyle.Flat;

                btnCancel.FlatAppearance.BorderSize = 0;

                btnCancel.Click += (s, e) =>
                {
                    CancelOrder(orderId, total);
                };

                card.Controls.Add(btnCancel);
            }

            return card;
        }
        private void CancelOrder(int orderId, decimal total)
        {
            int customerId = 4;

            using (SqlConnection con =
                new SqlConnection(connectionString))
            {
                con.Open();

                // UPDATE ORDER STATUS

                SqlCommand cmd = new SqlCommand(
                    @"UPDATE Orders
              SET Status='Cancelled'
              WHERE OrderID=@id", con);

                cmd.Parameters.AddWithValue("@id", orderId);

                cmd.ExecuteNonQuery();
                SqlCommand refundCmd = new SqlCommand(
                @"UPDATE Users
                SET WalletBalance = WalletBalance + @amount
                WHERE UserID=@cust", con);

                refundCmd.Parameters.AddWithValue("@amount", total);

                refundCmd.Parameters.AddWithValue("@cust", customerId);

                refundCmd.ExecuteNonQuery();

                // REFUND WALLET

                SqlCommand transCmd = new SqlCommand(
                @"INSERT INTO WalletTransactions
                (TransactionID, WalletID, Amount, Type, Date)
                VALUES
                (@tid, @wid, @amt, @type, @date)", con);

                transCmd.Parameters.AddWithValue("@tid",
                    "T" + DateTime.Now.Ticks.ToString().Substring(10));

                transCmd.Parameters.AddWithValue("@wid", "W001");

                transCmd.Parameters.AddWithValue("@amt", total);

                transCmd.Parameters.AddWithValue("@type", "Refund");

                transCmd.Parameters.AddWithValue("@date", DateTime.Now);

                transCmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Order cancelled and refund processed!");

                LoadOrderHistory();
            }
        }
    }
    }


