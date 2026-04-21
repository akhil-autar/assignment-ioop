using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignment.Models;

namespace assignment.Helpers
{
    // Stores the currently logged-in user for the duration of the session
    // Static class means only one instance exists across the entire application (Singleton pattern)
    // Any form can access SessionManager.CurrentUser without needing it passed manually
    public static class SessionManager
    {
        public static User CurrentUser { get; private set; }

        // Called on successful login to store the user
        public static void Login(User user)
        {
            CurrentUser = user;
        }

        // Called on logout to clear the session
        public static void Logout()
        {
            CurrentUser = null;
        }

        // Utility check — any form can verify a session is active
        public static bool IsLoggedIn()
        {
            return CurrentUser != null;
        }
    }
}

