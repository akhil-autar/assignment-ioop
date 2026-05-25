using assignment.Helpers;
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
using System.Windows.Forms.DataVisualization.Charting;


namespace CHEF
{
    public partial class Chef_Dashboard : Form
    {   
        //Service class to handle order-related database operations
        OrderService orderService = new OrderService();
        MenuService menuService = new MenuService();

        private int loggedInChefID; //store logged-in chefID
        public Chef_Dashboard()
        {
            InitializeComponent();
            loggedInChefID = SessionManager.CurrentUser.Id;
        }
        private void ChefDashboard_Load(object sender, EventArgs e)
        {
            // Logged in chef ID
            int chefID = loggedInChefID;

            // Display chef name
            lblChefName.Text = SessionManager.CurrentUser.Username;

            //Display chef name in profile
            lblName.Text = SessionManager.CurrentUser.Username;

            // Display chef shift
            lblCatshift.Text =ShiftHelper.GetChefShift(chefID);

            // Display shift timing
            lblShiftTime.Text =
                ShiftHelper.GetChefShiftTime(chefID);

            LoadCategories();
            LoadTopDishes();
            LoadOrderStatusChart(); 
        }

        //Method to load top dishes into Pie chart
        private void LoadTopDishes()
        {
            // Clearing previous data
            chartDish.Series.Clear();

            // Creating new series for pie chart
            Series series = new Series();
            series.Name = "Top Dishes";
            series.ChartType = SeriesChartType.Pie;

            // Logged in chef ID
            int chefID =loggedInChefID;

            // Fetching chef-specific dishes
            DataTable dataTable =orderService.GetChefTopDishes(chefID);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                string dishName = dataRow["MenuName"].ToString();
                int quantity = Convert.ToInt32(dataRow["TotalOrdered"]);

                // Add data point
                series.Points.AddXY(dishName, quantity);
                series.IsValueShownAsLabel = true; // show numbers
                series.Label = "#PERCENT";         // show %
                series.LegendText = "#VALX";       // show dish name
                series["PieLabelStyle"] = "Outside";   // move labels outside
                series["PieLineColor"] = "Black";      // connector lines
                series.IsValueShownAsLabel = true;
                series.Label = "#PERCENT";             // cleaner display
            }

            // Add series to chart
            chartDish.Series.Add(series);
        }

        // Method to load order status chart
        private void LoadOrderStatusChart()
        {
            // Clear previous chart data
            chartOrderStatus.Series.Clear();

            // Logged in chef ID
            int chefID =loggedInChefID;

            // Creatinb new series
            Series series =new Series();

            series.Name ="Order Status";

            // Getting order counts
            int pending =orderService.GetChefOrderCount(chefID,"Pending");

            int inProgress =orderService.GetChefOrderCount(chefID,"In Progress");

            int completed =orderService.GetChefOrderCount( chefID, "Completed");

            int cancelled =orderService.GetChefOrderCount( chefID,"Cancelled");

            // Adding chart points
            series.Points.AddXY("Pending",pending);

            series.Points.AddXY("In Progress",inProgress);

            series.Points.AddXY("Completed",completed);

            series.Points.AddXY("Cancelled",cancelled);

            // Showing values on bars
            series.IsValueShownAsLabel =true;

            // Adding series to chart
            chartOrderStatus.Series.Add(series);
        }
        // Method to load categories
        private void LoadCategories()
        {
            // Logged in chef ID
            int chefID = loggedInChefID;
            // Gettingg chef main category
            string category =
                ShiftHelper.GetChefShift(chefID);
            // Displaying category name
            lblCat1.Text =category;
            // Displaying item counts
            lblItemCat1.Text =menuService.GetMenuCountByCategory(category) + " Items";
            lblItemCat2.Text= menuService.GetMenuCountByCategory("Snacks") + " Items";
            lblItemCat3.Text =menuService.GetMenuCountByCategory("Drinks") + " Items";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Manage_Menu manage_Menu = new Manage_Menu();
            if (this.WindowState ==FormWindowState.Maximized)
            {
                manage_Menu.WindowState =FormWindowState.Maximized;
            }
            else
            {
                manage_Menu.WindowState =FormWindowState.Normal;
            }
            manage_Menu.ShowDialog();
            this.Close();

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Manage_Orders manage_Orders = new Manage_Orders();
            if (this.WindowState == FormWindowState.Maximized)
            {
                manage_Orders.WindowState = FormWindowState.Maximized;
            }
            else
            {
                manage_Orders.WindowState = FormWindowState.Normal;
            }
            manage_Orders.ShowDialog();
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Display current date and time
            lblDateTime.Text =DateTime.Now.ToString("dddd, dd MMMM yyyy | hh:mm tt");
        }
    }
    }

