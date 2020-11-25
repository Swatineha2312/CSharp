using System;
using System.Threading;

/*Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
provide two methods: Start and Stop. We call the start method first, and the stop method next.
Then we ask the stopwatch about the duration between start and stop. Duration should be a
value in TimeSpan. Display the duration on the console.
We should also be able to use a stopwatch multiple times. So we may start and stop it and then
start and stop it again. Make sure the duration value each time is calculated properly.
We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
start time). So the class should throw an InvalidOperationException if its started twice.
1
Educational tip: The aim of this exercise is to make you understand that a class should be
always in a valid state. We use encapsulation and information hiding to achieve that. The class
should not reveal its implementation detail. It only reveals a little bit, like a blackbox. From the
outside, you should not be able to misuse a class because you shouldn’t be able to see the
implementation detail. */
					
public class Program
{
	public static void Main()
	{
		for(int i = 0; i<10; i++){
			Thread.Sleep(300);
			Console.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmss"));
		}
		var stopWatch = new Stopwatch();
		Console.WriteLine("Type start to start..");
		var inputString = Console.ReadLine();
		if(inputString == "start"){
			stopWatch.Start();
		}else{
			Console.WriteLine("Type start to start..");
			while(Console.ReadLine()!= "start"){
				Console.WriteLine("Type start to start..");
			}
		}
		
		Console.WriteLine("Type stop to stop..");
		inputString = Console.ReadLine();
		if(inputString == "stop"){
			stopWatch.Stop();
			Console.WriteLine("Stopped at {0}", stopWatch.StopTime.ToString("yyyyMMddHHmmss"));
			
		}else{
			Console.WriteLine("Type stop to stop..");
			while(Console.ReadLine()!= "stop"){
				Console.WriteLine("Type stop to stop..");
			}
			stopWatch.Stop();
			Console.WriteLine("Stopped at {0}", stopWatch.StopTime.ToString("yyyyMMddHHmmss"));
		
		}
	}
}

public class Stopwatch
{
	public DateTime StartTime {get; set;}
	public DateTime StopTime {get; set;}
	public bool IsRunning {get; set;}
	
	public void Start()
	{
		if(!IsRunning){
			IsRunning = true;
			StartTime = DateTime.Now;
			Console.WriteLine("DateTime Now: {0}", DateTime.Now.ToString("yyyyMMddHHmmss"));
			Console.WriteLine("started at {0}", StartTime.ToString("yyyyMMddHHmmss"));
		}else{
			throw new InvalidOperationException("Stopwatch is already running");
		}
	}
	
	public void Stop()
	{
		if(IsRunning){
			IsRunning = false;
			StopTime = DateTime.Now;
			Console.WriteLine("DateTime Now: {0}", DateTime.Now.ToString("yyyyMMddHHmmss"));
			Console.WriteLine("Stopped at {0}", StopTime.ToString("yyyyMMddHHmmss"));
			Console.WriteLine("You stopped after {0}", StopTime-StartTime);
		}else{
			throw new InvalidOperationException("Stopwatch can't be stopped: start it first.");
		}
	}
	
	
	
	
}