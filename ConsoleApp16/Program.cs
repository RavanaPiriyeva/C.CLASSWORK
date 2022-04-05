using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Drug drug1 = new Drug();
            drug1.Name = "aaaa";
            drug1.Price = 15;
            drug1.Count = 3;

            Drug drug2 = new Drug();
            drug2.Name = "bbbb";
            drug2.Price = 35;
            drug2.Count = 4;




            Drug drug3 = new Drug();
            drug3.Name = "ccccccc";
            drug3.Price = 50;
            drug3.Count = 2;

            Pharmacy pharmacy = new Pharmacy();
            pharmacy.AddDrug(drug1);
            pharmacy.AddDrug(drug2);
            pharmacy.AddDrug(drug3);



            Console.WriteLine("===================== List ======================");
            pharmacy.DrugList();
            Console.WriteLine("------------------------------------------------------------\n\n");



            pharmacy.SaleDrug("bbbb", 1, 30);
            pharmacy.SaleDrug("aaaa" ,1 ,30);
         
           // Console.WriteLine(Drug.UnikalId);
        }
    }
}
