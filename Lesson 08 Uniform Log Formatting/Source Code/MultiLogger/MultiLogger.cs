namespace Lesson7.Solution2
{
    public class MultiLogger
    {
        private LogConfig Configuration;
        public MultiLogger(LogConfig logConfig)
        {
            this.Configuration = logConfig;
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