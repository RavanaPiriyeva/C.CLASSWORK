using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Milk:Product
    {

        public Milk(string name):base(name)
        {

        }
        public double Volume;
        public int FatRate;


        public override void Sell()
        {
            base.Sell();
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}    Volume:{Volume}      Fatrate:{FatRate}";
        }

    }
}
