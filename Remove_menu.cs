using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHEF
{
    public partial class Remove_menu : Form
    {
        private int loggedInChefID; //storing logged-in chefID
        private int selectedMenuID; //Store selected menu ID

        MenuService menuService = new MenuService(); //Creating menuService object
        public Remove_menu(int menuID, int chefID)
        {
            InitializeComponent();
            selectedMenuID = menuID;
            loggedInChefID = chefID;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {   //Asking for confirmation before removing menu item 
            DialogResult result = MessageBox.Show("Are you sure you want to remove this menu item?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)//If user clicks yes
            {
                menuService.DeleteMenu(selectedMenuID);// Call delete method in menuService to remove menu item from database
                MessageBox.Show("Menu item removed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();// Close the form after deletion
               
             
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();// Close the form without making any changes
        }


    }
}
