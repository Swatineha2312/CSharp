using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int count = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(@"D:\Swati\C#Training\Exercises.docx");
            while ((line=file.ReadLine())!= null)
            {
                String[] words = line.Split(' ');
                count += words.Length;
            }
            Console.WriteLine("The number of words in the given file is:"+count);
            file.Close();
            
            /*or could use below logic*/
            
            var path = @"D:\Swati\C#Training\Filetext.txt";
            var wordNum = new List<string>(System.IO.File.ReadAllText(path).Split(' '));
            Console.WriteLine(wordNum.Count());
        }
    }
}
