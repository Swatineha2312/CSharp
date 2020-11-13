/*1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
Display the count on the console.*/
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberThree = 3;           
            int i, count = 1;
            Console.WriteLine("The number divisible by 3 are:");
            for (i = 1; i <= 100; i++)
            {
                if (i % numberThree == 0)
                {                    
                    Console.WriteLine(i);
                    count++;
                }             
            }
            Console.WriteLine("The total count of the numbers between 1 and 100 are divisible by 3 with no remainder is" + (count-1));
        }
    }
}