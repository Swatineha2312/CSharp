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
            Console.WriteLine("The unique numbers entered are:");
            foreach (var n in GuessUniqueNumbers(numbers))
                Console.WriteLine(n);
        }

        public static List<int> GuessUniqueNumbers(List<int> numbers)
        {
            var uniqueNumbers = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniqueNumbers.Contains(number))
                    uniqueNumbers.Add(number);
            }
            return uniqueNumbers;
        }
    }
}