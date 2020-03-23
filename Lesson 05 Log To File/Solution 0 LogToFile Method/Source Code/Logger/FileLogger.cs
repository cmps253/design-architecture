using System;
using System.IO;

namespace Lesson5
{
    public static class FileLogger
    {
        public static void LogToFile(string fileName, string msg)
        {
            File.AppendAllText(fileName, $"{DateTime.Now} {msg}\n");
        }
    }
}