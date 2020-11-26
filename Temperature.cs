//Program.cs
using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Select the converter");
            Console.WriteLine("1.Celcius To Faherenheit");
            Console.WriteLine("2.Faherenheit To Celcius");
            Console.WriteLine(":");

            string selection = Console.ReadLine();
            double F, C = 0;
            switch (selection)
            {
                case "1":
                    Console.WriteLine("Please enter the celcius temperature");
                    F = TemperatureConverter.CelciusToFahrenheit(Console.ReadLine());
                    Console.WriteLine("Temperature in Fahrenheit:"+ F);
                    break;
                case "2":
                    Console.WriteLine("Please enter the faherenheit temperature");
                    C = TemperatureConverter.FahrenheitToCelcius(Console.ReadLine());
                    Console.WriteLine("Temperature in Celcius:"+ C);
                    break;
                default:
                    Console.WriteLine("Please select");
                    break;
            }          
        }
    }
}


//TemperatureConverter.cs
using System;

namespace CSharpIntermediate
{
    class TemperatureConverter
    {
        public static double CelciusToFahrenheit(string temperatureC)
        {
            double celcius = Double.Parse(temperatureC);
            double faherenheit = (celcius * 9 / 5) + 32;
            return faherenheit;
        }
        public static double FahrenheitToCelcius(string temeratureF)
        {
            double faherenheit = Double.Parse(temeratureF);
            double celcius = (faherenheit - 32) * 5 / 9;
            return celcius;
        }
    }
}
