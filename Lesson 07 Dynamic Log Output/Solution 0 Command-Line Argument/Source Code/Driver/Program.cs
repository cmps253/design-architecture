using System.Linq;
using System.Threading;

namespace Lesson7.Solution0
{
    class Program
    {
        static void Main(string[] args)
        {
            //usage: driver.exe --target=cf

            string argument = args.SingleOrDefault(p=>p.ToLower().StartsWith("--target="));
            MultiLogger logger = new MultiLogger(argument);

            //Ready to start logging
            logger.Log(".\\log.txt", "Program Started");

            Thread.Sleep(3000); //Simulating work by having the program sleep for 3 seconds

            logger.Log(".\\log.txt", "Program Ended");
        }
    }
}