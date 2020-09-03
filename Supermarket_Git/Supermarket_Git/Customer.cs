using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Git
{
    class Customer
    {
        public List<Product> ProductsList = new List<Product>();
        public int Cash;
        public int QueueNumber;
        public string Name;
        private Storage _storage = new Storage();

        public Customer(string Name, int QueueNumber)
        {
            this.QueueNumber = QueueNumber;
            this.Name = Name;
            this.ProductsList = ShopingListGenerator(_storage.ProductGenerator());
            this.Cash = AmountGenerator(20, 1000);
        }

    }
}
