/*2- Write a program that reads a text file and displays the longest word in the file.*/
using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           var path = @"D:\Swati\C#Training\Filetext.txt";
            int wordLength = 0; var longestWord = "";
            var wordNum = new List<string>(System.IO.File.ReadAllText(path).Split(' '));
            //Console.WriteLine("The word count in file is:" + wordNum.Count());
            //Hi Training this is a test file.                        
            foreach (var word in wordNum)
            {
                if (word.Length > wordLength)
                {
                    longestWord = word;
                    wordLength = word.Length;
                }
            }
            Console.WriteLine(longestWord);
        }
    }
}

