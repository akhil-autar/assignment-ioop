using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using assignment.Models;
using assignment.Helpers;

namespace assignment.Repositories
{
    // Handles all database operations for User objects (Encapsulation + Separation of Concerns)
    // The form does not need to know how data is stored — it just calls these methods (Abstraction)
    public class UserRepository
    {
        private readonly string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Adds a new user to the database. Returns true if successful.
        public bool AddUser(User user)
        {
            // Hash the password before storing
            string hashedPassword = PasswordHelper.HashPassword(user.Password);

            string query = @"INSERT INTO Users (Username, Password, Role, Email, Phone, Gender, IsActive, CreatedAt) 
                             VALUES (@username, @password, @role, @email, @phone, @gender, @isActive, @createdAt)";

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
                    cmd.Parameters.AddWithValue("@isActive", user.IsActive);
                    cmd.Parameters.AddWithValue("@createdAt", user.CreatedAt);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Retrieves all users from the database
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            string query = "SELECT Id, Username, Role, Email, Phone, Gender, IsActive, CreatedAt FROM Users";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            Id = (int)reader["Id"],
                            Username = reader["Username"].ToString(),
                            Role = reader["Role"].ToString(),
                            Email = reader["Email"].ToString(),
                            PhoneNumber = reader["Phone"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            IsActive = (bool)reader["IsActive"],
                            CreatedAt = (DateTime)reader["CreatedAt"]
                        });
                    }
                }
            }
            return users;
        }

        // Retrieves a single user by username
        public User GetUserByUsername(string username)
        {
            string query = "SELECT Id, Username, Password, Role, Email, Phone, Gender, IsActive FROM Users WHERE Username = @username";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Id = (int)reader["Id"],
                                Username = reader["Username"].ToString(),
                                Password = reader["Password"].ToString(),
                                Role = reader["Role"].ToString(),
                                Email = reader["Email"].ToString(),
                                PhoneNumber = reader["Phone"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                IsActive = (bool)reader["IsActive"]
                            };
                        }
                    }
                }
            }
            return null;
        }

        // Updates an existing user's profile
        public bool UpdateUser(User user)
        {
            string query = @"UPDATE Users SET Email = @email, Phone = @phone, Gender = @gender, Role = @role
                             WHERE Id = @id";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@phone", user.PhoneNumber);
                    cmd.Parameters.AddWithValue("@gender", user.Gender);
                    cmd.Parameters.AddWithValue("@role", user.Role);
                    cmd.Parameters.AddWithValue("@id", user.Id);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Resets a user's password (admin function)
        public bool ResetPassword(int userId, string newPassword)
        {
            string hashedPassword = PasswordHelper.HashPassword(newPassword);
            string query = "UPDATE Users SET Password = @password WHERE Id = @id";

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

        // Toggles a user's active status (enable/disable without deleting)
        public bool SetUserActiveStatus(int userId, bool isActive)
        {
            string query = "UPDATE Users SET IsActive = @isActive WHERE Id = @id";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@isActive", isActive);
                    cmd.Parameters.AddWithValue("@id", userId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Deletes a user from the database
        public bool DeleteUser(int userId)
        {
            string query = "DELETE FROM Users WHERE Id = @id";

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

        // Returns total user count for dashboard stat card
        public int GetTotalUserCount()
        {
            return ExecuteCount("SELECT COUNT(*) FROM Users");
        }

        // Returns count of staff accounts (non-customer roles) for dashboard
        public int GetStaffCount()
        {
            return ExecuteCount("SELECT COUNT(*) FROM Users WHERE Role != 'Customer'");
        }

        // Returns count of customer accounts for dashboard
        public int GetCustomerCount()
        {
            return ExecuteCount("SELECT COUNT(*) FROM Users WHERE Role = 'Customer'");
        }

        // Returns count of active accounts for dashboard
        public int GetActiveUserCount()
        {
            return ExecuteCount("SELECT COUNT(*) FROM Users WHERE IsActive = 1");
        }

        // Returns count of inactive/disabled accounts for dashboard
        public int GetInactiveUserCount()
        {
            return ExecuteCount("SELECT COUNT(*) FROM Users WHERE IsActive = 0");
        }

        // Private helper to avoid repeating connection code for COUNT queries (DRY principle)
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