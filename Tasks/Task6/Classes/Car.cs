using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Car : Vehicle
    {
        public string Brand;
        public string Model;
        public double FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;
        public Car(int year,string brand, string model,double fuelcapacity,double fuelfor1km,double currentfuel) : base(year)
        {
            
            Brand = brand;
            Model = model;
            FuelCapacity = fuelcapacity;
            FuelCapacity = fuelcapacity;
            CurrentFuel = currentfuel;

        }
        public void AddFuel(double fuel)
        {

        }
        public void Drive(double km)
        {

        }
    }
}
