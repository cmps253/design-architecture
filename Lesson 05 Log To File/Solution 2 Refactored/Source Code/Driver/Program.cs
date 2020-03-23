using System.Threading;

namespace Lesson5.Solution2Refactored
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleLogger.Log("Program Started");
			FileLogger.Log(".\\log.txt","Program Started");
			
			Thread.Sleep(3000); //Simulating work by having the program sleep for 3 seconds
			
			ConsoleLogger.Log("Program Ended");
			FileLogger.Log(".\\log.txt", "Program Ended");
		}
	}
}