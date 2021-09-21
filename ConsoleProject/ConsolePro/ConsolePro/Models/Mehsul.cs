using ConsolePro.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePro.Models
{
    class Mehsul
    {
        public string Name;
        public double Price;
        public Categories Categories;
        public int Count;
        public int Code;
        public Mehsul(string name,double price,Categories categories,int count,int code)
        {
            Name = name;
            Price = price;
            Categories = categories;
            Count = count;
            Code = code;
        }
    }
}
