/*4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
 * If the user guesses the number, display “You won"; otherwise, display “You lost". 
* (To make sure the program is behaving correctly, you can display the secret number on the console first.)*/
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int i, randomNumber = 1;
            for (i = 1; i <= 4; i++)
            {
                Console.WriteLine("Guess the number");
                int userValue = Int32.Parse(Console.ReadLine());
                randomNumber = random.Next(11);
                Console.WriteLine(randomNumber);
                if (randomNumber == userValue)
                {
                    Console.WriteLine("You Won");
                }
                else
                {
                    Console.WriteLine("You lost");
                }
            }

        }
    }
}
