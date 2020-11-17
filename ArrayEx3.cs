/*3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message 
 * and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
* and display the result on the console.*/

using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter the unique number");
                var input = Int32.Parse(Console.ReadLine());
                if (numbers.Contains(input))
                {
                    Console.WriteLine("You can't display same numbers. Mention unique numbers");
                    continue;
                }
                numbers.Add(input);
            }
            numbers.Sort();
            foreach (var input in numbers)
                Console.WriteLine(input);
        }
    }
}