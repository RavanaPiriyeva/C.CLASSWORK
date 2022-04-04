using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Check test = new Check();
            Console.WriteLine(Check.IsPrime(3));
            Console.WriteLine(Check.IsPowOfTwo(33));
        }
    }
}
