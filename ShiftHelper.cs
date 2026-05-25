using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHEF
{
    public class ShiftHelper
    {
        // getting current shift
        public static string GetCurrentShift()
        {
            // Current system time
            TimeSpan currentTime =DateTime.Now.TimeOfDay;

            // Breakfast Shift
            if (currentTime >=TimeSpan.Parse("07:00")&& currentTime < TimeSpan.Parse("11:00"))
            {
                return "Breakfast";
            }

            // Lunch Shift
            else if (currentTime >= TimeSpan.Parse("12:00") && currentTime < TimeSpan.Parse("17:00"))
            {
                return "Lunch";
            }

            // Dinner Shift
            else
            {
                return "Dinner";
            }
        }

        // Getting active ChefID
        public static int GetActiveChefID()
        {
            // Current active shift
            string shift =GetCurrentShift();

            // Breakfast Chef
            if (shift == "Breakfast")
            {
                return 5;
            }

            // Lunch Chef
            else if (shift == "Lunch")
            {
                return 6;
            }

            // Dinner Chef
            else
            {
                return 7;
            }
        }
        // Method to get shift timing

        // Method to get chef shift
        public static string GetChefShift(int chefID)
        {
            // Breakfast chef
            if (chefID == 5)
            {
                return "Breakfast";
            }

            // Lunch chef
            else if (chefID == 6)
            {
                return "Lunch";
            }

            // Dinner chef
            else
            {
                return "Dinner";
            }
        }

        // Method to get chef shift timing
        public static string GetChefShiftTime(int chefID
        )
        {
            // Breakfast shift
            if (chefID == 5)
            {
                return "7:00 AM - 11:59 AM";
            }

            // Lunch shift
            else if (chefID == 6)
            {
                return "12:00 PM - 4:59 PM";
            }

            // Dinner shift
            else
            {
                return "5:00 PM - 11:59 PM";
            }
        }

        // Method to get shift start time
        public static TimeSpan GetShiftStartTime(
            int chefID
        )
        {
            // Breakfast
            if (chefID == 5)
            {
                return TimeSpan.Parse("07:00");
            }

            // Lunch
            else if (chefID == 6)
            {
                return TimeSpan.Parse("12:00");
            }

            // Dinner
            else
            {
                return TimeSpan.Parse("17:00");
            }
        }


        // Method to get shift end time
        public static TimeSpan GetShiftEndTime(
            int chefID
        )
        {
            // Breakfast
            if (chefID == 5)
            {
                return TimeSpan.Parse("11:59");
            }

            // Lunch
            else if (chefID == 6)
            {
                return TimeSpan.Parse("16:59");
            }

            // Dinner
            else
            {
                return TimeSpan.Parse("23:59");
            }
        }
        public static bool IsMenuAvailable(TimeSpan availableFrom,TimeSpan availableUntil)// Method to check if menu is available
        {
            // Current system time
            TimeSpan currentTime = DateTime.Now.TimeOfDay;

            // Return availability status
            return currentTime >= availableFrom && currentTime <= availableUntil;
        }

        public static bool CanChefAccessCategory(int chefID,string category) // Method to check if chef can access category
        {
            // Shared categories
            if (category == "Snacks" || category == "Drinks")
            {
                return true;
            }

            // Breakfast Chef
            if (chefID == 5 && category == "Breakfast")
            {
                return true;
            }

            // Lunch Chef
            if (chefID == 6 && category == "Lunch")
            {
                return true;
            }

            // Dinner Chef
            if (chefID == 7 && category == "Dinner")
            {
                return true;
            }
            // Otherwise deny access
            return false;
        }
    }
}

