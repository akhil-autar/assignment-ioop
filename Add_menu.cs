using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CHEF
{
    public partial class Add_menu : Form
    {
        private int loggedInChefID; //storing logged-in chefID
        private byte[] menuImage; // storing image bytes

        MenuService menuService = new MenuService();//creating a menuService object

        public Add_menu(int chefID)
        {
            InitializeComponent();
            loggedInChefID = chefID;// storing chefID
         
        }

        private void Add_menu_Load(object sender, EventArgs e)
        {

            // Getting chef main category
            string chefCategory =
                ShiftHelper.GetChefShift(loggedInChefID);
            // Adding chef category
            cmbCategory.Items.Add(chefCategory);
            // Adding shared categories
            cmbCategory.Items.Add("Snacks");
            cmbCategory.Items.Add("Drinks");
            // Preventing typing
            cmbCategory.DropDownStyle =ComboBoxStyle.DropDownList;
        }
        private void btnUpload_Click(object sender, EventArgs e) //Method for uploading picture
        {
            OpenFileDialog dialog = new OpenFileDialog(); // Openning file dialog

            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";  //Image filtering

            if (dialog.ShowDialog() == DialogResult.OK)// If image selected
            {
                picBoxAdd.Image = Image.FromFile(dialog.FileName); //Displaying image
                menuImage = File.ReadAllBytes(dialog.FileName); //Converting image to byte[]
            }
            ValidateForm();
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
            manage_Menu.ShowDialog();
            this.Close();
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

        private void ValidateItemName()
        {
            if (tbxItemName.Text.Trim() == "")
            {
                lblNameError.Text = "Item name cannot be empty.";
                lblNameError.Visible = true;
            }
            else
            {
                lblNameError.Visible = false;
            }
        }

        private void ValidateDescription()
        {
            if (tbxItemDescription.Text.Trim() == "")
            {
                lblDescriptionError.Text ="Item description cannot be empty.";

                lblDescriptionError.Visible = true;
            }
            else
            {
                lblDescriptionError.Visible = false;
            }
        }

        private void ValidatePrice()
        {
            if (numPrice.Value <= 0)
            {
                lblPriceError.Text ="Price must be greater than RM0.";

                lblPriceError.Visible = true;
            }
            else
            {
                lblPriceError.Visible = false;
            }
        }

        private void ValidateImage()
        {
            if (menuImage == null)
            {
                lblPicError.Text =
                    "Please upload menu image.";

                lblPicError.Visible = true;
            }
            else
            {
                lblPicError.Visible = false;
            }
        }

        private void ValidateCategory()
        {
            if (cmbCategory.SelectedIndex == -1)
            {
                lblCategoryError.Text = "Please select item category.";

                lblCategoryError.Visible = true;
            }
            else
            {
                lblCategoryError.Visible = false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e) 
        {
            ValidateForm();
            // Final validation check
            if (!ValidateForm())
                return;

            // Create menu object
            Menu menu = new Menu()
            {
                MenuName =tbxItemName.Text.Trim(),

                Description=tbxItemDescription.Text.Trim(),

                Category =cmbCategory.Text,

                Price =numPrice.Value,

                MenuPic =menuImage,

                ChefID =loggedInChefID,

                Available =chbAvailability.Checked,

                AvailableFrom =dtpFrom.Value.TimeOfDay,

                AvailableUntil=dtpUntil.Value.TimeOfDay
            };

            // Save menu
            menuService.AddMenu(menu);

            // Success message
            MessageBox.Show(
                "Menu item added successfully."
            );

            // Clear form
            ClearForm();  
        }
        private void ClearForm()// Method to reset form
        {
            tbxItemName.Clear();

            tbxItemDescription.Clear();

            cmbCategory.SelectedIndex = -1;

            numPrice.Value = 0;

            picBoxAdd.Image = null;

            menuImage = null;

            btnSave.Enabled = false;
        }
        private bool ValidateForm()
        {
            ValidateItemName();

            ValidateDescription();

            ValidateCategory();

            ValidatePrice();

            ValidateImage();

            return
                !lblNameError.Visible &&!lblDescriptionError.Visible &&!lblCategoryError.Visible && !lblPriceError.Visible && !lblPicError.Visible;
        }
        private void btnCancel_Click(object sender, EventArgs e)
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
            manage_Menu.ShowDialog();
            this.Close();
        }

        private void tbxItemName_Leave(object sender, EventArgs e)
        {
            ValidateItemName();
        }

        private void tbxItemDescription_Leave(object sender, EventArgs e)
        {
            ValidateDescription();  
        }

        private void cmbCategory_Leave(object sender, EventArgs e)
        {
            ValidateCategory();
        }

        private void numPrice_Leave(object sender, EventArgs e)
        {
            ValidatePrice();
        }
    }

}
