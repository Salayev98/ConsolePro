using System;

namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'a';
            
            foreach (var item in a.GetValueIndexes())
            {
                Console.WriteLine(item);
            }
        }
    }
}
