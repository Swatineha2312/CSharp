/*5- Write a program and ask the user to enter a series of numbers separated by comma. 
 * Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.)*/
using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of numbers separated by comma.For example, 5, 3, 8, 1, 4");
            string input = Console.ReadLine();
            var intlist = input.Split(','); 
            int[] myInts = Array.ConvertAll(intlist, int.Parse);
            var maxNumber = myInts.Max();
            Console.WriteLine("highest is: " + maxNumber);
        }
    }

}
