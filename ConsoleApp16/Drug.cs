using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{
    class Drug
    {
        public Drug()
        {
            _unikalid++;
            UnikalId = _unikalid;
        }

        public static int _unikalid;
        public string Name;
        public  int UnikalId { get; set; }
        public TypeDrung Type;
        public double Price;
        public int Count;
        public override string ToString()
        {
            return $" Id:{UnikalId}      Name:{Name}      Price:{Price}     Count:{Count}"; 
        }



     


    }
}
