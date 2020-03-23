using System.Threading;

namespace Lesson7.Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiLogger logger = new MultiLogger(LogConfig.CreateFromFile());

            //Ready to start logging
            logger.Log("Program Started"); //finally got rid of the pesky file name parameter for logging to file

            Thread.Sleep(3000); //Simulating work by having the program sleep for 3 seconds

            logger.Log("Program Ended"); //finally got rid of the pesky file name parameter for logging to file
        }
    }
}