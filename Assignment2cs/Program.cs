using System;

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
            //bool ok = true;
            //int total = 0;
            //while (ok)
            //{
            //    Console.Write("enter a number or \"ok\" to exit: ");
            //    string input = Console.ReadLine();
            //    if (input == "ok")
            //    {
            //        ok = true;
            //    }
            //    else
            //    {
            //        int tadd = Int32.Parse(input);
            //        total += tadd;
            //        Console.WriteLine(total);
            //        continue;
            //    }
            //}

            //Write a program and ask the user to enter a number.
            //Compute the factorial of the number and print it on the console.
            //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            Console.Write("Enter a number: ");
            string answer = Console.ReadLine();
            int length = Int32.Parse(answer);
            int total = length;
            for (int i = length; i > 1; i--)
            {
                total *= (i - 1);
            }
            Console.WriteLine("{0}! = {1}", length, total );
        }
    }
}
