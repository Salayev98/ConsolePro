using System;
using System.Collections.Generic;
using System.Text;

namespace Task15
{
    abstract class Vehicle
    {
        public string Color;
        public string Brand;
        public double Millage;
        public virtual void ShowInfo()
        {
            Console.WriteLine($"{Color} {Brand} {Millage}");
        }
        public abstract void Drive(double km);
        
    }
}
