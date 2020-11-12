/*2- Write a program which takes two numbers from the console and displays the maximum of the two.*/
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber < secondNumber)            
                Console.WriteLine("The maximum of the two is: "+secondNumber);           
            else            
                Console.WriteLine("The maximum of the two is: " + firstNumber);            
        }
    }
}