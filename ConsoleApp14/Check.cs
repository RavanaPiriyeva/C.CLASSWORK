using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    class Check
    {
        public static bool CustomContains(string sentence, string word)
        {
            var result = sentence.Split(' ');
                foreach( var item in result) { 
                if (item == word)
                {
                    return true;
                }
            }
            return false;
            

        }
        public static bool CustomContains(string word, char letter)
        {
           
            foreach (var item in word)
            {
                if (item == letter)
                {
                    return true;
                }
            }
            return false;


        }
    }
}
