using System;
using System.Collections.Generic;
using System.Text;
using Task20.Enums;
using Type = Task20.Enums.Type;

namespace Task20
{
    class Product
    {
        public static int Count2;
        public int TotalCount;
        public string Code;
        public static int Count = 1000;
        public string Name;
        public double Price;
        public double DiscountedPrice;
        public Type Types;
        public Product(string name,double price,Type types)
        {
            Count++;
            Price = price;
            Name = name;
            Types = types;
            switch (types)
            {
                case Type.Bakery:
                    Code = "B" + Count;
                    break;
                case Type.Drink:
                    Code = "D" + Count;
                    break;
                case Type.Fish:
                    Code = "F" + Count;
                    break;
                case Type.Meat:
                    Code = "M" + Count;
                    break;
                default:
                    break;
            }
            if (types == Type.Bakery)
            {
                DiscountedPrice = Price - (Price * 0.1);
            }
            Count2++;
            TotalCount = Count2;
        }
        
    }
}
