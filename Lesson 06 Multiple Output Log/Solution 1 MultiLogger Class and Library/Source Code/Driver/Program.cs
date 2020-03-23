using System.Threading;

namespace Lesson6.Solution1
{
	class Program
	{
		static void Main(string[] args)
		{
			MultiLogger.Log(".\\log.txt", "Program Started");

			Thread.Sleep(3000); //Simulating work by having the program sleep for 3 seconds

			MultiLogger.Log(".\\log.txt", "Program Ended");
		}
	}
}