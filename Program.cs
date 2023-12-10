using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string mystr= Console.ReadLine();
            ////for (int i = 0; i < mystr.Length; i++)
            ////{
            //// Console.WriteLine(mystr[i]);
            ////}
            ////ravesh2
            //foreach (char item in mystr)
            //{
            //  Console.WriteLine(item);	
            //}
            //for (int i =mystr.Length-1; i >= 0; i--)
            //{
            // Console.WriteLine(mystr[i]);
            //}


            //string name = "nima";
            //int[] numeber = new int[5] { 10, 20, 30, 40, 50 };
            //name = "mmad";
            //numeber[3] = 55;
            //for (int i = 0; i < 4; i++)
            //    Console.WriteLine("your name is {0} and your {1}",name[i],numeber[i]);
            //////foreach (char item in numeber)
            //{
            //    Console.WriteLine(item); 
            //}

            //foreach (int item in name)
            //{
            //    Console.WriteLine(item); 
            //}

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(numeber[i]);
            //}


            //int[]price=new int[50];
            //for (int i = 0; i < 50; i++)
            //{
            //    Console.Write("enter the price of {0} the product : ", i + 1);
            //    int temp = int.Parse(Console.ReadLine());
            //    if (temp > 0)
            //        price[i] = temp;
            //    else
            //        break;
            //}
            //    Console.WriteLine("product price plus VAT ");
            //    Console.Clear();
            //    for (int j = 0; j < price.Length; j++)
            //    {                    
            //        price[j] = (int)(price[j] * 0.09 + price[j]);                    
            //        if
            //            (price[j] > 0)
            //            Console.WriteLine("product{0} : {1}", j, price[j]);
            //    }





            string[] car = { "prid", "mazda", "renault", "peugeot", "toyota" };
            long[] price = { 100, 200, 300, 400, 5000 };
            Console.Write("please enter car name for liner search : ");
            string item = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < car.Length; i++)
                if (item == car[i])
                {
                    found = true;
                    Console.WriteLine("{0} found in {1}", item, i);
                    Console.WriteLine("price {0} = {1}", item, price[i]);
                    break;
                }
            if (found == false)
            {
                Console.WriteLine("item is not found");
            }


            //int[] number = { 20, 18, 10, 15, 50, 80, 10, 37 };
            //foreach (int item in number)
            //{
            //    Console.Write(item+"/t");
            //}
            //Array.Sort(number);
            //Array.Reverse(number);
            //Console.WriteLine(Array.BinarySearch(number,10));





            Console.ReadKey();
        }
    }
}
