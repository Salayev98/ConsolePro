using ConsolePro.Enums;
using ConsolePro.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePro.Interface
{
    interface IMarketable
    {
        public Sell[] Sells { get; }
        public Mehsul[] Mehsullar { get; }
        public void AddSell(int no, double price,int count,int code,Mehsul mehsullar);
        public void ReturnProduct(string no, int count, string name);
        public void GetMehsuls();
        public void GetAllSell();
        public void GetSellforDataaraliqi(DateTime date1,DateTime date2);
        public void GetSellforDate(DateTime date);
        public void GetSellforPrice(double minprice,double maxprice);
        public void GetSellforNo(int no);
        public void AddnewMehsul(string name, double price, Categories categories, int count, int code);
        public void EditMehsul(string newname, Categories newcategory,double newprice,int newcount);
        public void GetMehsulforCategory(Categories categories);
        public void GetMehsulforPrice(int minprice, int maxprice);
        public void GetMehsulfortext(string text);
    }
}
