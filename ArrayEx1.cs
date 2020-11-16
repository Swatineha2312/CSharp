/*1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
    If no one likes your post, it doesn't display anything.
    If only one person likes your post, it displays: [Friend's Name] likes your post.
    If two people like your post, it displays: [Friend 1]
and[Friend 2] like your post.
If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.*/

using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var fbName = new List<String>();
            while (true)
            {
                Console.WriteLine("Enter the name");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                else
                    fbName.Add(input);
            }
            switch (fbName.Count)
            {
                case 0:
                    Console.WriteLine("Nobody likes your post");
                    break;
                case 1:
                    Console.WriteLine("{0} likes your post",fbName[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} likes your post", fbName[0], fbName[1]);
                    break;
                default:             
                    Console.WriteLine("{0},{1} and {2} likes your post", fbName[0], fbName[1], (fbName.Count-2));
                    break;
            }
        }
    }
}