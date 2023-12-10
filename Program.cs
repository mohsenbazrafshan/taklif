using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mohsen_bazrafshabn
{
    class Program
    {
        static void Main(string[] args)
        {
            //int minute=0;
            //int sum=0;
            //int avg;
            //for (int i = 1; i <= 30; i++)
            //{
            //    Console.WriteLine("please rate the day {0} enter in minute=",i);
            //    minute = int.Parse(Console.ReadLine());
            //    sum = sum + minute;
            //}
            //Console.WriteLine("you studied for {0} minutes a week", sum);
            //Console.WriteLine(minute = minute / 60);
            //avg = minute;
            //Console.WriteLine(avg = avg / 30);


            //int month;
            //int guess;
            //int score = 5;
            //Console.Write("enter number your month");
            //month = int.Parse (Console.ReadLine());
            //Console.Clear();
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write("your guess");
            //    guess = int.Parse(Console.ReadLine());
            //    if (guess == month)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine("you win");
            //        Console.WriteLine("your score:{0}", score);
            //        break;
            //    }
            //    else
            //    {
            //        score -= 1;
            //        Console.WriteLine("try again?");
            //    }
            //}


            //for (int k = 10; k <= 15; )
            //{
            //    Console.WriteLine(k);
            //    k++;
            //}


            //int i = 1;
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //for (;i <= 10; i++)
            //{
            //    Console.WriteLine("iran");
            //    i++;
            //}


            //Console.ForegroundColor = ConsoleColor.Cyan;
            //for (; ; )
            //{
            //    Console.WriteLine("iran");
            //}


            //float sum = 0, avg;
            //int conut = 0;
            //Console.Write("enter mark{0}=", conut + 1);
            //float mark = float.Parse (Console.ReadLine());
            //while (mark >= 0)
            //{
            //    sum = sum + mark;
            //    conut++;
            //    Console.Write("enter mark {0} = ", conut + 1);
            //    mark = float.Parse(Console.ReadLine());
            //}
            //avg = sum / conut;
            //Console.WriteLine(avg);


            //int i = 99;
            //while (i>=1)
            //{
            //    Console.WriteLine(--i);  
            //}


            //int i = 100;
            //while (i<=1000)
            //{
            //    Console.WriteLine(++i); 
            //}


            //int hour;
            //int max,min;
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("\nenter hour");
            //hour = int.Parse(Console.ReadLine());
            //max = hour;
            //min = hour;
            //while (hour > 0)
            //{
            //    if (hour > max)
            //    {
            //        max = hour; 
            //    }
            //    if (hour < min)
            //    {
            //        min = hour; 
            //    }
            //    Console.WriteLine("\nenter 0 for exit");
            //    Console.Write("enter hour");
            //    hour = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("max = {0}   min = {1}", max,min);


            //float a;
            //float b;
            //int num;
            //int numm=0;
            //Console.WriteLine("-------console calculator-------");
            //Console.WriteLine("1.enter a , b:");
            //Console.WriteLine("2.calc a + b=");
            //Console.WriteLine("3.calc a * b=");
            //Console.WriteLine("4. calc a / b=");
            //Console.WriteLine("5. clac a - b=");
            //Console.WriteLine("6.exit:");
            //Console.WriteLine("----------------");
            //Console.WriteLine("a=");
            //Console.SetCursorPosition(5, 8);
            //Console.WriteLine("b=");
            //Console.WriteLine("----------------");
            //Console.WriteLine("enter number(1-6):");
            //Console.SetCursorPosition(2, 8);
            //a = float.Parse(Console.ReadLine());
            //Console.SetCursorPosition(7, 8);
            //b = float.Parse(Console.ReadLine());
            //while (numm <= 6)
            //{
            //    Console.SetCursorPosition(18, 10);
            //    num = int.Parse(Console.ReadLine());
            //    while (num >= 1 && num <= 6)
            //    {
            //        if (num == 1)
            //        {
            //            Console.SetCursorPosition(15, 1);
            //            Console.Write(a);
            //            Console.SetCursorPosition(20, 1);
            //            Console.Write(b);
            //        }
            //        if (num == 2)
            //        {
            //            Console.SetCursorPosition(13, 2);
            //            Console.Write(a + b);
            //        }
            //        if (num == 3)
            //        {
            //            Console.SetCursorPosition(13, 3);
            //            Console.Write(a * b);
            //        }
            //        if (num == 4)
            //        {
            //            Console.SetCursorPosition(14, 4);
            //            Console.Write(a / b);
            //        }
            //        if (num == 5)
            //        {
            //            Console.SetCursorPosition(14, 5);
            //            Console.Write(a - b);
            //        }
            //        if (num == 6)
            //        {
            //            System.Environment.Exit(0);
            //        }
            //        break;
            //    }
            //}


            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write("{0,4}", i * 1);
            //    Console.Write("{0,4}", i * 2);
            //    Console.Write("{0,4}", i * 3);
            //    Console.Write("{0,4}", i * 4);
            //    Console.Write("{0,4}", i * 5);
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //     Console.Write("{0 , 4}", i * j);   
            //    }
            //    Console.WriteLine();
            //}


            Console.WriteLine("enter the money: ");
            int money = int.Parse(Console.ReadLine());
            for (int x = 0; x <= money / 2000; x++)
            {
                for (int y = 0; y <= money / 5000; y++)
                {
                    for (int z = 0; z < money / 10000; z++)
                    {
                        if (2000 * x + 5000 * y == money)
                            Console.WriteLine("x={0}, y={1}, z={2}", x, y, z);
                    }

                }
            }




            Console.ReadKey();


        }

    }
}

