﻿using System;

namespace Supermarket_Git
{
    class Product
    {
        public string Name;
        public string Size;
        public int Amount;
        public DateTime ExpirationDate;
        public int Price;

        public Product(string Name, string Size, int Amount, int Price, DateTime ExpirationDate)
        {
            this.Name = Name;
            this.Size = Size;
            this.Amount = Amount;
            this.Price = Price;
            this.ExpirationDate = ExpirationDate;
        }
    }
}
