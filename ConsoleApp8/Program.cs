using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adi daxil et:");
            string name = Console.ReadLine();
            Console.WriteLine("emaili daxil edin :");
            string emaile = Console.ReadLine();
            Console.WriteLine("sifreni daxil et:");
            string pasword = Console.ReadLine();

            User user = new User(name, emaile) ;

            user.ShowInfo();
        }
    }
}
