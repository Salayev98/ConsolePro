using System;
using System.Collections.Generic;
using System.Text;

namespace Task18
{
    class Student
    {
        private static string _fullname;
        public static string Fullname
        {
            get => _fullname;
            set
            {
                //value = Console.ReadLine();
                bool isDigit = true;
                bool isWhiteSpace = false;
                for (int i = 0; i <value.Length; i++)
                {
                    

                    if (value.Split(" ").Length == 2)
                    {
                        if (char.IsDigit(value[i]))
                        {
                            isDigit = false;
                        }
                        else if (char.IsWhiteSpace(value[i]))
                        {
                            isWhiteSpace = true;
                        }
                    }
                    
                }

                
                if (isDigit && isWhiteSpace)
                {
                    _fullname = value;
                }

            }
        }
        private static string _groupno;
        public static string Groupno
        {
            get => _groupno;

            set
            {
                
                for (int i = 0; i < value.Length; i++)
                {
                    int a;
                    if (value.Length == 4 && char.IsUpper(value[0]) && int.TryParse(value.Substring(1, 3), out a))
                    {
                        _groupno = value;

                    }
                    else
                    {
                        Console.WriteLine("P216 misalcun");
                        break;
                        
                    }
                   
                }
            }
        }
        public int Age;
        public static bool CheckGroupNo(string groupno)
        {
            bool check = false;
            if (Groupno == groupno)
            {
                check = true;
            }
            return check;
        }
        public static bool CheckFullname(string fullname)
        {
            bool check = true;
            
            if (Fullname != fullname)
            {
                check = false;
                
            }
            return check;
        }

    } 

}
