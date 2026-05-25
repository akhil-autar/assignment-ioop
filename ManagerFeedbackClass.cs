using assignment;
using System;
using System.Data;
using System.Data.SqlClient;

namespace prac
{
    internal class ManagerFeedbackClass
    {
        DatabaseHelper db =
            new DatabaseHelper();




        // LOAD ALL FEEDBACK
        public DataTable GetFeedbacks()
        {
            string query =
                "SELECT * FROM Feedback";

            return db.ExecuteQuery(query);
        }
        public DataTable GetFeedbackDetails(
         int feedbackID)
        {
            string query =
                 @"SELECT Users.Username,
                 Feedback.Message,
                 Feedback.Response,
                 Feedback.Date
                 FROM Feedback
                 INNER JOIN Orders
                 ON Feedback.OrderID = Orders.OrderID
                 INNER JOIN Users
                 ON Orders.CustomerID = Users.UserID
                WHERE FeedbackID=@FeedbackID";

            SqlParameter[] parameters =
            {
                new SqlParameter(
                "@FeedbackID",
                feedbackID)
            };

            return db.ExecuteQuery(
                query,
                parameters);
        }




        // LOAD CUSTOMERS
        public DataTable GetCustomers()
        {
         
            string query =
                @"SELECT DISTINCT
                Users.Username
                FROM Feedback
                INNER JOIN Orders
                ON Feedback.OrderID = Orders.OrderID
                INNER JOIN Users
                ON Orders.CustomerID = Users.UserID
                 WHERE Users.Role='Customer'";

            return db.ExecuteQuery(query);
        }
        public string GetCustomerName(
    int feedbackID)
        {
            string query =
            @"SELECT Users.Username
      FROM Feedback
      INNER JOIN Orders
      ON Feedback.OrderID = Orders.OrderID
      INNER JOIN Users
      ON Orders.CustomerID = Users.UserID
      WHERE FeedbackID=@FeedbackID";

            SqlParameter[] parameters =
            {
        new SqlParameter(
            "@FeedbackID",
            feedbackID)
    };

            DataTable dt =
                db.ExecuteQuery(
                    query,
                    parameters);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Username"]
                    .ToString();
            }

            return "";
        }





        // TOTAL FEEDBACK
        public int GetTotalFeedback()
        {
            object result =
                db.Executescalar(
                "SELECT COUNT(*) FROM Feedback");

            return Convert.ToInt32(result);
        }




        // POSITIVE FEEDBACK COUNT
        public int GetPositiveFeedback()
        {
            object result =
                db.Executescalar(
                @"SELECT COUNT(*) FROM Feedback
                WHERE Message LIKE '%good%'"
               );

            return Convert.ToInt32(result);
        }




        // NEGATIVE FEEDBACK COUNT
        public int GetNegativeFeedback()
        {
            object result =
                db.Executescalar(
                @"SELECT COUNT(*) FROM Feedback
                WHERE Message LIKE '%bad%'
                ");

            return Convert.ToInt32(result);
        }
        



        // RESPOND TO FEEDBACK
        public void RespondFeedback(
            int feedbackID,
            string response)
        {
            string query =
                @"UPDATE Feedback
                SET Response=@Response,
                    Status='Responded'
                WHERE FeedbackID=@FeedbackID";

            SqlParameter[] parameters =
            {
                new SqlParameter(
                    "@Response",
                    response),

                new SqlParameter(
                    "@FeedbackID",
                    feedbackID)
            };

            db.ExecuteNonQuery(
                query,
                parameters);
        }




        // FILTER FEEDBACK
        public DataTable FilterFeedback(
            string customerID,
            DateTime fromDate,
            DateTime toDate)
        {
            string query = "";

            SqlParameter[] parameters;




            // ALL CUSTOMERS
            if (customerID == "All Customers")
            {
                query =
                    @"SELECT * FROM Feedback
                    WHERE CAST(Date AS DATE)
                    BETWEEN @FromDate
                    AND @ToDate";

                parameters = new SqlParameter[]
                {
                    new SqlParameter(
                        "@FromDate",
                        fromDate),

                    new SqlParameter(
                        "@ToDate",
                        toDate)
                };
            }




            // SPECIFIC CUSTOMER
            else
            {
                 query =
                 @"SELECT Feedback.*
                 FROM Feedback
                 INNER JOIN Orders
                 ON Feedback.OrderID = Orders.OrderID
                 INNER JOIN Users
                 ON Orders.CustomerID=
                 Users.UserID
                 WHERE Users.Username=@CustomerID
                 AND CAST(Feedback.Date AS DATE)
                 BETWEEN @FromDate
                 AND @ToDate";

                 parameters = new SqlParameter[]
                 {
                     new SqlParameter(
                    "@CustomerID",
                    customerID),

                    new SqlParameter(
                    "@FromDate",
                    fromDate),

                    new SqlParameter(
                    "@ToDate",
                    toDate)
                 };
            }

            return db.ExecuteQuery(
                query,
                parameters);
        }
    }
}