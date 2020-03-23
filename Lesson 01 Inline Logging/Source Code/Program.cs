using System;
using System.Threading;

namespace Logger.Lesson1
{
	class Program
	{
		static void Main(string[] args) 
		{
			Console.WriteLine($"{DateTime.Now} Program Started");
			Thread.Sleep(3000); //Simulating work by having the program sleep for 3 seconds
			Console.WriteLine($"Program Ended"); //programmer forgot to include time stamp
		}
	}
}