using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ad yazin");
            string username = Console.ReadLine();

            while (username.Length < 8)
            {
                Console.WriteLine("ad 8 reqemden boyuk olmalidir");
                username = Console.ReadLine();
            }
            Console.WriteLine("kod yazin");
            string password = Console.ReadLine();
            User user = new User(username);
            user.Password = password;
        }
    }
}
