using System;
using System.Collections.Generic;
using System.Text;

namespace Task13
{
    class Book
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                while (value.Length < 3)
                {
                    Console.WriteLine("3 herfden artiq olmalidir");
                    value = Console.ReadLine();
                }
                _name = value;
            }
        }
        public int Count;
        private int _pagecount;
        public int PageCount
        {
            get => _pagecount;
            set
            {
                while (value < 10)
                {
                    Console.WriteLine("10dan awaqi ola bilmez");
                    string pcount = Console.ReadLine();
                    while (!int.TryParse(pcount,out value))
                    {
                        Console.WriteLine("kitab sehifeleri yalniz reqemle olmalidi");
                        pcount = Console.ReadLine();
                    }
                    
                }
                _pagecount = value;
            }
        }
        public Book(string name, int count)
        {
            Name = name;
            Count = count;
        }
    }
}
