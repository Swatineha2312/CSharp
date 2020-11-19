using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2020, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine(now); /*or use this->*/Console.WriteLine(now.ToString());
            //o/p: 19 / 11 / 2020 10:41:55 PM
            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(tomorrow);
            Console.WriteLine(yesterday);

            var timeSpan = new TimeSpan(1, 2, 3);
            //Properties
            Console.WriteLine(timeSpan.Hours);
            Console.WriteLine(timeSpan.Minutes);
            Console.WriteLine(timeSpan.TotalMinutes);
            //Add Substract
            Console.WriteLine(timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(timeSpan.Subtract(TimeSpan.FromMinutes(8)));
            //ToString
            Console.WriteLine(timeSpan.ToString());

        }
    }
}

