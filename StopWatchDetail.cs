Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should provide two methods: 
Start and Stop. We call the start method first, and the stop method next. Then we ask the stopwatch about the 
duration between start and stop. Duration should be a value in TimeSpan. Display the duration on the console. 
We should also be able to use a stopwatch multiple times. So we may start and stop it and then start and stop it again.
Make sure the duration value each time is calculated properly. We should not be able to start a stopwatch twice in a row
(because that may overwrite the initial start time). So the class should throw an InvalidOperationException if 
its started twice. 

//Stopwatch.cs

using System;

namespace CSharpIntermediate
{
    public class Stopwatch
    {
        DateTime StartTime;
        Boolean IsRunning;
        DateTime StopTime;

        public void Start()
        {
            if (IsRunning)
            {
                throw new InvalidOperationException("Can't start already running.");
            }
            else
            {
                IsRunning = true;
                StartTime = DateTime.Now;
                Console.WriteLine("The start time is: " + StartTime);
            }
        }
        public void Stop()
        {
            if (!IsRunning)
            {
                throw new InvalidOperationException("Can't stop not running.");
            }
            else
            {
                IsRunning = false;
                StopTime = DateTime.Now;
                Console.WriteLine("The stop time is: " + StopTime);
            }
        }
        public void ElapsedTime()
        {
            if (IsRunning)
            {
                var startTimeDifference=DateTime.Now - StartTime;
                Console.WriteLine("The elapsed start time is:" + startTimeDifference);
            }
            else
            {
                var stopTimeDifference= StopTime - StartTime;
                Console.WriteLine("The elapsed stop time is:" + stopTimeDifference);
            }
        }
    }
}


//Program.cs

using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var Stopwatch = new Stopwatch();
            int choice;
            do
            {
                Console.WriteLine("Select the choice\n 1.Start Timer\n 2.Stop Timer\n 3.Read Timer\n 0.Quit");
                choice = Convert.ToInt32(Console.ReadLine());          
                switch (choice)
                {
                    case 1:
                        Stopwatch.Start();
                        break;
                    case 2:
                        Stopwatch.Stop();
                        break;
                    case 3:                        
                        Stopwatch.ElapsedTime();
                        break;                   
                }
            } while (choice != 0);
       }
    }
}
