using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the hyphen separted numbers");
            string hyphenNumbers = Console.ReadLine();
            String[] numberArray = hyphenNumbers.Split('-');
            var numberList = new List<int>();
            foreach (var n in numberArray)
                numberList.Add(Convert.ToInt32(n));

            numberList.Sort();
            var isConsecutive = true;
            for (var i = 1; i < numberList.Count; i++)
            {
                if (numberList[i] != numberList[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);

        }
    }
}