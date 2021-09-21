using System;
using System.Collections.Generic;
using System.Text;

namespace Task12
{
    class Milk : Product
    {
        public double Volume;
        public double FotRate;
        public Milk(string name,double volume,double fotrate,int count, double price, double totalincome) :base(name,count,price,totalincome)
        {
            Volume = volume;
            FotRate = fotrate;
        }
    }
}
