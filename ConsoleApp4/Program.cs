using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double price = Convert.ToDouble(Console.ReadLine());
            int count = Convert.ToInt32(Console.ReadLine());
            double totalincome = Convert.ToDouble(Console.ReadLine());
            double volume = Convert.ToDouble(Console.ReadLine());
            int fatrate = Convert.ToInt32(Console.ReadLine());

            Milk milk = new Milk(name)
            {
                Price = price,
                Count =count,
                TotalIncome = totalincome ,
                Volume=volume,
                FatRate=fatrate
            };
            milk.Sell();


            Console.WriteLine(milk.GetInfo());
            //milk.Sell();
        }
    }
}
