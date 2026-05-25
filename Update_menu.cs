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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CHEF
{

    public partial class Update_menu : Form
    {
        private int loggedInChefID; //storing logged-in chefID
        private int selectedMenuID;

        private byte[] menuImage;

        private MenuService menuService = new MenuService();
        public Update_menu(int menuID,int chefID)
        {
            InitializeComponent();
            selectedMenuID = menuID;
            loggedInChefID = chefID;    
        }

        private void Update_menu_Load(object sender, EventArgs e)
        {
            // Getting chef main category
            string chefCategory =
                ShiftHelper.GetChefShift(loggedInChefID);
            // Adding chef category
            cmbCategory.Items.Add(chefCategory);
            // Adding shared categories
            cmbCategory.Items.Add("Snacks");
            cmbCategory.Items.Add("Drinks");
            cmbCategory.DropDownStyle =ComboBoxStyle.DropDownList; //preventing user typing

            // Getting selected menu
            DataTable dt = menuService.GetMenuByID(selectedMenuID); 
            if (dt.Rows.Count == 0) // Stopping if no menu found
                return;
            DataRow row = dt.Rows[0];// Getting first row

            // Displaying old details
            lblOldName.Text =row["MenuName"].ToString();
            lblOldDesription.Text = row["Description"].ToString();
            lblOldCategory.Text =row["Category"].ToString();
            lblOldPrice.Text ="RM " + row["Price"].ToString();
            lblOldStatus.Text =Convert.ToBoolean( row["IsAvailable"])? "Available": "Not Available";
            lblOldFrom.Text =((TimeSpan)row["AvailableFrom"]).ToString(@"hh\:mm");
            lblOldUntil.Text =((TimeSpan)row["AvailableUntil"]).ToString(@"hh\:mm");

            // Filling input controls
            tbxItemName.Text =row["MenuName"].ToString();

            tbxItemDescription.Text = row["Description"].ToString();

            cmbCategory.Text =row["Category"].ToString();

            numPrice.Value =Convert.ToDecimal(row["Price"]);

            chbAvailability.Checked =Convert.ToBoolean(row["IsAvailable"]);

            dtpFrom.Value = DateTime.Today.Add((TimeSpan)row["AvailableFrom"]);

            dtpUntil.Value =DateTime.Today.Add((TimeSpan)row["AvailableUntil"]);

            // Loading old image
            if (row["MenuPic"] != DBNull.Value)
            {
               // Storing image bytes
                menuImage =(byte[])row["MenuPic"];

               // Converting byte[] to image
                 using (MemoryStream ms =new MemoryStream(menuImage))
                    {
                       // Old image display
                        picOld.Image =
                            Image.FromStream(ms);
                    }
            }
        

        }

        private void btnUploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog =new OpenFileDialog();

            dialog.Filter ="Image Files|*.jpg;*.jpeg;*.png";

            if (dialog.ShowDialog()== DialogResult.OK)
            {
                try
                {
                    // Storing NEW image only
                    menuImage =
                        File.ReadAllBytes(dialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image.\n"+ ex.Message
                    );
                }
            }
        }

        private void btnChanges_Click(object sender, EventArgs e)
        {
            // Create updated menu object
            Menu menu = new Menu()
            {
                MenuID = selectedMenuID,

                Description = tbxItemDescription.Text,

                MenuName = tbxItemName.Text,

                Category = cmbCategory.Text,

                Price = numPrice.Value,

                MenuPic = menuImage,

                Available = chbAvailability.Checked,

                AvailableFrom = dtpFrom.Value.TimeOfDay,

                AvailableUntil = dtpUntil.Value.TimeOfDay
            };

            // Opeingpreview form
            Changes changesForm =new Changes(menu);

            // Opening as popup
            changesForm.ShowDialog();

            // Returning to Manage_Menu
            if (changesForm.ChangesSaved)
            {
                this.Close();
            }

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
            this.Hide();
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
            this.Hide();

        }
    }
}
