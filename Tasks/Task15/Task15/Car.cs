using System;
using System.Collections.Generic;
using System.Text;

namespace Task15
{
    class Car : Vehicle
    {
        public double FuelCapacity;
        public double CurrentFuel;
        public double FuelFor1km;
        public override void Drive(double km)
        {
            if ((km / FuelFor1km) <= CurrentFuel)
            {
                CurrentFuel--;
                Millage += km;
            }
            else
            {
                Console.WriteLine("benzin tok bakiva");
            }

        }
    }
}
