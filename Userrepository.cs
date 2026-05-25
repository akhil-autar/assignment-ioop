using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using assignment.Models;
using assignment.Helpers;

namespace assignment.Repositories
{
    // Handles all database operations for User objects
    // Column mapping: UserID → Id, Phone → PhoneNumber
    // IsActive and CreatedAt do NOT exist in the database
    public class UserRepository
    {
        private DatabaseHelper _db;
        public UserRepository()
        {
            _db = new DatabaseHelper();
        }

        // ─── Add User ─────────────────────────────────────────────────

        public void AddUser(User user)
        {
            string query = "INSERT INTO Users (Username, Password, Role, Email, Phone, Gender) VALUES (@Username, @Password, @Role, @Email, @Phone, @Gender)";
            SqlParameter[] parameters = {
        new SqlParameter("@Username", user.Username),
        new SqlParameter("@Password", PasswordHelper.HashPassword(user.Password)),
        new SqlParameter("@Role", user.Role),
        new SqlParameter("@Email", user.Email),
        new SqlParameter("@Phone", user.PhoneNumber),
        new SqlParameter("@Gender", user.Gender)
    };
            _db.ExecuteNonQuery(query, parameters);
        }

        // ─── Get Users ────────────────────────────────────────────────

        // Retrieves all users from the database
        public List<User> GetAllUsers()
        {
            string query = "SELECT UserID, Username, Role, Email, Phone, Gender FROM Users";
            DataTable dt = _db.ExecuteQuery(query);
            List<User> users = new List<User>();
            foreach (DataRow row in dt.Rows)
                users.Add(MapRowToUser(row, false));
            return users;
        }

        // Retrieves a single user by username — used for login and profile lookup
        public User GetUserByUsername(string username)
        {
            string query = "SELECT UserID, Username, Password, Role, Email, Phone, Gender FROM Users WHERE Username = @Username";
            SqlParameter[] parameters = { new SqlParameter("@Username", username) };
            DataTable dt = _db.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return null;
            return MapRowToUser(dt.Rows[0], true);
        }

        // Retrieves a single user by their ID
        public User GetUserById(int userId)
        {
            string query = "SELECT UserID, Username, Role, Email, Phone, Gender FROM Users WHERE UserID = @UserID";
            SqlParameter[] parameters = { new SqlParameter("@UserID", userId) };
            DataTable dt = _db.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return null;
            return MapRowToUser(dt.Rows[0], false);
        }

        // ─── Update User ──────────────────────────────────────────────

        // Updates a user's profile fields
        public void UpdateUser(User user)
        {
            string query = "UPDATE Users SET Username=@Username, Role=@Role, Email=@Email, Phone=@Phone, Gender=@Gender WHERE UserID=@UserID";
            SqlParameter[] parameters = {
        new SqlParameter("@Username", user.Username),
        new SqlParameter("@Role", user.Role),
        new SqlParameter("@Email", user.Email),
        new SqlParameter("@Phone", user.PhoneNumber),
        new SqlParameter("@Gender", user.Gender),
        new SqlParameter("@UserID", user.Id)
    };
            _db.ExecuteNonQuery(query, parameters);
        }

        // Resets a user's password — hashes the new password before storing
        public void ResetPassword(int userId, string newPassword)
        {
            string query = "UPDATE Users SET Password=@Password WHERE UserID=@UserID";
            SqlParameter[] parameters = {
        new SqlParameter("@Password", PasswordHelper.HashPassword(newPassword)),
        new SqlParameter("@UserID", userId)
    };
            _db.ExecuteNonQuery(query, parameters);
        }

        // ─── Delete User ──────────────────────────────────────────────

        public void DeleteUser(int userId)
        {
            string query = "DELETE FROM Users WHERE UserID=@UserID";
            SqlParameter[] parameters = { new SqlParameter("@UserID", userId) };
            _db.ExecuteNonQuery(query, parameters);
        }

        // ─── Stat Counts (used by dashboard and view all accounts) ────

        public int GetTotalUserCount()
        {
            return Convert.ToInt32(_db.Executescalar("SELECT COUNT(*) FROM Users"));
        }

        public int GetStaffCount()
        {
            return Convert.ToInt32(_db.Executescalar("SELECT COUNT(*) FROM Users WHERE Role != 'Customer'"));
        }

        public int GetCustomerCount()
        {
            return Convert.ToInt32(_db.Executescalar("SELECT COUNT(*) FROM Users WHERE Role = 'Customer'"));
        }

        public int GetActiveUserCount()
        {
            return GetTotalUserCount();
        }
        public int GetInactiveUserCount()
        {
            return 0;
        }

        // ─── Private Helpers ──────────────────────────────────────────

        // Maps a SqlDataReader row to a User object
        // includePassword: only true for login — never include password for display purposes
        private User MapRowToUser(DataRow row, bool includePassword)
        {
            return new User
            {
                Id = Convert.ToInt32(row["UserID"]),
                Username = row["Username"].ToString(),
                Password = includePassword ? row["Password"].ToString() : null,
                Role = row["Role"].ToString(),
                Email = row["Email"].ToString(),
                PhoneNumber = row["Phone"].ToString(),
                Gender = row["Gender"].ToString()
            };
        }

        // Reusable COUNT query helper — avoids repeating connection code
        private int ExecuteCount(string query)
        {
            return Convert.ToInt32(_db.Executescalar(query));
        }
    }
}