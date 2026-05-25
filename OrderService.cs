using assignment;
using CHEF;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

public class OrderService
{   //creating an instance of DatabaseHelper to use its methods for database operations
    private DatabaseHelper databaseHelper = new DatabaseHelper();

    //Method to get active orders from the database
    public DataTable GetActiveOrders()
    {
        string query = @"
        SELECT 
            Orders.OrderID,
            Menu_Table.MenuName,
            OrderItems.Quantity,
            ISNULL(OrderItems.SpecialRequest, '-') AS Remarks,
            Orders.Status
        FROM Orders
        INNER JOIN OrderItems 
            ON Orders.OrderID = OrderItems.OrderID
        INNER JOIN Menu_Table
            ON OrderItems.MenuID = Menu_Table.MenuID
        WHERE Orders.Status IN ('Pending','In Progress')
        ORDER BY Orders.OrderID";

        return databaseHelper.ExecuteQuery(query);
    }

    // Method to get chef kitchen activity
    public DataTable GetChefKitchenActivity(int chefID)
    {
        // SQL query
        string query = @"
    SELECT DISTINCT TOP 3
        OrderID,
        Status,
        StatusTime

    FROM Orders

    WHERE
        CAST(OrderDateTime AS TIME)
        BETWEEN @startTime AND @endTime

    ORDER BY StatusTime DESC";

        // SQL parameters
        SqlParameter[] parameters =
        {
        new SqlParameter(
            "@startTime",
            ShiftHelper.GetShiftStartTime(
                chefID
            )
        ),

        new SqlParameter(
            "@endTime",
            ShiftHelper.GetShiftEndTime(
                chefID
            )
        )
    };

        // Return activity
        return databaseHelper.ExecuteQuery(
            query,
            parameters
        );
    }

    // Method to get chef-specific top dishes
    public DataTable GetChefTopDishes(int chefID)
    {
        // Get chef category
        string category =ShiftHelper.GetChefShift(chefID);

        // SQL query
        string query = @"SELECT TOP 5
                         Menu_Table.MenuName,
                         SUM(OrderItems.Quantity)
                         AS TotalOrdered

                         FROM OrderItems

                         INNER JOIN Menu_Table
                         ON OrderItems.MenuID =
                         Menu_Table.MenuID

                         WHERE
                         (
                            Menu_Table.Category = @category
                            OR Menu_Table.Category = 'Snacks'
                            OR Menu_Table.Category = 'Drinks'
                         )

                            GROUP BY Menu_Table.MenuName

                            ORDER BY TotalOrdered DESC";

        // SQL parameters
        SqlParameter[] parameters =
        {
                new SqlParameter("@category",category)
        };

            // Return top dishes
             return databaseHelper.ExecuteQuery(query,parameters);
    }


    //Method to get all orders
    public DataTable GetAllOrders()
    {
        string query = @"
        SELECT 
            Orders.OrderID,
            Orders.Status,
            Menu_Table.MenuName,
            OrderItems.Quantity,
            ISNULL(OrderItems.SpecialRequest, '-') AS SpecialRequest
        FROM Orders
        INNER JOIN OrderItems 
            ON Orders.OrderID = OrderItems.OrderID
        INNER JOIN Menu_Table 
            ON OrderItems.MenuID = Menu_Table.MenuID
        ORDER BY Orders.OrderID DESC";

        return databaseHelper.ExecuteQuery(query);
    }

    //Method to count orders by status
    public int GetOrderCount(string status)
    {
        string query = "SELECT COUNT(*) FROM Orders WHERE Status = @status";

        SqlParameter[] parameters = {
            new SqlParameter("@status", status)
        };

        return Convert.ToInt32(databaseHelper.Executescalar(query, parameters));
    }

    //Method to update order status
    public void UpdateOrderStatus(int orderId, string status)
    {
        string query = @"
        UPDATE Orders
        SET Status = @status, StatusTime = GETDATE()
        WHERE OrderID = @id";

        SqlParameter[] parameters = {
            new SqlParameter("@status", status),
            new SqlParameter("@id", orderId)
        };

        databaseHelper.ExecuteNonQuery(query, parameters);
    }

    //Method to get Latest Update Time
    public DateTime GetLatestUpdateTime()
    {
        string query = "SELECT MAX(StatusTime) FROM Orders";

        object result = databaseHelper.Executescalar(query);

        if (result != DBNull.Value)
            return Convert.ToDateTime(result);

        return DateTime.MinValue;
    }

    // Method to get orders based on chef access
    public DataTable GetChefOrders(int chefID)
    {
        string query = @"
               SELECT 
                Orders.OrderID,
                Menu_Table.MenuName,
                Menu_Table.Category,
                OrderItems.Quantity,
                ISNULL(OrderItems.SpecialRequest, '-') AS SpecialRequest,
                Orders.Status
                FROM Orders
             INNER JOIN OrderItems ON Orders.OrderID = OrderItems.OrderID
             INNER JOIN Menu_Table ON OrderItems.MenuID = Menu_Table.MenuID
             WHERE Orders.Status IN ('Pending','In Progress','Completed') ORDER BY Orders.OrderID DESC";

        DataTable dt =databaseHelper.ExecuteQuery(query);

        // Creatinb filtered table
        DataTable filteredTable =dt.Clone();

        // Filtering rows based on chef access
        foreach (DataRow row in dt.Rows)
        {
            string category =row["Category"].ToString();

            // Using ShiftHelper
            bool canAccess =ShiftHelper.CanChefAccessCategory(chefID,category);

           // Adding allowed rows only
            if (canAccess)
            {
                filteredTable.ImportRow(row);
            }
        }

        return filteredTable;
    }

    // Method to count chef-specific orders
    public int GetChefOrderCount(int chefID,string status)
    {
        // Getting chef-visible orders
        DataTable dt =GetChefOrders(chefID);

        // Counting matching status
        int count =dt.AsEnumerable().Count(row =>row["Status"].ToString().Trim().Equals( status,StringComparison.OrdinalIgnoreCase));
        return count;
    }
}

