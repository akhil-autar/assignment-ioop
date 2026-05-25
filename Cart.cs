using System.Collections.Generic;

namespace Gr8FoodSystem_Final
{
    public static class Cart
    {
        public static Dictionary<string, int> items =
            new Dictionary<string, int>();

        public static void AddItem(string name)
        {
            if (items.ContainsKey(name))
            {
                items[name]++;
            }
            else
            {
                items[name] = 1;
            }
        }
    }
}