using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHEF
{
    public class Menu
    {
        public int MenuID
        { 
          get;
          set;
        }
        public string MenuName // Menu item name
        {
            get;
            set;
        }
        public string Description // Menu Description
        {
            get;
            set;
        }
        public string Category // Menu category
        {
            get;
            set;
        }
        public decimal Price   // Menu price
        {
            get;
            set;
        }
        public byte[] MenuPic  // Menu image
        {
            get;
            set;
        }
        public bool Available //Menu Availability
        {
            get;
            set;
        }
        public TimeSpan AvailableFrom //Menu Available From
        {
            get;
            set;
        }
        public TimeSpan AvailableUntil // Menu Available Until
        {
            get;
            set;
        }
        public int ChefID      // Chef owner
        {
            get;
            set;
        }
    }
}

