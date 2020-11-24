/*5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. 
 * So, if the user enters "inadequate", the program should display 6 on the console. */
using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any word");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid");
                return;
            }
            var charList = new List<char>(new char[] { 'a', 'i', 'e', 'o', 'u' });
            var count = 0;
            foreach (var n in input)
            {
                if (charList.Contains(n))
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}

