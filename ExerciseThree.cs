/*Write a program and ask the user to enter the width and height of an image.
 Then tell if the image is landscape or portrait. */
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of the image");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the height of the image");
            int height = Convert.ToInt32(Console.ReadLine());

            if (width==height)            
                Console.WriteLine("The image is Portrait ");           
            else            
                Console.WriteLine("The image is Landscape");            
        }
    }
}