using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace assignment
{
    public class SalesRepository
    {
        private DatabaseHelper _db;

        public SalesRepository()
        {
            _db = new DatabaseHelper();
        }

        public DataTable GetSalesReport(int? month, int? year, string category)
        {
            string query = @"
        SELECT 
            o.OrderID,
            o.OrderDateTime,
            o.TotalAmount,
            o.Status,
            m.Category,
            SUM(oi.Quantity) AS TotalItemsSold,
            SUM(oi.Subtotal) AS ItemRevenue
        FROM Orders o
        INNER JOIN OrderItems oi ON o.OrderID = oi.OrderID
        INNER JOIN Menu_Table m ON oi.MenuID = m.MenuID
        WHERE (@Month IS NULL OR MONTH(o.OrderDateTime) = @Month)
          AND (@Year  IS NULL OR YEAR(o.OrderDateTime)  = @Year)
          AND (@Category IS NULL OR m.Category = @Category)
        GROUP BY o.OrderID, o.OrderDateTime, o.TotalAmount, o.Status, m.Category
        ORDER BY o.OrderDateTime DESC";

            SqlParameter[] parameters = {
        new SqlParameter("@Month",    SqlDbType.Int)          { Value = month    .HasValue ? (object)month.Value    : DBNull.Value },
        new SqlParameter("@Year",     SqlDbType.Int)          { Value = year     .HasValue ? (object)year.Value     : DBNull.Value },
        new SqlParameter("@Category", SqlDbType.VarChar, 50)  { Value = category != null   ? (object)category       : DBNull.Value }
    };

            return _db.ExecuteQuery(query, parameters);
        }

        public DataTable GetSalesSummary(int? month, int? year, string category)
        {
            string query = @"
        SELECT
            COUNT(DISTINCT o.OrderID)   AS TotalOrders,
            SUM(oi.Subtotal)            AS TotalRevenue,
            SUM(oi.Quantity)            AS TotalItemsSold
        FROM Orders o
        INNER JOIN OrderItems oi ON o.OrderID = oi.OrderID
        INNER JOIN Menu_Table m  ON oi.MenuID  = m.MenuID
        WHERE (@Month IS NULL OR MONTH(o.OrderDateTime) = @Month)
          AND (@Year  IS NULL OR YEAR(o.OrderDateTime)  = @Year)
          AND (@Category IS NULL OR m.Category = @Category)";

            SqlParameter[] parameters = {
        new SqlParameter("@Month",    SqlDbType.Int)          { Value = month    .HasValue ? (object)month.Value    : DBNull.Value },
        new SqlParameter("@Year",     SqlDbType.Int)          { Value = year     .HasValue ? (object)year.Value     : DBNull.Value },
        new SqlParameter("@Category", SqlDbType.VarChar, 50)  { Value = category != null   ? (object)category       : DBNull.Value }
    };

            return _db.ExecuteQuery(query, parameters);
        }
    


    public DataTable GetCategories()
        {
            return _db.ExecuteQuery("SELECT DISTINCT Category FROM Menu_Table ORDER BY Category");
        }
    }
}
