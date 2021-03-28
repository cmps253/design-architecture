using System.Threading;

namespace Lesson6.Solution0
{
	class Program
	{
		static void Main(string[] args)
		{
			Log(".\\log.txt","Program Started");
			
			Thread.Sleep(3000); //Simulating work by having the program sleep for 3 seconds

			Log(".\\log.txt", "Program Ended");
		}

		static void Log(string msg, string fileName)
		{
			ConsoleLogger.Log(msg);
			FileLogger.Log(fileName, msg);
		}
	}
}