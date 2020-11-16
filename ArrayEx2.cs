/*2- Write a program and ask the user to enter their name. Use an array to reverse the name and 
 * then store the result in a new string. Display the reversed name on the console.*/
using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String input, reverse = "";
            Console.WriteLine("Enter the name");
            input = Console.ReadLine();
            var length = input.Length - 1;
            while (length >= 0)
            {
                reverse = reverse + input[length];
                length--;
            }
            Console.WriteLine("Reverse of the word is:"+reverse);
        }
    }
}