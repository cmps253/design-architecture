namespace Lesson6.Solution1
{
    public static class MultiLogger
    {
        public static void Log(string fileName, string msg)
        {
            ConsoleLogger.Log(msg);
            FileLogger.Log(fileName, msg);
        }
    }
}