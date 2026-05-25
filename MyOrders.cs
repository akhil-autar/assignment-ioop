using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Gr8FoodSystem_Final
{
    public partial class MyOrders : Form
    {
        string connectionString = "Data Source=localhost;Initial Catalog=GR8Food;Integrated Security=True;TrustServerCertificate=True";
        public MyOrders()
        {
            InitializeComponent();

            CreateBottomPanel();

            LoadOrders();

            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        // CREATE BOTTOM PANEL
        private void CreateBottomPanel()
        {
            Panel panelBottom = new Panel();

            panelBottom.Height = 70;
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.BackColor = Color.White;
            panelBottom.Dock = DockStyle.Bottom;

            Label lbl = new Label();

            lbl.Name = "lblTotal";
            lbl.Text = "Total: RM 0";
            lbl.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lbl.Location = new Point(20, 35);
            lbl.AutoSize = true;

            Button btn = new Button();

            btn.Text = "Checkout";
            btn.Size = new Size(140, 45);
            btn.Location = new Point(620, 25);

            btn.BackColor = Color.Crimson;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;

            btn.Click += btnCheckout_Click;

            panelBottom.Controls.Add(lbl);
            panelBottom.Controls.Add(btn);

            this.Controls.Add(panelBottom);

            panelBottom.BringToFront();
        }

        // CREATE ORDER CARD
        private Panel CreateOrderCard(string name, int qty, decimal price)
        {
            Panel card = new Panel();

            card.Size = new Size(440, 70);
            card.BackColor = Color.White;
            card.Margin = new Padding(10);
            card.BorderStyle = BorderStyle.FixedSingle;

            // NAME
            Label lblName = new Label();

            lblName.Text = name + " x" + qty;
            lblName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblName.Location = new Point(15, 10);
            lblName.AutoSize = true;

            // PRICE
          

            Label lblPrice = new Label();


            lblPrice.Text = "RM " + (price * qty);
            lblPrice.ForeColor = Color.Green;
            lblPrice.Location = new Point(15, 35);
            lblPrice.AutoSize = true;

            // REMOVE BUTTON
            Button btnRemove = new Button();

            btnRemove.Text = "Remove";
            btnRemove.Size = new Size(90, 35);
            btnRemove.Location = new Point(320, 15);

            btnRemove.BackColor = Color.Crimson;
            btnRemove.ForeColor = Color.White;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.FlatAppearance.BorderSize = 0;

            btnRemove.Click += (s, e) =>
            {
                Cart.items.Remove(name);

                LoadOrders();
            };

            card.Controls.Add(lblName);
            card.Controls.Add(lblPrice);
            card.Controls.Add(btnRemove);

            return card;
        }

        // LOAD ORDERS
        public void LoadOrders()
        {
            flowOrders.Padding = new Padding(20);
            flowOrders.Dock = DockStyle.Fill;

            flowOrders.Controls.Clear();

            int total = 0;

            foreach (var item in Cart.items)
            {

                string name = item.Key;
                int qty = item.Value;

               

                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "SELECT Price FROM Menu_Table WHERE MenuName=@name", con);

                    cmd.Parameters.AddWithValue("@name", name);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        decimal price =
                            Convert.ToDecimal(result);

                        total += (int)(price * qty);
                        flowOrders.Controls.Add(
                   CreateOrderCard(name, qty, price));

                    }
                }
            }

            Label lbl =
                this.Controls.Find("lblTotal", true)[0] as Label;

            lbl.Text = "Total: RM " + total;
        }

        // CHECKOUT
        private void btnCheckout_Click(object sender, EventArgs e)
        
        {
            try
            {
                if (Cart.items.Count == 0)
                {
                    MessageBox.Show("Your cart is empty!");

                    return;
                }
                int customerId = 4;

                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    con.Open();

                    int total = 0;

                    // CALCULATE TOTAL

                    foreach (var item in Cart.items)
                    {
                        string menuName = item.Key;
                        int qty = item.Value;

                        SqlCommand priceCmd = new SqlCommand(
                            "SELECT Price FROM Menu_Table WHERE MenuName=@name", con);

                        priceCmd.Parameters.AddWithValue("@name", menuName);

                        decimal price =
                            Convert.ToDecimal(priceCmd.ExecuteScalar());

                        total += (int)(price * qty);
                    }

                    // CHECK WALLET BALANCE

                    SqlCommand walletCmd = new SqlCommand(
                        "SELECT Balance FROM Wallet WHERE CustomerID=@id", con);

                    walletCmd.Parameters.AddWithValue("@id", customerId);

                    decimal balance =
                        Convert.ToDecimal(walletCmd.ExecuteScalar());

                    if (balance < total)
                    {
                        MessageBox.Show(
                            "Insufficient wallet balance!\nPlease top up.");

                        return;
                    }
                    if (balance <= 0)
                    {
                        MessageBox.Show(
                            "Wallet balance is empty!");

                        return;
                    }

                    // DEDUCT WALLET BALANCE

                    SqlCommand deductCmd = new SqlCommand(
                        @"UPDATE Wallet
              SET Balance = Balance - @total
              WHERE CustomerID=@id", con);

                    deductCmd.Parameters.AddWithValue("@total", total);
                    deductCmd.Parameters.AddWithValue("@id", customerId);

                    deductCmd.ExecuteNonQuery();
                    // MONEY DEDUCT AND RECORDS INSIDE WALLETTRANSACTIONS
                    SqlCommand transCmd = new SqlCommand(
                 @"INSERT INTO WalletTransactions
             (TransactionID, WalletID, Amount, Type, Date)
             VALUES
             (@tid, @wid, @amt, @type, @date)", con);

                    transCmd.Parameters.AddWithValue("@tid",
                        "T" + DateTime.Now.Ticks.ToString().Substring(10));

                    transCmd.Parameters.AddWithValue("@wid", "W001");

                    transCmd.Parameters.AddWithValue("@amt", total);

                    transCmd.Parameters.AddWithValue("@type", "Payment");

                    transCmd.Parameters.AddWithValue("@date", DateTime.Now);

                    transCmd.ExecuteNonQuery();

                    // INSERT ORDER

                    SqlCommand orderCmd = new SqlCommand(
                        @"INSERT INTO Orders
            (CustomerID, TotalAmount, Status, OrderDateTime, StatusTime)
            OUTPUT INSERTED.OrderID
            VALUES
            (@cust, @total, @status, @datetime, @statustime)", con);

                    orderCmd.Parameters.AddWithValue("@cust", customerId);
                    orderCmd.Parameters.AddWithValue("@total", total);
                    orderCmd.Parameters.AddWithValue("@status", "Pending");
                    orderCmd.Parameters.AddWithValue("@datetime", DateTime.Now);
                    orderCmd.Parameters.AddWithValue("@statustime", DateTime.Now);

                    int orderId = (int)orderCmd.ExecuteScalar();

                    // INSERT ORDER ITEMS

                    foreach (var item in Cart.items)
                    {
                        string menuName = item.Key;
                        int qty = item.Value;

                        SqlCommand menuCmd = new SqlCommand(
                            "SELECT MenuID, Price FROM Menu_Table WHERE MenuName=@name", con);

                        menuCmd.Parameters.AddWithValue("@name", menuName);

                        SqlDataReader reader =
                            menuCmd.ExecuteReader();

                        int menuId = 0;
                        decimal price = 0;

                        if (reader.Read())
                        {
                            menuId =
                                Convert.ToInt32(reader["MenuID"]);

                            price =
                                Convert.ToDecimal(reader["Price"]);
                        }

                        reader.Close();

                        decimal subtotal = price * qty;

                        SqlCommand itemCmd = new SqlCommand(
                            @"INSERT INTO OrderItems
                (OrderID, MenuID, Quantity, Subtotal)
                VALUES
                (@oid, @mid, @qty, @sub)", con);

                        itemCmd.Parameters.AddWithValue("@oid", orderId);
                        itemCmd.Parameters.AddWithValue("@mid", menuId);
                        itemCmd.Parameters.AddWithValue("@qty", qty);
                        itemCmd.Parameters.AddWithValue("@sub", subtotal);

                        itemCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Order placed successfully!");

                    Cart.items.Clear();

                    LoadOrders();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
        