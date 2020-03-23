using System;
using System.IO;

namespace Lesson7.Solution1
{
    public static class FileLogger
    {
        public static void Log(string fileName, string msg)
        {
            File.AppendAllText(fileName, $"{DateTime.Now} {msg}\n");
        }
    }
}