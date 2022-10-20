//Create a simple Stationery application to add items and display added items using Generic List collections
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Application
    {
        public static void Main(string[] args)
        {
            List<string> items = new List<string>();
            items.Add("Vegetables");
            items.Add("Fruits");
            List<string> newitems = new List<string>();
            newitems.Add("Spies");
            newitems.Add("Flours");
            items.AddRange(newitems);
            Console.WriteLine("---added items using Generic List collection---");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
