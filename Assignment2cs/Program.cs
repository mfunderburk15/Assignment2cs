using System;
using System.Linq;

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
            //Console.Write("Enter a number: ");
            //string answer = Console.ReadLine();
            //int length = Int32.Parse(answer);
            //int total = length;
            //for (int i = length; i > 1; i--)
            //{
            //    total *= (i - 1);
            //}
            //Console.WriteLine("{0}! = {1}", length, total );

            //Write a program that picks a random number between 1 and 10.
            //Give the user 4 chances to guess the number.
            //If the user guesses the number, display “You won"; otherwise, display “You lost".
            //(To make sure the program is behaving correctly, you can display the secret number on the console first.)

            //Random rnd = new Random();
            //int mysteryNumber = rnd.Next(1, 10);
            //Console.WriteLine(mysteryNumber);
            //for (int chance = 4; chance > 0; chance--)
            //{
            //    Console.WriteLine("Pick a number between 1 and 10 you have {0} chance(s) left: ", chance);
            //    String guess = Console.ReadLine();
            //    int num = Int32.Parse(guess);
            //    if (num == mysteryNumber)
            //    {
            //        Console.WriteLine("You Won!");
            //        break;
            //    }
            //    else if(chance == 1)
            //    {
            //        Console.WriteLine("You Lose...");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("nope");
            //        continue;
            //    }
            //}

            //Write a program and ask the user to enter a series of numbers separated by comma.
            //Find the maximum of the numbers and display it on the console.
            //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
            Console.Write("Enter a series of numbers separated by a comma: ");
            string s = Console.ReadLine();
            string[] sarr= s.Split(',');
            int max = Convert.ToInt32(sarr[0]);
            foreach (string num in sarr)
            {
                int number = Convert.ToInt32(num);
                if(number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine(max);
            //int[] IntArr = Array.ConvertAll(sarr, s => Int32.Parse(s));
            //Console.WriteLine(IntArr.Max());

        }
    }
}
