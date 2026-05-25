using assignment.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHEF
{
    public partial class Manage_Menu : Form
    {
        private int loggedInChefID; //store logged-in chefID

        private DataTable allMenus; //Store all menus in memory(Database loaded only once)

        private string currentCategory = "All Items"; // Store current category

        MenuService menuService = new MenuService(); //MenuService object

        public Manage_Menu() //Constructor
        {
            InitializeComponent();
            loggedInChefID =SessionManager.CurrentUser.Id; 


        }
        private void Manage_Menu_Load(object sender, EventArgs e) //Form Load
        {
            SetupDataGridView(); //Setting up data grid view structure
            StyleDataGridView(); //Applying styling to data grid view
            SetupSearchPlaceholder();//Setting up Search placeholder
            LoadMenu(); // Loading menu from database
           // Getting chef category
            string chefCategory =ShiftHelper.GetChefShift(loggedInChefID);
            // Updating category button text
            btnMainCat.Text =chefCategory;
            RefreshMenu(); //Display all menus
            SetActiveButton(btnAll); // Highlight All button

        }
        private void LoadMenu() //Loading menu from database
        {
            allMenus = menuService.GetMenusByChef(loggedInChefID);
                
            
        }
         
        private void DisplayMenus(DataTable dt) // Method to display menu
        {
            dgvMenu.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                AddMenuRow(row); 
            }
        }
        private void AddMenuRow(DataRow row) // Method to add single menu row
        {
            //Converting image

            Image menuImage = null; 
            if (row["MenuPic"] != DBNull.Value)
            {
                menuImage = ConvertToImage((byte[])row["MenuPic"]);
            }

            //Adding Row
            dgvMenu.Rows.Add(row["MenuID"].ToString(), menuImage, row["MenuName"].ToString(), row["Description"].ToString(),
                             row["Category"].ToString(), "RM " + row["Price"].ToString(),Convert.ToBoolean(row["IsAvailable"])? "Available"
                           : "Unavailable", "📝","🗑");
        }
        private Image ConvertToImage(byte[] img) // Converting Byte[] to image
        {
            using (MemoryStream ms = new MemoryStream(img))
            {
                return Image.FromStream(ms);
            }
        }
        private void FilterMenu(string category) // Filtering menu by category
        {
            currentCategory = category; //Storing selected category

            //Show All
            if (category == "All Items")
            {
                DisplayMenus(allMenus);

                return;
            }

            //Filtering using dataview
            DataView dv = allMenus.DefaultView;
            dv.RowFilter = $"Category = '{category}'";

            DataTable filteredTable = dv.ToTable(); //Converting DataView to DataTable

            DisplayMenus(filteredTable); //Displaying filtered menus
        }
        private void SearchMenu() //Searching menu
        {
            //Searching using textbox
            lblSearchResult.Visible = false; //Hiding label at first
            string searchText = tbxSearch.Text.Trim(); //getting searched text
            //validation for empty textbox
            if (searchText == "" || searchText == "Search menu item")
            {
                RefreshMenu();
                return;
            }

            //Searching using Dataview
            DataView dv = allMenus.DefaultView;
            dv.RowFilter =$"MenuName LIKE '%{searchText}%'";
            DataTable searchTable = dv.ToTable(); //Converting to DataTable

            //Searched Item not found
            if (searchTable.Rows.Count == 0)
            {
                dgvMenu.Rows.Clear();
                lblSearchResult.Text = "Menu item does not exist";
                lblSearchResult.Visible = true;
                return;
            }
            DisplayMenus(searchTable);//Displaying search results

        }
        private void RefreshMenu() //Refreshing menu
        {
            FilterMenu(currentCategory);
        }
        private void btnSearch_Click(object sender, EventArgs e) //Search button click
        {
            SearchMenu();
        }
        private void SetupSearchPlaceholder()//Search placehlder

        {
            tbxSearch.Text = "Search menu item";
            tbxSearch.ForeColor = Color.Gray;
        }
        private void tbxSearch_Enter(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "Search menu item")
            {
                tbxSearch.Text = "";
                tbxSearch.ForeColor = Color.Black;
            }
        } // Removing Placeholder
        private void tbxSearch_Leave(object sender, EventArgs e)//Restoring placeholder
        {
            if (string.IsNullOrWhiteSpace(tbxSearch.Text))
            {
                tbxSearch.Text = "Search menu item...";
                tbxSearch.ForeColor = Color.Gray;
            }
        }
        private void CategoryButton_Click(object sender, EventArgs e) //Category button click
        {
            Button clickedButton = (Button)sender; //Getting clicked button
            string category = clickedButton.Text; // Getting category from button text
            FilterMenu(category); //Filtering menu
            SetActiveButton(clickedButton);// Highlighting active button
        }
        private void SetActiveButton(Button activeButton)// Method to highlight active button
        {
            // List of all filter buttons
            Button[] buttons ={ btnAll,btnMainCat,btnSnacks,btnDrinks};

            // Resetting all buttons
            foreach (Button btn in buttons)
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.Black;
            }

            // Highlighting active button
            activeButton.BackColor =
                Color.FromArgb(107, 142, 35);

            activeButton.ForeColor = Color.White;
        }
        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <0) //Preventing header click
                return;

            int menuID = Convert.ToInt32(dgvMenu.Rows[e.RowIndex].Cells["colMenuID"].Value); //Getting Selected MenuID

            //Update Button
            if (e.ColumnIndex == dgvMenu.Columns["colUpdate"].Index)
            {
                //Call update form
                Update_menu Update_menu = new Update_menu(menuID,loggedInChefID);
                if (this.WindowState == FormWindowState.Maximized)
                {
                    Update_menu.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    Update_menu.WindowState = FormWindowState.Normal;
                }
                Update_menu.ShowDialog();
                LoadMenu(); //Reload database
                RefreshMenu();//Refresh UI

            }

            //Delete Button
            if (e.ColumnIndex == dgvMenu.Columns["colDelete"].Index)
            {
                //Call Remove form
                Remove_menu Remove_menu = new Remove_menu(menuID,loggedInChefID);
                Remove_menu.ShowDialog();
                LoadMenu(); //Reload database
                RefreshMenu();//Refresh UI

            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_menu add_menu = new Add_menu(loggedInChefID); //Call add_menu form
            if (this.WindowState == FormWindowState.Maximized)
            {
                add_menu.WindowState = FormWindowState.Maximized;
            }
            else
            {
                add_menu.WindowState = FormWindowState.Normal;
            }
            add_menu.ShowDialog();
            this.Close();
            LoadMenu(); //ReloadMenus
            RefreshMenu(); //Refresh UI
        }
        private void SetupDataGridView()//Method to set up dgv
        {
            dgvMenu.Columns.Clear();// Preventing duplicate columns

            dgvMenu.AdvancedCellBorderStyle.All =
                DataGridViewAdvancedCellBorderStyle.None;

            dgvMenu.GridColor =
                Color.FromArgb(230, 230, 230);


            DataGridViewTextBoxColumn colMenuID =
                new DataGridViewTextBoxColumn();

            colMenuID.Name = "colMenuID";

            colMenuID.Visible = false;

            dgvMenu.Columns.Add(colMenuID);

            //MENU IMAGE COLUMN
            DataGridViewImageColumn colMenuPic =
                new DataGridViewImageColumn();

            colMenuPic.Name = "colMenuPic";

            colMenuPic.HeaderText = "";

            colMenuPic.ImageLayout =DataGridViewImageCellLayout.Zoom;

            dgvMenu.Columns.Add(colMenuPic);


            //MENU NAME COLUMN
            dgvMenu.Columns.Add("colMenuName", "Item Name");

            //DESCRIPTIONCOLUMN
            dgvMenu.Columns.Add("colDescription", "Description");

            //CATEGORY COLUMN
            dgvMenu.Columns.Add("colCategory","Category");

            //PRICE COLUMN
            dgvMenu.Columns.Add( "colPrice","Price");

            //MENU NAME COLUMN
            dgvMenu.Columns.Add(
                "colAvailability", "Availability");

            //UPDATE BUTTON
            DataGridViewButtonColumn btnUpdate =new DataGridViewButtonColumn();

            btnUpdate.Name = "colUpdate";

            btnUpdate.HeaderText = "Update";

            btnUpdate.Text = "📝";

            btnUpdate.UseColumnTextForButtonValue = true;

            btnUpdate.FlatStyle = FlatStyle.Flat;

            dgvMenu.Columns.Add(btnUpdate);

            //DELETE BUTTON 
            DataGridViewButtonColumn btnDelete =new DataGridViewButtonColumn();

            btnDelete.Name = "colDelete";

            btnDelete.HeaderText = "Delete";

            btnDelete.Text = "🗑";

            btnDelete.UseColumnTextForButtonValue = true;

            btnDelete.FlatStyle = FlatStyle.Flat;

            dgvMenu.Columns.Add(btnDelete);
        }
        private void StyleDataGridView()
        {
            // ALTERNATING ROW COLORS
            dgvMenu.AlternatingRowsDefaultCellStyle.BackColor =Color.FromArgb(245, 248, 240);
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
            chef_Dashboard.ShowDialog();
            this.Close();


        }
        private void dgvMenu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // UPDATE BUTTON COLUMN
            if (dgvMenu.Columns[e.ColumnIndex].Name == "colUpdate")
            {
                DataGridViewCell cell =
                    dgvMenu.Rows[e.RowIndex].Cells[e.ColumnIndex];

                cell.Style.BackColor = Color.FromArgb(230,215,170);

                cell.Style.ForeColor = Color.FromArgb(90,70,20);

                cell.Style.SelectionBackColor =
                    Color.FromArgb(156,176,120);

                cell.Style.SelectionForeColor = Color.White;

              
            }

            // DELETE BUTTON COLUMN
            if (dgvMenu.Columns[e.ColumnIndex].Name == "colDelete")
            {
                DataGridViewCell cell =dgvMenu.Rows[e.RowIndex].Cells[e.ColumnIndex];

                cell.Style.BackColor = Color.FromArgb(235,200,200);

                cell.Style.ForeColor = Color.Maroon;

                cell.Style.SelectionBackColor =Color.FromArgb(215,170,170);

                cell.Style.SelectionForeColor = Color.White;
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            btnMenu.Enabled = false;
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
    }
}