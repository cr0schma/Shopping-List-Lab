using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    internal class Methods
    {
        public static void DisplayGroceries(Dictionary<string, decimal> prices)
        {
            Console.WriteLine("Item\tPrice");
            Console.WriteLine("----------------");

            foreach (KeyValuePair<string, decimal> item in prices)
            {
                Console.WriteLine($"{item.Key}\t${item.Value}");
            }
        }
    }
}
