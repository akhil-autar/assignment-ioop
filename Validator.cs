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

        public static bool ValidateUsernameExists(string username, out string error)
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

            try
            {
                DatabaseHelper db = new DatabaseHelper();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @username";
                SqlParameter[] parameters = { new SqlParameter("@username", username) };
                int count = Convert.ToInt32(db.Executescalar(query, parameters));
                if (count > 0)
                {
                    error = "Username already exists.";
                    return false;
                }
                return true;
            }
            catch
            {
                // If DB check fails, allow the form to proceed — duplicate check will fail at save time anyway
                return true;
            }
        }
    }
}
    