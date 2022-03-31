using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Car: IVehicle, IDiravable
    { 
        public int CurrentFuel { get; set; }
        
        public int FuelForKM { get; set; }
        public string Brand { get ; set ; }
        public string Model { get ; set ; }
        public int Millage { get ; set ; }

        public  void Drive(int km)
        {
            if (km * FuelForKM <= CurrentFuel)
            {
                CurrentFuel = CurrentFuel - km * FuelForKM;
                Millage += km;
            }
            else
            {
                Console.WriteLine("Masin bu yolu gede bilmez!!!");
            }

        }

        //string Brand { get; set; }
        //string Model { get; set; }
        //int Millage { get; set; }



    }
}
