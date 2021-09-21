using System;
using System.Collections.Generic;
using System.Text;

namespace Task15
{
    class Bicycle : Vehicle
    {
        public override void Drive(double km)
        {
            Millage += km;
        }
    }
}
