﻿using System;

namespace Assignment2cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.
            //int count = 0;
            //for (int i = 1; i <=100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //Write a program and continuously ask the user to enter a number or "ok" to exit.
            //Calculate the sum of all the previously entered numbers and display it on the console.
            bool ok = true;
            int total = 0;
            while (ok)
            {
                Console.Write("enter a number or \"ok\" to exit: ");
                string input = Console.ReadLine();
                if (input == "ok")
                {
                    ok = !ok;
                }
                else
                {
                    int add = Int32.Parse(input);
                    total += add;
                    Console.WriteLine(total);
                    continue;
                }
            }

        }
    }
}
