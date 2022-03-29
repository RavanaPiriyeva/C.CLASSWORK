using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Product
    {


        public Product(string name)
        {
            this._name = name;
        }
        private string _name;
        public double Price;
        public int Count;
        public double TotalIncome;

        public virtual void Sell()
        {
            if (Count > 0)
            {
                Count =Count- 1;
                TotalIncome = TotalIncome + Price;
            }
            else
            {
                Console.WriteLine("Mehsul bitib ");
            }
        }

        public virtual string GetInfo()
        {
            return $" Name:{_name}     Price:{Price}   Count:{Count}  Totalincome{TotalIncome}";
        }

    }
}
