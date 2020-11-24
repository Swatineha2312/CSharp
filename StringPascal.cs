/*4- Write a program and ask the user to enter a few words separated by a space. 
 * Use the words to create a variable name with Pascal Case. For example, if the user types: "number of students", 
* display "Number of Students". Make sure that the program is not dependent on the input. 
* So, if the user types "NUMBER OF STUDENTS", the program should still display "Number of Students".*/
using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter few words separated by space");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid");
                return;
            }
            var variable = "";
            foreach (var n in input.Split(' '))
            {
                var wordsInPascal = char.ToUpper(n[0]) + n.ToLower().Substring(1);
                variable +=wordsInPascal;
            }
            Console.WriteLine(variable);
        }
    }
}

