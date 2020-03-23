using System;
using System.Threading;

namespace Logger.Lesson2
{
	class Program
	{
		static void Main(string[] args)
		{
			Log("Program Started");
			Thread.Sleep(3000); //Simulating work by having the program sleep for 3 seconds
			Log("Program Ended");
		}
		static void Log(string msg)
		{
			Console.WriteLine($"{DateTime.Now} {msg}");
		}
	}
}