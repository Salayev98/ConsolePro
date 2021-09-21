using System;
using System.Collections.Generic;
using System.Text;

namespace Task11
{
    class User
    {
        private string _username;
        public string Username
        {
            get => _username;
           
            set
            {
                while (value.Length < 8)
                {
                    Console.WriteLine("ad 8 reqemden boyuk olmalidir");
                    value = Console.ReadLine();
                }
                _username = value;
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                bool check = true;
                while (check)
                {
                    if (value.Length >= 8)
                    {
                        bool isDigit = false;
                        bool isUpper = false;
                        bool isLower = false;
                        foreach (char item in value)
                        {


                            if (char.IsDigit(item))
                            {
                                isDigit = true;
                            }
                            else if (char.IsUpper(item))
                            {
                                isUpper = true;
                            }
                            else if (char.IsLower(item))
                            {
                                isLower = true;
                            }

                            
                        }
                        if (isLower && isDigit && isUpper)
                        {
                            check = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("zehmet olmazsa duzgun daxil edin");
                            value = Console.ReadLine();
                        }

                    }
                    else
                    {
                        Console.WriteLine("Kod 8 reqemden boyuk olmalidir");
                        value = Console.ReadLine();
                    }
                    _password = value;
                }
                


            }
        }
        public User(string username)
        {
            Username = username;
        }
    }
}
