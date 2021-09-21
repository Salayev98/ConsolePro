using ConsolePro.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePro.Models
{
    class SellItems
    {
        public int No;
        public Mehsul Mehsullar;
        public int Count;
        public SellItems( int count , Mehsul mehsullar )
        {
            Mehsullar = mehsullar;
            Count = count;
           
        }
        
    }
}
