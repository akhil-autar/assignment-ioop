using assignment;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CHEF
{
    public class MenuService
    {
        DatabaseHelper databaseHelper = new DatabaseHelper(); //Database helper to handle database queries


        //METHODS FOR MANAGE_MENU
        public DataTable GetMenusByChef(int chefID) //Method to retrieve menu items based on clogged-in chef
        {
            // SQL query
            string query = @"
            SELECT
                MenuID,
                MenuName,
                Description,
                Category,
                Price,
                MenuPic,
                ChefID,
                IsAvailable,
                AvailableFrom,
                AvailableUntil
            FROM Menu_Table
            WHERE ChefID = @ChefID
            OR Category IN('Snacks', 'Drinks')";

            // SQL parameters
            SqlParameter[] parameters =
            {
                new SqlParameter("@ChefID",chefID)
            };

            // Executing query
            return databaseHelper.ExecuteQuery(query, parameters);
        }

        public DataTable GetMenuByID(int menuID)// Method to retrieve menu by menuID  
        {
            // SQL query
            string query = @"
            SELECT *
            FROM Menu_Table
            WHERE MenuID = @MenuID";

            // SQL parameters
            SqlParameter[] parameters =
            {
                new SqlParameter("@MenuID",menuID)
            };

            // Executing query
            return databaseHelper.ExecuteQuery(query, parameters);

        }

        public void AddMenu(Menu menu) //Method to add menu item to database
        {
            // SQL query
            string query = @"
            INSERT INTO Menu_Table(MenuName,Description,Category,Price,MenuPic,ChefID,IsAvailable,AvailableFrom,AvailableUntil)
            VALUES(@MenuName,@Description,@Category,@Price,@MenuPic,@ChefID,@IsAvailable,@AvailableFrom,@AvailableUntil)";

            // SQL parameters
            SqlParameter[] parameters =
            {
               new SqlParameter("@MenuName",menu.MenuName),

               new SqlParameter("@Description", menu.Description),

               new SqlParameter("@Category",menu.Category),

               new SqlParameter("@Price",menu.Price),

               new SqlParameter("@MenuPic",menu.MenuPic),

               new SqlParameter("@ChefID",menu.ChefID),

               new SqlParameter("@IsAvailable",menu.Available),

               new SqlParameter("@AvailableFrom",menu.AvailableFrom),

               new SqlParameter("@AvailableUntil",menu.AvailableUntil)
            };

            // Execute query
            databaseHelper.ExecuteNonQuery(query, parameters);
        }

        public void DeleteMenu(int menuID)//Method to delete menu item from database
        {
            string query = @"
            DELETE FROM Menu_Table
            WHERE MenuID = @MenuID";

            SqlParameter[] parameters =
            {
              new SqlParameter("@MenuID",menuID)
            };

            databaseHelper.ExecuteNonQuery(query, parameters);
        }

        public void UpdateMenu(Menu menu)//Method to update menu item in database
        {
            string query = @"
            UPDATE Menu_Table
            SET
            MenuName = @MenuName,
            Description=@Description,
            Category = @Category,
            Price = @Price,
            MenuPic = @MenuPic,
            IsAvailable = @IsAvailable,
            AvailableFrom = @AvailableFrom,
            AvailableUntil = @AvailableUntil
            WHERE MenuID = @MenuID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MenuID",menu.MenuID),

                new SqlParameter("@Description", menu.Description),

                new SqlParameter("@MenuName",menu.MenuName),

                new SqlParameter("@Category",menu.Category),

                new SqlParameter("@Price",menu.Price),

                new SqlParameter("@MenuPic",menu.MenuPic),

                new SqlParameter("@IsAvailable",menu.Available),

                new SqlParameter("@AvailableFrom",menu.AvailableFrom),

                new SqlParameter("@AvailableUntil",menu.AvailableUntil)
            };

            databaseHelper.ExecuteNonQuery(query, parameters);
        }

        // Method to count menu items by category
        public int GetMenuCountByCategory(
            string category)
        {
            string query =@"SELECT COUNT(*)
                          FROM Menu_Table
                          WHERE Category = @category";

            SqlParameter[] parameters =
            {
                 new SqlParameter("@category",category)
    };
            return Convert.ToInt32(
                databaseHelper.Executescalar(query,parameters));
        }
    }
}
