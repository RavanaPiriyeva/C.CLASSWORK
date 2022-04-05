using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{
    class Pharmacy
    {
        public Pharmacy()
        {
            UnikalId++;
        }
        public string Name;
        public static int UnikalId;
        private Drug[] _drugs = new Drug[0];
        public Drug[] Drugs { get { return _drugs; } }

        public override string ToString()
        {
            return $"Name:{Name}   Id:{UnikalId}";

        }
        public void AddDrug(Drug drug)
        {
            Array.Resize(ref _drugs, _drugs.Length + 1);
            _drugs[_drugs.Length - 1] = drug;
        }

        public void DrugList()
        {
            foreach(var item in _drugs)
            {
                Console.WriteLine(item);
            }

           
        }
        public void SaleDrug(string name, int count, double money)
        {
            bool check =false  ;
            foreach( var item in _drugs)
            {
                if (item.Name ==name && item.Count >= count   && item.Price<=money )
                {
                    Console.WriteLine("stais bas verir");
                    check = true;
                }
                
            }
            if (!check)
            {
                Console.WriteLine("satis bas vermir!!!!");
                
            }
        }
    }
}
