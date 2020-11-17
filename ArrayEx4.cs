/*4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
 * The list of numbers may include duplicates. Display the unique numbers that the user has entered.*/

using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter number or type Quit to exit");
                var input = Console.ReadLine();
                if (input == "Quit")
                    break;

                var numberInput = Int32.Parse(input);
                numbers.Add(numberInput);
            }

            var uniqueNumbers = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniqueNumbers.Contains(number))
                    uniqueNumbers.Add(number);
            }
            Console.WriteLine("The unique numbers entered are:");
            foreach (var n in uniqueNumbers)
                Console.WriteLine(n);
        }
    }
}