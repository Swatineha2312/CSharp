/*4- Your job is to write a program for a speed camera.
For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. 
If the user enters a value less than the speed limit, program should display Ok on the console. 
If the value is above the speed limit, the program should calculate the number of demerit points. 
For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
If the number of demerit points is above 12, the program should display License Suspended. */

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Speed Limit");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Car Speed");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
                Console.WriteLine("Ok");
            else
            {
                const int divisionNumber = 5;
                int speedDifference = carSpeed - speedLimit;
                int speedCalculated = speedDifference / divisionNumber;
                if (speedCalculated < 13)
                {
                    switch (speedCalculated)
                    {
                        case 1:
                            Console.WriteLine("$100 Fine");
                            break;
                        case 2:
                            Console.WriteLine("$200 Fine");
                            break;
                        case 3:
                            Console.WriteLine("$300 Fine");
                            break;
                        case 4:
                            Console.WriteLine("$400 Fine");
                            break;
                        case 5:
                            Console.WriteLine("$500 Fine");
                            break;
                        case 6:
                            Console.WriteLine("$600 Fine");
                            break;
                        case 7:
                            Console.WriteLine("$700 Fine");
                            break;
                        case 8:
                            Console.WriteLine("$800 Fine");
                            break;
                        case 9:
                            Console.WriteLine("$900 Fine");
                            break;
                        case 10:
                            Console.WriteLine("$1000 Fine");
                            break;
                        case 11:
                            Console.WriteLine("$1100 Fine");
                            break;
                        case 12:
                            Console.WriteLine("$1200 Fine");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("License Suspended");
                }
            }
        }
    }
}

