using System;
using System.Security.Cryptography;
using System.Text;

namespace assignment.Helpers
{
    // Utility class — abstracts all password hashing logic (Abstraction)
    public static class PasswordHelper
    {
        // Hashes a plain text password using SHA256
        public static string HashPassword(string plainText)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                return Convert.ToBase64String(bytes);
            }
        }

        // Verifies a plain text password against a stored hash
        public static bool VerifyPassword(string plainText, string storedHash)
        {
            return HashPassword(plainText) == storedHash;
        }

        // Returns password strength as a string for UI display
        public static string GetStrength(string password)
        {
            if (string.IsNullOrEmpty(password)) return "";
            int score = 0;
            if (password.Length >= 8) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, "[A-Z]")) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, "[0-9]")) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, "[^a-zA-Z0-9]")) score++;

            if (score <= 1) return "Weak";
            if (score == 2) return "Fair";
            if (score == 3) return "Good";
            return "Strong";
        }
    }
}