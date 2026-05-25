using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using assignment;

namespace prac
{
    internal class WalletReportClass
    {
        DatabaseHelper db = new DatabaseHelper();




        // TOTAL TOPUP
        public decimal GetTotalTopUp()
        {
            object result =
                db.Executescalar(
                "SELECT ISNULL(SUM(Amount),0) " +
                "FROM WalletTransactions " +
                "WHERE Type='Top-Up'");

            return Convert.ToDecimal(result);
        }




        // TOTAL PAYMENT / USAGE
        public decimal GetTotalUsage()
        {
            object result =
                db.Executescalar(
                "SELECT ISNULL(SUM(Amount),0) " +
                "FROM WalletTransactions " +
                "WHERE Type='Payment'");

            return Convert.ToDecimal(result);
        }




        // TOTAL REFUND
        public decimal GetTotalRefund()
        {
            object result =
                db.Executescalar(
                "SELECT ISNULL(SUM(Amount),0) " +
                "FROM WalletTransactions " +
                "WHERE Type='Refund'");

            return Convert.ToDecimal(result);
        }




        // TOTAL TRANSACTIONS
        public int GetTotalTransactions()
        {
            object result =
                db.Executescalar(
                "SELECT COUNT(*) FROM WalletTransactions");

            return Convert.ToInt32(result);
        }




        // NET BALANCE
        public decimal GetNetBalance()
        {
            decimal topup = GetTotalTopUp();

            decimal usage = GetTotalUsage();

            decimal refund = GetTotalRefund();

            return (topup + refund) - usage;
        }




        // LOAD TABLE
        public DataTable GetTransactions()
        {
            string query =
                "SELECT * FROM WalletTransactions";

            return db.ExecuteQuery(query);
        }
        public DataTable GetCustomers()
        {

            string query =
                "SELECT Wallet.WalletID, Users.Username " +
                "FROM Wallet " +
                "INNER JOIN Users " +
                "ON Wallet.CustomerID = Users.UserID " +
                "WHERE Users.Role='Customer'";

            return db.ExecuteQuery(query);
        }

    }
      
        
    
}
