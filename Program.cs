using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mohsen.bazrafshan
{
    class Program
    {
        static void Main(string[] args)
        {
 
        
            //string[] name = new string [10] ;
            //for (int i = 0; i <= 9; i++)             
            //{
            //    Console.WriteLine("please enther the name {0} : ", i+1);
            //    name[i] = Console.ReadLine();                  
            //}
            

            //string[] computer = new string[5] { "cpu", "mainboard", "ram", "hdd", "dvd" };
            //int[] price = new int[5] { 100, 200, 300,   0, 500 };
            //computer[3] = "keyboard";
            //for (int i = 0; i <=4 ; i++)
            //{
            //    Console.WriteLine(computer[i] + "   " + price[i]); 
            //}
            //Console.SetCursorPosition(11,3);
            //price[3] = int.Parse(Console.ReadLine());


            //string[] week = { "saturday", "sunday", "monday", "tuesday", "wednesday", "thursday", "friday" };
            //Console.Write("enter the number one day of week  (1-7):");
            //byte num = byte.Parse(Console.ReadLine());
            //if ((num < 1) || (num > 7))
            //    Console.WriteLine("please enter right number");
            //else
            //    Console.WriteLine(week[--num]);
               
            
           

            //string[] week = { "saturday", "sunday", "monday", "tuesday", "wednesday", "thursday", "friday" };
            ////Console.WriteLine(week[0]);
            ////Console.WriteLine(week[1]);
            ////Console.WriteLine(week[2]);
            ////Console.WriteLine(week[3]);
            ////Console.WriteLine(week[4]);
            ////Console.WriteLine(week[5]);
            ////Console.WriteLine(week[6]);


            /////ravesh 2
            //for (int i = 0; i < week.Length; i++)
            //{
            //    Console.WriteLine(week[i]);                
            //}


            string[] computer = new string[5];
            long[] price = new long[5];
            long sumprice = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter the name of a computer part");
                computer[i] = (Console.ReadLine());
                Console.WriteLine("enter price of a computer part");
                price[i] = long.Parse(Console.ReadLine());
            }
            for (int i = 0; i < price.Length; i++)
            {
                sumprice += price[i];
                for (int j = 0; i < 5; i++)
                {
                    Console.WriteLine("{0}  {1}", computer[i], price[j]);
                    Console.WriteLine(sumprice);
                }
            }


            Console.ReadKey();

        }
    }
}


     
