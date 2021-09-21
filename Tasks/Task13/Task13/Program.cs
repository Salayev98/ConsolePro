using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] Book = new Book[10];
            int chek = 0;
            while (chek < 10)
            {
                string name = Console.ReadLine();
                string ccount = Console.ReadLine();
                int count;
                int.TryParse(ccount, out count);
                while (!int.TryParse(ccount, out count))
                {
                    Console.WriteLine("reqem daxile et");
                    ccount = Console.ReadLine();
                }
                Book book = new Book(name, count);
                string page = Console.ReadLine();
                int pagecount;
                int.TryParse(page, out pagecount);
                while (!int.TryParse(page, out pagecount))
                {
                    Console.WriteLine("reqem daxil et");
                    page = Console.ReadLine();
                }
                book.PageCount = pagecount;
                chek++;
            }
            foreach (var item in Book)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
