using System.Threading;

namespace Lesson5.Solution0
{
	class Program
	{
		static void Main(string[] args)
		{
			Logger.Log("Program Started");
			Logger.LogToFile(".\\log.txt","Program Started");
			
			Thread.Sleep(3000); //Simulating work by having the program sleep for 3 seconds
			
			Logger.Log("Program Ended");
			Logger.LogToFile(".\\log.txt", "Program Ended");
		}
	}
}