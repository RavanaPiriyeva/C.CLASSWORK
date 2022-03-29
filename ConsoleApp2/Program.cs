using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region task1
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[size];
            //for(int i=0; i< numbers.Length; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            ////int[] numbers = { 1, 2, 8, 5 };
            //int max = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (max < numbers[i])
            //    {
            //        max = numbers[i];
            //    }
            //}
            //Console.WriteLine(max);
            #endregion


            #region task 2 
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new string[size];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //string[] name = { "ayten", "revane", "arzu" };
            //int max = 0;
            //string result = "";
            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (name[i].Length > max)
            //    {
            //        max = name[i].Length;
            //        result = name[i];
            //    }
            //}
            //Console.WriteLine(result);
            #endregion
            #region task3

            //Console.WriteLine("Deyer daxil edin: ");
            // int number = Convert.ToInt32(Console.ReadLine());
            // //int number = 2;

            //if ((Math.Log(number , 2)) % Math.Log(2 , 2) == 0)
            // {
            //     Console.WriteLine("quvetidir");
            // }
            // else
            // {
            //     Console.WriteLine("deyil");
            // }

            #endregion

            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[size];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int count = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //        count++;
            //}

            //int[] newNumbers = new int[count];
            //int j = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        newNumbers[j] = numbers[i];
            //        j++;


            //    }

            //}
            //Console.WriteLine("Wanted Numbers:");
            //foreach (var item in newNumbers)
            //{
            //    Console.WriteLine(item);
            //}




            //string numbersx = Console.ReadLine();
            //int number = Convert.ToInt32(numbersx);
            //bool num = Cut(number);
            //Console.WriteLine(num);


            int[] numbers = { 1, 2, 5, 6, };
            int eded = 9;
            int result = Nums(numbers, eded);
            Console.WriteLine(result);
          

        }
       
        static int Nums (int[] arr , int number)
        {
            for(int i =0; i<arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    return i;
                }
              
            }
            return -1;
        }
    }
    
}
