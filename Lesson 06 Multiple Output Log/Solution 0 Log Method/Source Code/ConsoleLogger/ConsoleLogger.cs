using System;

namespace Lesson6.Solution0
{
    public static class ConsoleLogger
    {
        public static void Log(string msg)
        {
            Console.WriteLine($"{DateTime.Now} {msg}");
        }
    }
}
