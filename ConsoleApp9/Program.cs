using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Brand = "bmw";
            car.Model = "FVGDFGH";
            car.Millage = 15;
            car.CurrentFuel = 200;
            car.FuelForKM = 20;
            car.Drive(8);
            Console.WriteLine( car.Brand +"  " +car.Model+"   "+ car.CurrentFuel+"   "+ car.FuelForKM + "  " +car.Millage);
               
        }
    }
}
