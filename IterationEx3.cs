/*3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. 
 * For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.*/
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to calculate factorial");
            int userValue = Int32.Parse(Console.ReadLine());
            int i, j = 1;
            for (i = userValue; i >= 1; i--)
            {
                j *= i;
            }
            Console.WriteLine("The factorial value of given number "+userValue+" is: "+j);
        }
    }
}