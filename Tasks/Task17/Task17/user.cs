using System;
using System.Collections.Generic;
using System.Text;

namespace Task17
{
    class User : IAccount
    {
        public string FullName;
        public string Email;
        public string Password;
        public bool PasswordChecker(string password)
        {
            bool check = true;
            if (check)
            {
                bool isUpper = false;
                bool isLower = false;
                bool isDigit = false;
                if (password.Length > 8)
                {
                    foreach (char item in password)
                    {
                        if (!char.IsUpper(item))
                        {
                            isUpper = true;
                        }
                        else if (!char.IsLower(item))
                        {
                            isLower = true;
                        }
                        else if (!char.IsDigit(item))
                        {
                            isDigit = true;
                        }
                    }
                    if (isLower&&isUpper&&isDigit)
                    {
                        check = true;
                        return check;
                    }
                }
                else
                {
                    return check;
                }
            }
            return check;
           
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{FullName} {Email}");
        }
    }
}
