using System;
using System.Collections.Generic;
using System.Text;

namespace Task12
{
    class Product
    { 
        public string Name;
        public int Count;
        public double Price;
        public double TotalIncome;
        public void Sell()
        {
            if (Count == 0)
            {
                Console.WriteLine("satiw baw vere bilmez");
            }
            Count--;
            TotalIncome += Price;
        }
        public Product(string name,int count, double price,double totalincome)
        {
            Name = name;
            Count = count;
            Price = price;
            TotalIncome = totalincome;
        }
    }
}
