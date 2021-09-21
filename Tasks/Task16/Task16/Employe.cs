using System;
using System.Collections.Generic;
using System.Text;

namespace Task16
{
    class Employe
    {
        public static int count = 1;
        public int No;
        public string Fullname;
        public int Salary;
        public string Position;
        public Employe(string fullname, int salary, string position)
        {
            count++;
            No = count;
            Fullname = fullname;
            Salary = salary;
            Position = position;
        }
       
    }
}
