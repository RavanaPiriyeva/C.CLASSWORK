using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {

            string test = "salam necesen";
            string word = "salam";
            Console.WriteLine(Check.CustomContains(test, word));
            Console.WriteLine(Check.CustomContains(word, 'x'));
        }
    }
}
