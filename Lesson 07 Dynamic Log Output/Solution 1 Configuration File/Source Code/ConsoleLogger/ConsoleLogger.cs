﻿using System;

namespace Lesson7.Solution1
{
    public static class ConsoleLogger
    {
        public static void Log(string msg)
        {
            Console.WriteLine($"{DateTime.Now} {msg}");
        }
    }
}
