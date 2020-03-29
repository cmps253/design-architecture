using System;
using System.IO;
using System.Linq;
namespace Lesson7.Solution2
{
    public class LogConfig
    {
        private const string LogFile = ".//log.config";
        private const string DefaultTargetsLine = @"\ntargets=fc\n";
        private const string DefaultFileLoggerFile= "log.txt";

        public LogDestination LogDestination { get; private set; } = LogDestination.None; //read-only property, also initialized to a value. Thank you C#..
        public string FileLoggerOutputFile { get; private set; }
        public bool CanLogToOutput(LogDestination logDestination) => ((LogDestination & logDestination) == logDestination);
        private LogConfig() { }
        public static LogConfig CreateFromEnvironment()
        {
            LogConfig logConfig = new LogConfig();

            //if the environment does not have an entry for targets, then use a default
            string targets = Environment.GetEnvironmentVariable("targets");
            if (targets == null)
            {
                targets = DefaultTargetsLine.Split('=')[1].ToUpper();
            }

            //determine what which target(s) to output to
            if (targets.Contains('C'))
            {
                logConfig.LogDestination |= LogDestination.Console;
            }
            if (targets.Contains('F'))
            {
                logConfig.LogDestination |= LogDestination.File;
            }

            //if the environment does not have an entry for file logger file, then use a default
            string FileLoggerFile = Environment.GetEnvironmentVariable("fileloggerfile");
            if (FileLoggerFile == null)
            {
                FileLoggerFile = DefaultFileLoggerFile;
                File.AppendAllText(LogFile, FileLoggerFile);
            }
            logConfig.FileLoggerOutputFile = FileLoggerFile;

            return logConfig;
        }

        public static LogConfig CreateFromFile()
        {
            LogConfig logConfig = new LogConfig();

            //programming pleasantness
            //if no config file exists, then create one
            if (!File.Exists(LogFile))
            {
                File.AppendAllText(LogFile, DefaultTargetsLine);
            }

            //if the config file does not have an entry for targets, then add one
            string TargetConfigLine = File.ReadAllLines(LogFile).SingleOrDefault(p=>p.ToLower().StartsWith("targets="));
            if (TargetConfigLine == null) 
            {
                File.AppendAllText(LogFile, DefaultTargetsLine);
                TargetConfigLine = DefaultTargetsLine;
            }

            //determine what which target(s) to output to
            string targets = TargetConfigLine.Split('=')[1].ToUpper();
            if (targets.Contains('C'))
            {
                logConfig.LogDestination |= LogDestination.Console;
            }
            if (targets.Contains('F'))
            {
                logConfig.LogDestination |= LogDestination.File;
            }

            //if the config file does not have an entry for file logger file, then add one
            string FileLoggerFile = File.ReadAllLines(LogFile).SingleOrDefault(p=>p.ToLower().StartsWith("fileloggerfile="));
            if (FileLoggerFile == null)
            {
                FileLoggerFile = DefaultFileLoggerFile;
                File.AppendAllText(LogFile, FileLoggerFile);
            }
            logConfig.FileLoggerOutputFile = FileLoggerFile;
          
            return logConfig;
        }
    }
}
