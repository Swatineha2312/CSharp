/*3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
 * A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
 * If the user does not provide any values, consider it as invalid time.  */
using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 19:00)");
            string timeValue = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(timeValue))
            {
                Console.WriteLine("Invalid time");
                return;
            }
            var components = timeValue.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid time");
                return;
            }
            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }

        }
    }
}

