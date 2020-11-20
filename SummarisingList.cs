using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is eg of Summarising list in string and making it long string sentence to test the string functions.";
            var summary = Summarizing(sentence);
            Console.WriteLine(summary);
        }
        static string Summarizing(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
                return text;

            var splitWords = text.Split(' ');
            var totalCharaters = 0;
            var summaryWords = new List<string>();

            foreach (var words in splitWords)
            {
                summaryWords.Add(words);
                totalCharaters += words.Length + 1;
                if (totalCharaters > maxLength)
                    break;
            }
            return String.Join(" ", summaryWords) + "....";
        }
    }
}

