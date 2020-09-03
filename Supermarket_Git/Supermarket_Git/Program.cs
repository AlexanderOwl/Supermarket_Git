using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Git
{
    class Program
    {
        static DateTime date = new DateTime();
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            List<Product> productsInShop = new List<Product>();
            List<Customer> customers = new List<Customer>();
            date = DateTime.Today;

            if (Password.askpass())
            {
                do
                {
                    productsInShop = shop.Menu(productsInShop, ref date, customers);
                    Console.Clear();
                } while (true);
            }
        }
    }
}
