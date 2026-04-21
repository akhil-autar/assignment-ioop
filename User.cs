using System;

namespace assignment.Models
{
    // Represents a user in the system — maps directly to the Users table in the database
    public class User
    {
        public int Id 
        { 
            get; 
            set; 
        }              // maps to UserID in database
        public string Username 
        {  
            get; 
            set; 
        }
        public string Password 
        { 
            get; 
            set; 
        }
        public string Role 
        { 
            get; 
            set; 
        }
        public string Email 
        { 
            get; 
            set; 
        }
        public string PhoneNumber 
        { 
            get; 
            set; 
        }  // maps to Phone column in database
        public string Gender 
        { 
            get; 
            set; 
        }
        public bool IsActive 
        { 
            get; 
            set; 
        } = true; // not in DB — defaults to true

        public User() 
        {
        }

        public User(string username, string password, string role, string email, string phoneNumber, string gender)
        {
            Username = username;
            Password = password;
            Role = role;
            Email = email;
            PhoneNumber = phoneNumber;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"{Username} ({Role})";
        }
    }
}