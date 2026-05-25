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

namespace prac
{
    public partial class WalletReport : Form
    {
        WalletReportClass report = new WalletReportClass();
        public WalletReport()
        {
            InitializeComponent();
        }
        

        private void dgvWalletTrans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WalletReport_Load(object sender, EventArgs e)
        {
        
            lblTtlTopupNo.Text =
                "$" + report.GetTotalTopUp().ToString();

            lblTtlUsageNo.Text =
                "$" + report.GetTotalUsage().ToString();

            lblNetBalanceNo.Text =
                "$" + report.GetNetBalance().ToString();

            lblTtlTransactionNo.Text =
                report.GetTotalTransactions().ToString();




            dgvWalletTrans.DataSource =
                report.GetTransactions();
            //Load Customers
            cmbUser.DataSource =
            report.GetCustomers();

            cmbUser.DisplayMember =
                "Username";

            cmbUser.ValueMember =
                "WalletID";

            cmbUser.SelectedIndex = -1;
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmbUser.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select customer.");
                    return;
                }

                string walletID =
                    cmbUser.SelectedValue.ToString();

                int month =
                    dtpDate.Value.Month;

                int year =
                    dtpDate.Value.Year;




                // FILTER TABLE
                string query =
                    "SELECT * FROM WalletTransactions " +
                    "WHERE WalletID='" + walletID + "' " +
                    "AND MONTH([Date])=" + month + " " +
                    "AND YEAR([Date])=" + year;

                DatabaseHelper db =
                    new DatabaseHelper();

                DataTable dt =
                    db.ExecuteQuery(query);

                dgvWalletTrans.DataSource = dt;




                // FILTERED TOTALS
                decimal topup = 0;
                decimal usage = 0;
                decimal refund = 0;

                foreach (DataRow row in dt.Rows)
                {
                    decimal amount =
                        Convert.ToDecimal(row["Amount"]);

                    string type =
                        row["Type"].ToString();

                    if (type == "TopUp")
                    {
                        topup += amount;
                    }

                    else if (type == "Payment")
                    {
                        usage += amount;
                    }

                    else if (type == "Refund")
                    {
                        refund += amount;
                    }
                }




                // UPDATE CARDS
                lblTtlTopupNo.Text =
                    "$" + topup.ToString("0.00");

                lblTtlUsageNo.Text =
                    "$" + usage.ToString("0.00");

                lblNetBalanceNo.Text =
                    "$" + ((topup + refund) - usage).ToString("0.00");

                lblTtlTransactionNo.Text =
                    dt.Rows.Count.ToString();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
           
                
            
        
        }
        
        

        private void btnReset_Click(object sender, EventArgs e)
        {
       
            cmbUser.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;



            dgvWalletTrans.DataSource =
                report.GetTransactions();




            lblTtlTopupNo.Text =
                "$" + report.GetTotalTopUp();

            lblTtlUsageNo.Text =
                "$" + report.GetTotalUsage();

            lblNetBalanceNo.Text =
                "$" + report.GetNetBalance();

            lblTtlTransactionNo.Text =
                report.GetTotalTransactions().ToString();
        }

        private void btnDasboard_Click(object sender, EventArgs e)
        {
          Managerdashboard m =
                new Managerdashboard();

            m.ShowDialog();

            this.Close();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
          ManagerFeedback fb =new ManagerFeedback();

         
            fb.ShowDialog();

            this.Close();
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
        
            MessageBox.Show(
                "You are already in Wallet Report.",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
        
            DialogResult result =
                MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);




            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
    
    
    
}
