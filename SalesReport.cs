using assignment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class frmSalesReport : Form
    {
        private SalesRepository _salesRepository;

        public frmSalesReport()
        {
            InitializeComponent();
            _salesRepository = new SalesRepository();
        }
      


        // ── Dropdown loaders ─────────────────────────────────────────────

        private void LoadCategoryDropdown()
        {
            try
            {
                cmbCategory.Items.Clear();
                cmbCategory.Items.Add("All Categories");

                DataTable dt = _salesRepository.GetCategories();
                foreach (DataRow row in dt.Rows)
                    cmbCategory.Items.Add(row["Category"].ToString());

                cmbCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load categories: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Fallback: at least keep "All Categories" selectable
                if (cmbCategory.Items.Count == 0)
                    cmbCategory.Items.Add("All Categories");
                cmbCategory.SelectedIndex = 0;
            }
        }


        private void LoadMonthDropdown()
        {
            try
            {
                cmbMonth.Items.Clear();
                cmbMonth.Items.Add("All Months");
                string[] months = {
                "January","February","March","April","May","June",
                "July","August","September","October","November","December"
            };
                foreach (string m in months)
                    cmbMonth.Items.Add(m);

                cmbMonth.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load month filter: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadYearDropdown()
        {
            try
            {
                cmbYear.Items.Clear();
                cmbYear.Items.Add("All Years");
                int currentYear = DateTime.Now.Year;
                for (int y = currentYear; y >= currentYear - 4; y--)
                    cmbYear.Items.Add(y.ToString());

                cmbYear.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load year filter: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ── Core load ────────────────────────────────────────────────────

        private void LoadReport()
        {
            try
            {
                // Guard: dropdowns must be initialised before reading them
                if (cmbMonth.Items.Count == 0 || cmbYear.Items.Count == 0 || cmbCategory.Items.Count == 0)
                {
                    MessageBox.Show("Filters are not ready yet. Please wait and try again.",
                        "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int? month = cmbMonth.SelectedIndex > 0
                    ? (int?)cmbMonth.SelectedIndex
                    : null;

                int? year = cmbYear.SelectedIndex > 0
                    ? (int?)int.Parse(cmbYear.SelectedItem.ToString())
                    : null;

                string category = cmbCategory.SelectedIndex > 0
                    ? cmbCategory.SelectedItem.ToString()
                    : null;

                // Load summary cards
                DataTable summary = _salesRepository.GetSalesSummary(month, year, category);

                if (summary == null || summary.Rows.Count == 0)
                {
                    lblTotalOrders.Text = "0";
                    lblTotalRevenue.Text = "RM 0.00";
                    lblTotalItems.Text = "0";
                }
                else
                {
                    DataRow r = summary.Rows[0];

                    lblTotalOrders.Text = r["TotalOrders"] != DBNull.Value
                        ? r["TotalOrders"].ToString()
                        : "0";

                    lblTotalRevenue.Text = r["TotalRevenue"] != DBNull.Value
                        ? $"RM {Convert.ToDecimal(r["TotalRevenue"]):N2}"
                        : "RM 0.00";

                    lblTotalItems.Text = r["TotalItemsSold"] != DBNull.Value
                        ? r["TotalItemsSold"].ToString()
                        : "0";
                }

                // Load detail grid
                DataTable dt = _salesRepository.GetSalesReport(month, year, category);

                if (dt == null || dt.Rows.Count == 0)
                {
                    dgvSalesReport.DataSource = null;
                    lblResultCount.Text = "No records found for the selected filters.";
                    return;
                }

                dgvSalesReport.DataSource = dt;
                dgvSalesReport.Refresh();
                StyleGrid();
                lblResultCount.Text = $"{dt.Rows.Count} record(s) found";
            }
            catch (FormatException)
            {
                MessageBox.Show("An invalid value was selected in one of the filters. Please reset and try again.",
                    "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales report: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void StyleGrid()
        {
            try
            {
                dgvSalesReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSalesReport.RowHeadersVisible = false;
                dgvSalesReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvSalesReport.AllowUserToAddRows = false;
                dgvSalesReport.ReadOnly = true;

                if (dgvSalesReport.Columns.Contains("OrderID"))
                    dgvSalesReport.Columns["OrderID"].HeaderText = "Order ID";
                if (dgvSalesReport.Columns.Contains("OrderDateTime"))
                    dgvSalesReport.Columns["OrderDateTime"].HeaderText = "Date & Time";
                if (dgvSalesReport.Columns.Contains("TotalAmount"))
                    dgvSalesReport.Columns["TotalAmount"].HeaderText = "Order Total (RM)";
                if (dgvSalesReport.Columns.Contains("Status"))
                    dgvSalesReport.Columns["Status"].HeaderText = "Status";
                if (dgvSalesReport.Columns.Contains("Category"))
                    dgvSalesReport.Columns["Category"].HeaderText = "Category";
                if (dgvSalesReport.Columns.Contains("TotalItemsSold"))
                    dgvSalesReport.Columns["TotalItemsSold"].HeaderText = "Items Sold";
                if (dgvSalesReport.Columns.Contains("ItemRevenue"))
                    dgvSalesReport.Columns["ItemRevenue"].HeaderText = "Category Revenue (RM)";
            }
            catch (Exception ex)
            {
                // Non-critical — grid still shows data even if styling fails
                MessageBox.Show("Warning: Could not apply grid formatting. " + ex.Message,
                    "Styling Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // ── Button events ────────────────────────────────────────────────

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                LoadReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                cmbMonth.SelectedIndex = 0;
                cmbYear.SelectedIndex = 0;
                cmbCategory.SelectedIndex = 0;
                LoadReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not reset filters: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSalesReport_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCategoryDropdown();
                LoadMonthDropdown();
                LoadYearDropdown();
                LoadReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to initialise Sales Report: " + ex.Message,
                    "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
    



    
