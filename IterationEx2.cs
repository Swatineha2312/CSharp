/*2- Write a program and continuously ask the user to enter a number or "ok" to exit. 
 * Calculate the sum of all the previously entered numbers and display it on the console.*/
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            { 
                Console.WriteLine("Enter a number or type Ok to exit");
                String userValue = Console.ReadLine();
                if (userValue == "ok")
                { break; }
                else
                {
                    int input = Int32.Parse(userValue);
                    sum += input;
                    Console.WriteLine("Sum of entered number is:" + sum);
                    continue;
                }
            }
        }
    }
}
