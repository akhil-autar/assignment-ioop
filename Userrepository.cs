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
        private readonly string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // ─── Add User ─────────────────────────────────────────────────

        public bool AddUser(User user)
        {
            // Hash password before storing — never store plain text
            string hashedPassword = PasswordHelper.HashPassword(user.Password);

            string query = @"INSERT INTO Users (Username, Password, Role, Email, Phone, Gender) 
                             VALUES (@username, @password, @role, @email, @phone, @gender)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.Parameters.AddWithValue("@role", user.Role);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@phone", user.PhoneNumber);
                    cmd.Parameters.AddWithValue("@gender", user.Gender);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ─── Get Users ────────────────────────────────────────────────

        // Retrieves all users from the database
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            string query = "SELECT UserID, Username, Role, Email, Phone, Gender FROM Users";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(MapReaderToUser(reader));
                    }
                }
            }
            return users;
        }

        // Retrieves a single user by username — used for login and profile lookup
        public User GetUserByUsername(string username)
        {
            string query = "SELECT UserID, Username, Password, Role, Email, Phone, Gender FROM Users WHERE Username = @username";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return MapReaderToUser(reader, includePassword: true);
                    }
                }
            }
            return null;
        }

        // Retrieves a single user by their ID
        public User GetUserById(int userId)
        {
            string query = "SELECT UserID, Username, Role, Email, Phone, Gender FROM Users WHERE UserID = @id";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return MapReaderToUser(reader);
                    }
                }
            }
            return null;
        }

        // ─── Update User ──────────────────────────────────────────────

        // Updates a user's profile fields
        public bool UpdateUser(User user)
        {
            string query = @"UPDATE Users 
                             SET Username = @username,
                                 Email    = @email,
                                 Phone    = @phone,
                                 Role     = @role,
                                 Gender   = @gender
                             WHERE UserID = @id";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@phone", user.PhoneNumber);
                    cmd.Parameters.AddWithValue("@role", user.Role);
                    cmd.Parameters.AddWithValue("@gender", user.Gender);
                    cmd.Parameters.AddWithValue("@id", user.Id);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Resets a user's password — hashes the new password before storing
        public bool ResetPassword(int userId, string newPassword)
        {
            string hashedPassword = PasswordHelper.HashPassword(newPassword);
            string query = "UPDATE Users SET Password = @password WHERE UserID = @id";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.Parameters.AddWithValue("@id", userId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ─── Delete User ──────────────────────────────────────────────

        public bool DeleteUser(int userId)
        {
            string query = "DELETE FROM Users WHERE UserID = @id";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ─── Stat Counts (used by dashboard and view all accounts) ────

        public int GetTotalUserCount()
        {
            return ExecuteCount("SELECT COUNT(*) FROM Users");
        }

        public int GetStaffCount()
        {
            return ExecuteCount("SELECT COUNT(*) FROM Users WHERE Role != 'Customer'");
        }

        public int GetCustomerCount()
        {
            return ExecuteCount("SELECT COUNT(*) FROM Users WHERE Role = 'Customer'");
        }

        // IsActive doesn't exist in DB — returns total as safe fallback
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
        private User MapReaderToUser(SqlDataReader reader, bool includePassword = false)
        {
            return new User
            {
                Id = (int)reader["UserID"],
                Username = reader["Username"].ToString(),
                Password = includePassword ? reader["Password"].ToString() : "",
                Role = reader["Role"].ToString(),
                Email = reader["Email"].ToString(),
                PhoneNumber = reader["Phone"].ToString(),
                Gender = reader["Gender"].ToString(),
                IsActive = true
            };
        }

        // Reusable COUNT query helper — avoids repeating connection code (DRY principle)
        private int ExecuteCount(string query)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                    return (int)cmd.ExecuteScalar();
            }
        }
    }
}