using System;
using System.Collections.Generic;
using System.Text;

namespace Task14
{
    class Group
    {
        public int No;
        public int Limit;
        public Student[] Students;
        public void AddStudent(Student student)
        {
            for (int i = 0; i <= Students.Length-1; i++)
            {
                if (Students.Length <= Limit)
                {
                    Array.Resize(ref Students, Students.Length + 1);
                    Students[Students.Length - 1] = student;
                }
            }
        }
        public void GetStudents()
        {
            foreach (Student item in Students)
            {
                Console.WriteLine(item);
            }
        }
        public Group(int no,int limit)
        {
            Limit = limit;
            No = no;
        }
    }
}
