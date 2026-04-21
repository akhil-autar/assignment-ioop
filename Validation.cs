using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace assignment
{
    public static class Validator
    {
    
        // Password validation
        public static bool ValidatePassword(string password, out string errorpassword)
        {
            if (password.Length < 5)
            {
                errorpassword = "Weak Password";
                return false;
            }

            errorpassword = "Strong Password";
            return true;
            
        }

        // Email validation
        public static bool ValidateEmail(string email, out string erroremail)
        {
            //checking if the email contains "@" and "."
            if (!email.Contains("@") || !email.Contains("."))
            {
                erroremail = "Please enter a valid email address.";
                return false;
            }
            else
            {
                erroremail = "";
                return true;
            }
        }

        // Phone number validation
        public static bool ValidatePhone(string phone, out string errornumber)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                errornumber = "Phone number cannot be empty.";
                return false;
            }

            // remove spaces just in case
            phone = phone.Trim();

            // check if all characters are digits
            if (!phone.All(char.IsDigit))
            {
                errornumber = "Phone number must contain only digits.";
                return false;
            }

            // check length (11 digits)
            if (phone.Length != 11)
            {
                errornumber = "Phone number should not exceed 11 digits.";
                return false;
            }

            errornumber = "";
            return true;
        }

        // Username validation to check if it already exists in the database
        public static bool ValidateUsernameExists(string username, string connectionString, out string errorusername)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                errorusername = "Username cannot be empty.";
                return false;
            }

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
                        errorusername = "Username already exists. Please choose another.";
                        return false;
                    }
                }
            }

            errorusername = " ";
            return true;
        }
    }
}
