namespace Lesson7.Solution0
{
    public class MultiLogger
    {
        private LogDestination logDestination = LogDestination.None;
        public MultiLogger(string cliArgument)
        {
            if (cliArgument == null)
                return;

            string targets = cliArgument.Split('=')[1].ToUpper();
            if (targets.Contains('C'))
            {
                logDestination |= LogDestination.Console;
            }
            if (targets.Contains('F'))
            {
                logDestination |= LogDestination.File;
            }
        }
        public void Log(string fileName, string msg)
        {
            if ((logDestination & LogDestination.Console) == LogDestination.Console)
            {
                ConsoleLogger.Log(msg);
            }
            if ((logDestination & LogDestination.File) == LogDestination.File)
            {
                FileLogger.Log(fileName, msg);
            }
        }
    }
}