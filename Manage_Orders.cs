using assignment.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace CHEF
{

    public partial class Manage_Orders : Form
    {
        private DateTime lastCheckedTime = DateTime.MinValue;

        private bool isUpdating = false;

        private int loggedInChefID; //store logged-in chefID

        OrderService orderService = new OrderService();

        // Track latest order seen
        private int lastMaxOrderID = 0;
        public Manage_Orders()
        {
            InitializeComponent();
            // Allow custom button colors in DataGridView
            Application.EnableVisualStyles();
            dgvOrders.EnableHeadersVisualStyles = false;
            loggedInChefID = SessionManager.CurrentUser.Id;

        }

        private void LoadOrders()
        {
            string selectedFilter = cmbFilter.Text;
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList; //preventing user typing
            if (string.IsNullOrEmpty(selectedFilter))
                selectedFilter = "All";

            // Load only chef-specific orders
            DataTable dt = orderService.GetChefOrders(loggedInChefID);


            // Applying filter
            if (selectedFilter != "All")
            {
                var filteredRows = dt.AsEnumerable()
                    .Where(row => row["Status"] != DBNull.Value &&
                                  row["Status"].ToString().Trim().Equals(selectedFilter, StringComparison.OrdinalIgnoreCase));

                if (filteredRows.Any())
                    dt = filteredRows.CopyToDataTable();
                else
                    dt = dt.Clone();
            }

            dgvOrders.DataSource = dt;
            // Preventing column sorting
            foreach (DataGridViewColumn column in dgvOrders.Columns)
            {
                column.SortMode =
                    DataGridViewColumnSortMode.NotSortable;
            }
            // STEP 1: Add a button column (ONLY ONCE)
            // This prevents duplicate columns every time LoadOrders() runs
            if (!dgvOrders.Columns.Contains("Action"))
            {
                DataGridViewButtonColumn actionButton = new DataGridViewButtonColumn();

                actionButton.Name = "Action";                 // Internal column name
                actionButton.HeaderText = "Action";           // Column title shown in UI
                actionButton.UseColumnTextForButtonValue = false; // We will set text manually per row

                dgvOrders.Columns.Add(actionButton);
            }
            // STEP 2: Loop through each row and style buttons based on order status
            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                // Safety check
                if (row.Cells["Status"].Value == null)
                    continue;

                string status = row.Cells["Status"].Value.ToString();

                DataGridViewButtonCell buttonCell =
                    (DataGridViewButtonCell)row.Cells["Action"];
                // Make buttons look modern
                buttonCell.FlatStyle = FlatStyle.Flat;

                // Pending Orders
                if (status == "Pending")
                {
                    buttonCell.Value = "Mark In Progress";

                    buttonCell.Style.BackColor = Color.FromArgb(255, 140, 0);
                    buttonCell.Style.ForeColor = Color.White;
                    buttonCell.Style.SelectionBackColor = Color.FromArgb(230, 120, 0);
                    buttonCell.Style.SelectionForeColor = Color.White;
                }

                // Orders Being Prepared
                else if (status == "In Progress")
                {
                    buttonCell.Value = "Mark Completed";

                    buttonCell.Style.BackColor = Color.FromArgb(46, 125, 50);
                    buttonCell.Style.ForeColor = Color.White;
                    buttonCell.Style.SelectionBackColor = Color.FromArgb(56, 142, 60);
                    buttonCell.Style.SelectionForeColor = Color.White;
                }

                // Completed Orders
                else if (status == "Completed")
                {
                    buttonCell.Value = "Completed";
                    buttonCell.ReadOnly = true;

                    buttonCell.Style.BackColor = Color.Gray;
                    buttonCell.Style.ForeColor = Color.White;
                }

                // Cancelled Orders               
                else if (status == "Cancelled")
                {
                    buttonCell.Value = "-";
                    buttonCell.ReadOnly = true;

                    buttonCell.Style.BackColor = Color.FromArgb(120, 120, 120);
                    buttonCell.Style.ForeColor = Color.White; buttonCell.Style.BackColor = Color.FromArgb(120, 120, 120);
                    buttonCell.Style.ForeColor = Color.White;
                }
            }


            //renaming headers
            dgvOrders.Columns["OrderID"].HeaderText = "Order ID";
            dgvOrders.Columns["MenuName"].HeaderText = "Item";
            dgvOrders.Columns["Quantity"].HeaderText = "Qty";
            dgvOrders.Columns["SpecialRequest"].HeaderText = "Special Request";
            dgvOrders.Columns["Status"].HeaderText = "Status";

            // STEP 1: Apply color styling based on order status
            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                if (row.Cells["Status"].Value == null)
                    continue;

                string status = row.Cells["Status"].Value.ToString();

                // Apply different background colors
                if (status == "Pending")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                }
                else if (status == "In Progress")
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                }
                else if (status == "Completed")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (status == "Cancelled")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
            // STEP 1: Visually group rows by OrderID using alternating colors

            int currentOrderID = -1;
            bool useAltColor = false;

            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                if (row.Cells["OrderID"].Value == null)
                    continue;

                int orderID = Convert.ToInt32(row.Cells["OrderID"].Value);

                // When OrderID changes → switch color
                if (orderID != currentOrderID)
                {
                    useAltColor = !useAltColor;
                    currentOrderID = orderID;
                }

                // Apply grouping color
                row.DefaultCellStyle.BackColor = useAltColor ? Color.White : Color.AliceBlue;
            }


            // STEP: Highlight new orders based on OrderID
            int currentMaxOrderID = 0;

            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                if (row.Cells["OrderID"].Value == null)
                    continue;

                int orderID = Convert.ToInt32(row.Cells["OrderID"].Value);

                // Track highest OrderID in current load
                if (orderID > currentMaxOrderID)
                    currentMaxOrderID = orderID;


            }

            // Update last known max order
            lastMaxOrderID = currentMaxOrderID;
        }

        //Method to reload UI after status update
        private void ReloadUI()
        {
            LoadOrders();
        }

        //Method to handle filter change
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrders();
        }
        private void Manage_Orders_Load(object sender, EventArgs e)
        {
            cmbFilter.Items.Clear();
            cmbFilter.Items.AddRange(new string[]
            {"All","Pending","In Progress","Completed","Cancelled"
            });

            cmbFilter.SelectedIndex = 0;

            // IMPORTANT: call AFTER setting dropdown
            LoadOrders();
            LoadDashboardCards();

            lastCheckedTime = orderService.GetLatestUpdateTime();
            refreshTimer.Start();
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            refreshTimer.Stop(); // prevent overlap

            DateTime latestDbTime = orderService.GetLatestUpdateTime();

            // only refresh if something changed
            if (latestDbTime > lastCheckedTime)
            {
                ReloadUI();
                lastCheckedTime = latestDbTime;
            }

            refreshTimer.Start();
        }

        // Method to load dashboard card values
        private void LoadDashboardCards()
        {
            lblNumOrders.Text = orderService.GetChefOrderCount(loggedInChefID,"Pending").ToString();
            lblNumProcess.Text = orderService.GetChefOrderCount(loggedInChefID,"In Progress").ToString();
            lblNumCompl.Text = orderService.GetChefOrderCount(loggedInChefID,"Completed").ToString();
            lblNumCanc.Text = orderService.GetChefOrderCount(loggedInChefID,"Cancelled").ToString();
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            // Ensuring valid row clicked
            if (e.RowIndex < 0)
            {
                isUpdating = false;
                return;
            }

            // Prevent double execution
            if (isUpdating)
            {
                isUpdating = false;
                return;
            }

            // Ensuring Action button clicked
            if (
                dgvOrders.Columns[e.ColumnIndex].Name != "Action"
            )
            {
                isUpdating = false;
                return;
            }

            // Ensuring OrderID exists
            if (
                dgvOrders.Rows[e.RowIndex].Cells["OrderID"].Value == null)
            {
                MessageBox.Show("Invalid order selected");

                isUpdating = false;
                return;
            }

            // Getting selected order ID
            int orderID = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells["OrderID"].Value);

            // Getting current status
            string status = dgvOrders.Rows[e.RowIndex].Cells["Status"].Value.ToString();

            
            // Confirmation message
            isUpdating = true;
            DialogResult result = MessageBox.Show("Are you sure you want to update this order status?", "Confirm Update",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Cancelling update
            if (result != DialogResult.Yes)
            {
                isUpdating = false;
                return;
            }

            // Pending - In Progress
            if (status == "Pending")
            {
                orderService.UpdateOrderStatus(
                    orderID, "In Progress");
            }

            // In Progress - Completed
            else if (status == "In Progress")
            {
                orderService.UpdateOrderStatus(orderID, "Completed");
            }

            // Preventing invalid updates
            else
            {
                MessageBox.Show("This order cannot be updated.");
                isUpdating = false;
                return;
            }
            // Reload UI

            ReloadUI();
            // Refresh dashboard counts
            LoadDashboardCards();

            MessageBox.Show("Order status updated successfully.");
            isUpdating = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Chef_Dashboard chef_Dashboard = new Chef_Dashboard();
            if (this.WindowState == FormWindowState.Maximized)
            {
                chef_Dashboard.WindowState = FormWindowState.Maximized;
            }
            else
            {
                chef_Dashboard.WindowState = FormWindowState.Normal;
            }
            this.Close();
            chef_Dashboard.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Manage_Menu manage_Menu = new Manage_Menu();
            if (this.WindowState == FormWindowState.Maximized)
            {
                manage_Menu.WindowState = FormWindowState.Maximized;
            }
            else
            {
                manage_Menu.WindowState = FormWindowState.Normal;
            }
            this.Close();
            manage_Menu.ShowDialog();
  
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            btnOrders.Enabled = false;
        }
    }

}
