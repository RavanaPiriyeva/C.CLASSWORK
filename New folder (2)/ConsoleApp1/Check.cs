using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Check
    {
       public static bool IsPrime(int num)
        {
           for (int i = 2; i<num; i++)
            {
                if(num%i==0 )
                {
                    return false;
                }
            }
            return true;
        }


       public  static bool IsPowOfTwo(int num)
        {
           
            if (num % 2 == 0) { 
                while (num / 2 > 1)
                {
                num = num / 2;
                }
            }
            if (num == 2)
            {
                return true;
            }
            return false;
         


        }
    }
}
