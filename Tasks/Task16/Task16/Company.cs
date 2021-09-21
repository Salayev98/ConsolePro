using System;
using System.Collections.Generic;
using System.Text;

namespace Task16
{
    class Company
    {
        
        private string _name;
        public string Name
        {
            get => _name;

            set
            {
                if (!char.IsUpper(value, 0))
                    {
                        Console.WriteLine("ilk herf boyuk olmalidir");
                        
                       
                    }
                else
                {
                    foreach (char item in value)
                    {
                        if (char.IsSymbol(item))
                        {
                            Console.WriteLine("simvol olmali deyil");
                            return;
                        }
                       
                    }
                    _name = value;

                }
                
           }
                
        }


        public int Limit;
        public Employe[] Employes;

        public void AddEmployee(Employe employes)
        {
            
            Employe[] Employes = new Employe[0];
            if (Limit > 0)
            {
                Array.Resize(ref Employes, Employes.Length + 1);
                Employes[Employes.Length - 1] = employes;
            }
          
        }
        public  void GetEmploye()
        {
            foreach (Employe item in Employes)
            {
                Console.WriteLine(item);
            }
        }
        public void SearchEmployees(string name)
        {
            foreach (Employe item in Employes)
            {
                if (item.Fullname.ToLower() == name.ToLower())
                {
                    Console.WriteLine($"{item.Position} {item.Salary}");
                }
                else
                {
                    Console.WriteLine("Bele adda Employe movcud deyil");
                }
            }
        }
        public void RemoveEmploye(int no)
        {
           
            Employe employes = null;
            foreach (Employe item in Employes)
            {
                if (item.No == no)
                {
                    employes = item;
                }
            }
            int index = Array.IndexOf(Employes, employes);
            Array.Clear(Employes, index, 1);

        }
         public Company(string name)
        {
            Name = name;
        }
    }
}
