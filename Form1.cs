using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void OpenForm(Form form)
        {
            panelMain.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelMain.Controls.Add(form);

            form.Show();
        }


        private void panelDashboard_MouseEnter(object sender, EventArgs e)
        {
            panelDashboard.BackColor = Color.FromArgb(50, 150, 100);
        }

        private void panelDashboard_MouseLeave(object sender, EventArgs e)
        {
            panelDashboard.BackColor = Color.FromArgb(30, 30, 47);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelMenu_MouseEnter(object sender, EventArgs e)
        {
            panelDashboard.BackColor = Color.FromArgb(50, 150, 100);
        }

        private void panelMenu_MouseLeave(object sender, EventArgs e)
        {
            panelDashboard.BackColor = Color.FromArgb(30, 30, 47);
        }

        private void panelOrders_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelOrders_MouseEnter(object sender, EventArgs e)
        {
            panelDashboard.BackColor = Color.FromArgb(50, 150, 100);
        }

        private void panelOrders_MouseLeave(object sender, EventArgs e)
        {
            panelDashboard.BackColor = Color.FromArgb(30, 30, 47);
        }

        private void panelProfile_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelProfile_MouseEnter(object sender, EventArgs e)
        {
            panelDashboard.BackColor = Color.FromArgb(50, 150, 100);
        }

        private void panelProfile_MouseLeave(object sender, EventArgs e)
        {
            panelDashboard.BackColor = Color.FromArgb(30, 30, 47);
        }

        private void panelFeedback_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelFeedback_MouseEnter(object sender, EventArgs e)
        {
            panelDashboard.BackColor = Color.FromArgb(50, 150, 100);
        }

        private void panelFeedback_MouseLeave(object sender, EventArgs e)
        {
            panelDashboard.BackColor = Color.FromArgb(30, 30, 47);
        }

        private void panelLogout_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelLogout_MouseEnter(object sender, EventArgs e)
        {
            panelDashboard.BackColor = Color.FromArgb(50, 150, 100);
        }

        private void panelLogout_MouseLeave(object sender, EventArgs e)
        {
            panelDashboard.BackColor = Color.FromArgb(30, 30, 47);
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        { 
            dgvOrders.Rows.Add("Burger", "2", "RM 15", "Completed");
            dgvOrders.Rows.Add("Pizza", "1", "RM 20", "In Progress");
            dgvOrders.Rows.Add("Pasta", "3", "RM 25", "Completed");

        }
        
        
        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvOrders.Columns[e.ColumnIndex].Name == "colStatus")
            {
                if (e.Value.ToString() == "Completed")
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                }
                else if (e.Value.ToString() == "In Progress")
                {
                    e.CellStyle.BackColor = Color.LightSalmon;
                }
            }
        }

        private void panelMenu_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            OpenForm(new BrowseMenuFinal());
        }

        private void panelOrders_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            OpenForm(new MyOrders());
        }

        private void panelProfile_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            OpenForm(new Profile());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            OpenForm(new OrderHistory());
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            OpenForm(new Feedback());
        }

        private void panelDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDashboard_Click(object sender, EventArgs e)
        {
            
            
        }

        

        private void panelLogout_Cick(object sender, EventArgs e)
        
        {
            Application.Exit();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            Profile p = new Profile();

            panelMain.Controls.Add(p);

            p.Show();
        }

        private void labelNotification_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No new notifications.");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            MessageBox.Show("Search feature coming soon.");
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search feature coming soon.");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

        

