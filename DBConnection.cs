using System.Data;                     // Provides DataTable and other data structures
using System.Data.SqlClient;          // Provides SQL Server connection classes

public class DatabaseHelper
{
    //This string tells how to connect to the database(Data Source =server name,Initial Catalog =database name
    //Integrated Security = use Windows login (no username/password needed))
    private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Gr8Food;Integrated Security=True";

    //METHOD 1: Used to GET data (SELECT queries)
    public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
    {
        // Creating a new connection using connection string
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            // SqlDataAdapter helps execute SELECT queries and store results
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // DataTable is used to hold the result from the database
            DataTable dt = new DataTable();

            // Fill the DataTable with the result of the query
            da.Fill(dt);

            // Return the data back to whoever called this method
            return dt;
        }
        // Connection automatically closes because of "using"
    }


    //METHOD 2: Used for INSERT / UPDATE / DELETE
    public void ExecuteNonQuery(string query, SqlParameter[] parameters = null)
    {
        // Creating a new connection
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            // SqlCommand is used to execute SQL statements
            SqlCommand cmd = new SqlCommand(query, conn);

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            // Opening the connection to the database
            conn.Open();

            // Execute the query (no data returned, just action performed)
            cmd.ExecuteNonQuery();
        }
        // Connection automatically closes here
    }

    //METHOD 3: Used when query returns a single value
    public object ExecuteScalar(string query, SqlParameter[] parameters = null)
    {
        // Creating connection using connection string
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            // Creating SQL command
            SqlCommand cmd = new SqlCommand(query, conn);

            // Adding parameters if any
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            // Openning connection
            conn.Open();

            // Executing query and return single value
            return cmd.ExecuteScalar();
        }

    }
}