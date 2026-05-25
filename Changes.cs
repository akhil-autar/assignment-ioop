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
    public partial class Changes : Form
    {
        private Menu currentMenu;
        private MenuService menuService =new MenuService();
        public Changes(Menu menu)
        {
            InitializeComponent();
            currentMenu = menu;

        }

        private void Changes_Load(object sender, EventArgs e)
        {
            //Displaying updated details
            lblNameChange.Text =currentMenu.MenuName;
            lblDescriptionChange.Text = currentMenu.Description;
            lblCategoryChange.Text =currentMenu.Category;
            lblPriceChange.Text ="RM " + currentMenu.Price;
            lblStatusChange.Text =currentMenu.Available? "Available": "Not Available";
            lblFromChange.Text =currentMenu.AvailableFrom.ToString(@"hh\:mm");
            lblUntilChange.Text =currentMenu.AvailableUntil.ToString(@"hh\:mm");

            //Displaying image
            if (currentMenu.MenuPic != null)
            {
                using (MemoryStream ms =new MemoryStream(currentMenu.MenuPic))
                {
                     PicChange.Image=Image.FromStream(ms);
                }
            }
        }

        public bool ChangesSaved//Method to get saving status
        {
            get;
            private set;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Updating database
            menuService.UpdateMenu(currentMenu);

            ChangesSaved = true;
            //Success message
            MessageBox.Show("Changes applied successfully.");

            this.Close();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            // Closing preview form
            this.Close();

        }
    }
}
