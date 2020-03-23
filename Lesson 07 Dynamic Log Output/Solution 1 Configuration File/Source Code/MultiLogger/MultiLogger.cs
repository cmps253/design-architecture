namespace Lesson7.Solution1
{
    public class MultiLogger
    {
        private LogConfig Configuration;
        public MultiLogger()
        {
            Configuration = new LogConfig();
        }
        public void Log(string msg)
        {
            if (Configuration.CanLogToOutput(LogDestination.Console))
            {
                ConsoleLogger.Log(msg);
            }
            if (Configuration.CanLogToOutput(LogDestination.File))
            {
                FileLogger.Log(Configuration.FileLoggerOutputFile, msg);
            }
        }
    }
}