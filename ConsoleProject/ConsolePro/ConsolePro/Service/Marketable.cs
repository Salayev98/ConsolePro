
using ConsolePro.Enums;
using ConsolePro.Interface;
using ConsolePro.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePro.Service
{
    class Marketable : IMarketable
    {
        private Sell[] _sells;
        public Sell[] Sells => _sells;
        private Mehsul[] _mehsullar;
       
        public Mehsul[] Mehsullar =>_mehsullar;

        public Marketable()
        {
            _sells = new Sell[0];
            _mehsullar = new Mehsul[0];
        }
        public void AddnewMehsul(string name, double price, Categories categories, int count, int code)
        {
            Mehsul mehsul = new Mehsul(name, price, categories, count, code);
            Array.Resize(ref _mehsullar, _mehsullar.Length + 1);
            _mehsullar[_mehsullar.Length - 1] = mehsul;

        }
        
        public void AddSell(int no, double price,int count,int code,Mehsul mehsullar)
        {
            Sell sell = new Sell(no, price);
            Array.Resize(ref _sells, _sells.Length + 1);
            _sells[_sells.Length - 1] = sell;
            SellItems sellItems = new SellItems(count,mehsullar);

            Array.Resize(ref sell.Sellitems,sell.Sellitems.Length+1);
            sell.Sellitems[sell.Sellitems.Length - 1] = sellItems;
        }
       
        public void EditMehsul(string newname,Categories newcategory ,double newprice,int newcount)
        {
           
            
            foreach (Mehsul item in Mehsullar)
            {
                    item.Name = newname;
                    item.Price = newprice;
                    item.Count = newcount;
                    item.Categories = newcategory;
                
            }
            Console.WriteLine("Mehsul uqurla deyiwdi");
        }

        public void GetAllSell()
        {
            foreach (Sell item in Sells)
            {
                if (item != null)
                {
                    foreach (SellItems item2 in item.Sellitems)
                    {
                        Console.WriteLine($"Nomresi: {item.No} Meblegi: {item.Price} Mehsul Sayi: {item2.Count} Tarixi: {item.Date}");
                    }
                }
                else
                {
                    Console.WriteLine("Satiw movcud deyil");
                }
            }
        }

        public void GetMehsulfortext(string text)
        {
            foreach (Mehsul item in Mehsullar)
            {
                if (item.Name.Contains(text))
                {
                    Console.WriteLine($"{item.Code} {item.Name} {item.Categories} {item.Count}");
                }
                else
                {
                    Console.WriteLine("bu text hec bir ada daxil deyil");
                }
            }
        }

        public void GetMehsulforCategory(Categories categories)
        {
            foreach (Mehsul item in Mehsullar)
            {
                if (item.Categories == categories)
                {
                    Console.WriteLine($"{item.Code} {item.Count} {item.Name} {item.Price} {item.Categories}");
                }
            }
        }

        public void GetMehsulforPrice(int minprice,int maxprice)
        {
            foreach (Mehsul item in Mehsullar)
            {
                if (maxprice > item.Price && item.Price > minprice)
                {
                    Console.WriteLine($"Adi:{item.Name} Code: {item.Code} Sayi: {item.Count} Cateqoriyasi: {item.Categories} Qiymeti: {item.Price} Azn");
                }
            }
        }

        public void GetMehsuls()
        {
            foreach (Mehsul item in Mehsullar)
            {
                if (item != null)
                {
                    Console.WriteLine($"Adi:{item.Name} Code: {item.Code} Sayi: {item.Count} Cateqoriyasi: {item.Categories} Qiymeti: {item.Price} Azn");
                }
                else
                {
                    Console.WriteLine("mehsul movcud deyil");
                }
                
            }
        }

        public void GetSellforDataaraliqi(DateTime date1, DateTime date2)
        {
            foreach (Sell item in Sells)
            {
                if (date2> item.Date && item.Date > date1)
                {
                    foreach (SellItems item2 in item.Sellitems)
                    {
                        Console.WriteLine($"Nomresi: {item.No} Meblegi: {item.Price} Mehsul Sayi: {item2.Count} Tarixi: {item.Date}");
                    }
                   
                }
                else
                {
                    Console.WriteLine("Bu tarix araliqinda satiw movcud deyil");
                }
            }
        }

        public void GetSellforDate(DateTime date)
        {
            foreach (Sell item in Sells)
            {
                if (item.Date == date)
                {
                    foreach (SellItems item2 in item.Sellitems)
                    {
                        Console.WriteLine($"Nomresi: {item.No} Meblegi: {item.Price} Mehsul Sayi: {item2.Count} Tarixi: {item.Date}");
                    }
                }
                else
                {
                    Console.WriteLine("Bu tarixde satiw movcud deyil");
                }
            }
        }

        public void GetSellforNo(int no)
        {
            foreach (Sell item in Sells)
            {
                if (item.No == no)
                {
                    foreach (SellItems item2 in item.Sellitems)
                    {
                        Console.WriteLine($"Nomresi: {item.No} Meblegi: {item.Price} Mehsul Sayi: {item2.Count} Tarixi: {item.Date}");

                    }

                }

            }
        }

        public void GetSellforPrice(double minprice, double maxprice)
        {
            foreach (Sell item in Sells)
            {
                if (maxprice > item.Price && item.Price > minprice)
                {
                    foreach (SellItems item2 in item.Sellitems)
                    {
                        Console.WriteLine($"Nomresi: {item.No} Meblegi: {item.Price} Mehsul Sayi: {item2.Count} Tarixi: {item.Date}");

                    }
                    
                }
                
            }
        }

        public void ReturnProduct(string no, int count, string name)
        {
            foreach (Sell item in Sells)
            {
                foreach (SellItems item2 in item.Sellitems)
                {
                    if (item2.Count >= count)
                    {
                        item2.Count -= count;
                        item.Price -= count * item2.Mehsullar.Price;
                    }
                }
            }
        }
    }
}
