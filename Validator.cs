using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace assignment.Helpers
{
    // Handles all input validation logic, separated from the UI (Encapsulation + Abstraction)
    public static class Validator
    {
        public static bool ValidateEmail(string email, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(email))
            {
                error = "Email is required.";
                return false;
            }
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                error = "Invalid email format.";
                return false;
            }
            return true;
        }

        public static bool ValidatePassword(string password, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(password))
            {
                error = "Password is required.";
                return false;
            }
            if (password.Length < 8)
            {
                error = "Password must be at least 8 characters.";
                return false;
            }
            if (!Regex.IsMatch(password, "[A-Z]"))
            {
                error = "Password must contain at least one uppercase letter.";
                return false;
            }
            if (!Regex.IsMatch(password, "[0-9]"))
            {
                error = "Password must contain at least one number.";
                return false;
            }
            return true;
        }

        public static bool ValidatePhone(string phone, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(phone))
            {
                error = "Phone number is required.";
                return false;
            }
            if (!Regex.IsMatch(phone, @"^\+?[0-9]{10,15}$"))
            {
                error = "Invalid phone number format.";
                return false;
            }
            return true;
        }

        public static bool ValidateUsernameExists(string username, string connectionString, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(username))
            {
                error = "Username is required.";
                return false;
            }
            if (username.Length < 3)
            {
                error = "Username must be at least 3 characters.";
                return false;
            }

            // Check database for existing username
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @username";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        error = "Username already exists.";
                        return false;
                    }
                }
            }
            return true;
        }
    }
}