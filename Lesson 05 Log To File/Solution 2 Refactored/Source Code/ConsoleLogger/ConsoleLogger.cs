using System;

namespace Lesson5.Solution2Refactored
{
    public static class ConsoleLogger
    {
        public static void Log(string msg)
        {
            Console.WriteLine($"{DateTime.Now} {msg}");
        }
    }
}
