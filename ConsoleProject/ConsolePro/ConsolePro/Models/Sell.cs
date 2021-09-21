using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePro.Models
{
    class Sell
    {
        public int No;
        public double Price;
        public SellItems[] Sellitems;
        public DateTime Date;
        
        

        public Sell(int no, double price)
        {
            DateTime dateTime = DateTime.Now ;
            Date = dateTime;
            No = no;
            Price = price;
            Sellitems = new SellItems[0];
        }
    }
}