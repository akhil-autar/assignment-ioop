using assignment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace prac
{
    public partial class Managerdashboard : Form
    {
        DatabaseHelper db = new DatabaseHelper();
        public Managerdashboard()
        {
            InitializeComponent();
        }
        private void LoadWalletChart()
        {
            try
            {
                chartWallet.Series.Clear();

                Series s = new Series("Wallet");

                s.ChartType = SeriesChartType.Column;

                chartWallet.Series.Add(s);
                chartWallet.ChartAreas[0].AxisY.Enabled =
                AxisEnabled.True;

                chartWallet.ChartAreas[0].AxisX.MajorGrid.Enabled =
                    false;

                chartWallet.ChartAreas[0].AxisY.MajorGrid.Enabled =
                    false;


                string query =
                "SELECT Type, SUM(Amount) AS Total " +
                "FROM WalletTransactions " +
                "GROUP BY Type";

                DataTable dt = db.ExecuteQuery(query);

                foreach (DataRow row in dt.Rows)
                {
                    s.Points.AddXY(
                        row["Type"].ToString(),
                        Convert.ToDecimal(row["Total"]));
                    s.IsVisibleInLegend = false;
                    s.Color = Color.SteelBlue;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadFeedbackChart()
        {
      
            try
            {
                chartFeedback.Series.Clear();




                Series s = new Series("Feedback");
                s.ChartType = SeriesChartType.Doughnut;
                s.IsValueShownAsLabel = true;
                s.Label = "#PERCENT{P0}";
                s.Font = new Font("Segoe UI", 10,FontStyle.Bold);

                chartFeedback.Series.Add(s);
                chartFeedback.Legends[0].Docking = Docking.Right;




                string query =
                    "SELECT Message FROM Feedback";

                DataTable dt =
                    db.ExecuteQuery(query);




                int positive = 0;
                int neutral = 0;
                int negative = 0;




                foreach (DataRow row in dt.Rows)
                {
                    string msg =
                        row["Message"]
                        .ToString()
                        .ToLower();




                    // POSITIVE
                    if (msg.Contains("good"))
                        
                    {
                        positive++;
                    }




                    // NEGATIVE
                    else if (msg.Contains("bad"))
                            
                    {
                        negative++;
                    }




                    // NEUTRAL
                    else
                    {
                        neutral++;
                    }
                }




                s.Points.AddXY("Positive", positive);
                s.Points.AddXY("Neutral", neutral);
                s.Points.AddXY("Negative", negative);
                s.Points[0].Color = Color.LightGreen;
                s.Points[1].Color = Color.Goldenrod;
                s.Points[2].Color = Color.IndianRed;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            ManagerFeedback f=new ManagerFeedback();
            f.ShowDialog();
            this.Hide(); 
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            WalletReport w = new WalletReport();
            w.ShowDialog();
            this.Hide();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Managerdashboard login = new Managerdashboard();
                this.Close(); 
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void Managerdashboard_Load(object sender, EventArgs e)
        {
           try
           {
                // ACTIVE CUSTOMERS
                object customers =
                    db.Executescalar(
                    "SELECT COUNT(*) FROM Users WHERE Role='Customer'");

                lblActiveCustomerNo.Text =
                    customers.ToString();




                // TOTAL FEEDBACK
                object feedback =
                    db.Executescalar(
                    "SELECT COUNT(*) FROM Feedback");

                lblTtlFeedbackNo.Text =
                    feedback.ToString();




                // TOTAL WALLET USAGE
                object totalUse =
                    db.Executescalar(
                    "SELECT SUM(Amount) FROM WalletTransactions WHERE Type='Payment'");

                lblTotalWalletUsageNo.Text =
                    totalUse.ToString();




                // TOTAL TOPUP
                object topup =
                    db.Executescalar(
                    "SELECT SUM(Amount) FROM WalletTransactions WHERE Type='Top-Up'");

                lblMonthlyTopupNo.Text =
                    topup.ToString();


                // FEEDBACK LABEL
                lblTtlFbReceived.Text =
                    lblTtlFeedbackNo.Text + " feedback received";




                // ================= TOPUP % =================

                decimal currentTopup = 0;
                decimal lastTopup = 0;

                object currentTopupObj =
                    db.Executescalar(
                    "SELECT ISNULL(SUM(Amount),0) " +
                    "FROM WalletTransactions " +
                    "WHERE Type='Top-Up' " +
                    "AND MONTH(Date)=MONTH(GETDATE())");

                object lastTopupObj =
                    db.Executescalar(
                    "SELECT ISNULL(SUM(Amount),0) " +
                    "FROM WalletTransactions " +
                    "WHERE Type='Top-Up' " +
                    "AND MONTH(Date)=MONTH(GETDATE())-1");

                currentTopup =
                    Convert.ToDecimal(currentTopupObj);

                lastTopup =
                    Convert.ToDecimal(lastTopupObj);

                decimal topupPercent = 0;

                if (lastTopup > 0)
                {
                    topupPercent =
                        ((currentTopup - lastTopup)
                        / lastTopup) * 100;
                }

                lblMonthlyTopUpIncrease.Text =
                    "increase by "
                    + Math.Round(topupPercent, 1)
                    + "% from last month";




                // ================= WALLET USAGE % =================

                decimal currentUsage = 0;
                decimal lastUsage = 0;

                object currentUsageObj =
                    db.Executescalar(
                    "SELECT ISNULL(SUM(Amount),0) " +
                    "FROM WalletTransactions " +
                    "WHERE Type='Payment' " +
                    "AND MONTH(Date)=MONTH(GETDATE())");

                object lastUsageObj =
                    db.Executescalar(
                    "SELECT ISNULL(SUM(Amount),0) " +
                    "FROM WalletTransactions " +
                    "WHERE Type='Payment' " +
                    "AND MONTH(Date)=MONTH(GETDATE())-1");

                currentUsage =
                    Convert.ToDecimal(currentUsageObj);

                lastUsage =
                    Convert.ToDecimal(lastUsageObj);

                decimal usagePercent = 0;

                if (lastUsage > 0)
                {
                    usagePercent =
                        ((currentUsage - lastUsage)
                        / lastUsage) * 100;
                }

                lblMonthlyWalletUsage.Text =
                    "increase by "
                    + Math.Round(usagePercent, 1)
                    + "% from last month";




                // ================= ACTIVE CUSTOMERS % =================

                lblActiveCust.Text =
                    lblActiveCustomerNo.Text + " active users";

                




                // LOAD CHARTS
                LoadWalletChart();
                LoadFeedbackChart();
           }

           catch (Exception ex)
           {
                MessageBox.Show(
                    "Unable to load dashboard.\n"
                    + ex.Message,
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
           }
        }


        
            
        

        private void lblWelcomeManger_Click(object sender, EventArgs e)
        {

        }

        private void panelCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDasboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "You are already in Dashboard.",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void chartFeedback_Click(object sender, EventArgs e)
        {

        }
    }
}
