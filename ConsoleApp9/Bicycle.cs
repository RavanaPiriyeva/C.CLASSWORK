using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Bicycle : IDiravable, IVehicle
    {
        public string Brand { get ; set ; }
        public string Model { get ; set ; }
        public int Millage { get ; set; }

        public void Drive(int km)
        {
            Millage = +Millage;
        }
    }
}
