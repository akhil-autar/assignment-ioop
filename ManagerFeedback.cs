using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac
{
    public partial class ManagerFeedback : Form
    {
        FeedbackClass feedback =
    new FeedbackClass();
       
        int selectedFeedbackID = 0;
        public ManagerFeedback()
        {
            InitializeComponent();
        }

        private void LoadFeedbackStatistics()
        {

            int total =
                feedback.GetTotalFeedback();

            int positive =
                feedback.GetPositiveFeedback();

            int negative =
                feedback.GetNegativeFeedback();

            int neutral =
                total - positive - negative;




            lblTtlFb.Text =
                total.ToString();

            lblPositiveNo.Text =
                positive.ToString();

            lblNegativeNo.Text =
                negative.ToString();

            lblNeutralNo.Text =
                neutral.ToString();




            if (total > 0)
            {
                lblPositivePercent.Text =
                    ((positive * 100.0) / total)
                    .ToString("0") + "%";

                lblNegativePercent.Text =
                    ((negative * 100.0) / total)
                    .ToString("0") + "%";

                lblNeutralPercent.Text =
                    ((neutral * 100.0) / total)
                    .ToString("0") + "%";
            }
        }
        private void LoadFeedbackDetails()
        {
            DataTable dt =
                feedback.GetFeedbackDetails(
                selectedFeedbackID);

            if (dt.Rows.Count > 0)
            {
                lblFbName.Text =
                    dt.Rows[0]["Username"]
                    .ToString();

                lblFb.Text =
                    dt.Rows[0]["Message"]
                    .ToString();

                txtResponse.Text =
                    dt.Rows[0]["Response"]
                    .ToString();
            }
        }




        private void Feedback_Load(object sender, EventArgs e)
        {
            LoadFeedbacks();
            LoadCustomers();

            LoadFeedbackStatistics();
            
        }


        private void LoadFeedbacks()
        {
          dgvFeedback.DataSource =
                feedback.GetFeedbacks();
        }



        
        
        
        private void LoadCustomers()
        {


            DataTable dt =
                feedback.GetCustomers();

            cmbCustomer.Items.Clear();

            cmbCustomer.Items.Add(
                "All Customers");

            foreach (DataRow row in dt.Rows)
            {
                cmbCustomer.Items.Add(
                    row["Username"].ToString());
            }

            cmbCustomer.SelectedIndex = 0;
        }

        
        



        
           
        
        

        

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void btnRespond_Click(object sender, EventArgs e)
        {

            try
            {
                // CHECK FEEDBACK SELECTION
                if (selectedFeedbackID == 0)
                {
                    MessageBox.Show(
                        "Please select feedback.");

                    return;
                }




                // SEND RESPONSE
                feedback.RespondFeedback(
                    selectedFeedbackID,
                    txtResponse.Text);




                MessageBox.Show(
                    "Response submitted successfully!");




                // REFRESH TABLE
                LoadFeedbacks();




                // CLEAR RESPONSE BOX
                txtResponse.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        
          

            

        private void btnFilterFb_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName =
                    cmbCustomer.Text;

                DataTable dt =
                    feedback.FilterFeedback(
                        customerName,
                        dtpFromDate.Value.Date,
                        dtpToDate.Value.Date);

                dgvFeedback.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show(
                        "Feedback found !");
                }
                else
                {
                    MessageBox.Show(
                        "No feedback found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        
        

        
        

        private void btnResetFb_Click(object sender, EventArgs e)
        {

            try
            {
                // RESET CUSTOMER
                cmbCustomer.SelectedIndex = 0;




                // RESET DATES
                dtpFromDate.Value =
                    DateTime.Now;

                dtpToDate.Value =
                    DateTime.Now;




                // RELOAD ALL FEEDBACK
                LoadFeedbacks();

                // CLEAR FEEDBACK DETAILS
                lblFbName.Text = "Name";

                lblFbDetailsDate.Text = "-";

                lblFbDetail.Text = "Feedback";

                lblFeedbackTypePN.Text = "-";

                txtResponse.Clear();

                selectedFeedbackID = 0;




                MessageBox.Show(
                    "Filters reset successfully!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvFeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void btnClear_Click(object sender, EventArgs e)
        {


         
            txtResponse.Clear();

            MessageBox.Show(
                "Response box cleared successfully!",
                "Clear",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        
        }

        private void dgvFeedback_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
        
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row =
                        dgvFeedback.Rows[e.RowIndex];



                    // Save selected feedback ID
                    selectedFeedbackID =
                        Convert.ToInt32(
                            row.Cells["FeedbackID"].Value);



                    // Customer Name
                    lblFbName.Text =
                        feedback.GetCustomerName(
                            selectedFeedbackID);




                    // Date
                    lblFbDetailsDate.Text =
                        Convert.ToDateTime(
                            row.Cells["Date"].Value)
                        .ToString("dd MMM yyyy");



                    // Feedback Message
                    lblFbDetail.Text =
                        row.Cells["Message"]
                        .Value.ToString();



                    // Response
                    if (row.Cells["Response"].Value
                        != DBNull.Value)
                    {
                        txtResponse.Text =
                            row.Cells["Response"]
                            .Value.ToString();
                    }
                    else
                    {
                        txtResponse.Clear();
                    }



                    // Feedback Type
                    string message =
                        row.Cells["Message"]
                        .Value.ToString()
                        .ToLower();

                    if (message.Contains("good") ||
                        message.Contains("great") ||
                        message.Contains("excellent") ||
                        message.Contains("delicious") ||
                        message.Contains("yummy") ||
                        message.Contains("nice") ||
                        message.Contains("love") ||
                        message.Contains("amazing"))
                    {
                        lblFeedbackTypePN.Text =
                            "Positive";
                    }
                    else if (
                        message.Contains("bad") ||
                        message.Contains("poor") ||
                        message.Contains("worst") ||
                        message.Contains("hate") ||
                        message.Contains("awful"))
                    {
                        lblFeedbackTypePN.Text =
                            "Negative";
                    }
                    else
                    {
                        lblFeedbackTypePN.Text =
                            "Neutral";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load feedback details.\n"
                    + ex.Message,
                    "Selection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
       
        

        private void btnDasboard_Click(object sender, EventArgs e)
        {
         
            Managerdashboard dashboard = new Managerdashboard();
            dashboard.ShowDialog();
            this.Close();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
         
            MessageBox.Show(
                "You are already in Manage Feedback.",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
        
         
                WalletReport wallet = new WalletReport();
                wallet.ShowDialog();
                this.Close();

           
        
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
                Application.Exit();
            }
        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void lblNeutralNo_Click(object sender, EventArgs e)
        {

        }
    }   
    
    
}
