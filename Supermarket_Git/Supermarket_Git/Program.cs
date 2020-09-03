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
            Shop store = new Shop();
            List<Product> productsInStore = new List<Product>();
            List<Customer> customers = new List<Customer>();
            date = DateTime.Today;

            if (Password.askpass())
            {
                do
                {
                    productsInStore = store.Menu(productsInStore, ref date, customers);
                    Console.Clear();
                } while (true);
            }
        }
    }
}
