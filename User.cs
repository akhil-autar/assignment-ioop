using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace assignment.Models
{
    // Encapsulates all user data as a single object (Encapsulation)
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public User() { }

        public User(string username, string password, string role, string email, string phoneNumber, string gender)
        {
            Username = username;
            Password = password;
            Role = role;
            Email = email;
            PhoneNumber = phoneNumber;
            Gender = gender;
        }

        // Returns a display-friendly summary of the user
        public override string ToString()
        {
            return $"{Username} ({Role})";
        }
    }
}