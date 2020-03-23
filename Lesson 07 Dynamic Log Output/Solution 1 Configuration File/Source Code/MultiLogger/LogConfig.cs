using System.IO;
using System.Linq;
namespace Lesson7.Solution1
{
    public class LogConfig
    {
        public LogDestination LogDestination { get; } = LogDestination.None; //read-only property, also initialized to a value. Thank you C#..
        public bool CanLogToOutput(LogDestination logDestination) => ((LogDestination & logDestination) == logDestination);
        public string FileLoggerOutputFile { get; }
        public LogConfig()
        {
            const string LogFile = ".//log.config";
            const string DefaultTargetsLine = @"\ntargets=fc\n";
            const string DefaultFileLoggerFile= "log.txt";

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

            //if the config file does not have an entry for file logger file, then add one
            string FileLoggerFile = File.ReadAllLines(LogFile).SingleOrDefault(p=>p.ToLower().StartsWith("fileloggerfile="));
            if (FileLoggerFile == null)
            {
                File.AppendAllText(LogFile, DefaultFileLoggerFile);
                FileLoggerFile = DefaultTargetsLine;
            }

            //determine what which target(s) to output to
            string targets = TargetConfigLine.Split('=')[1].ToUpper();
            if (targets.Contains('C'))
            {
                LogDestination |= LogDestination.Console;
            }
            if (targets.Contains('F'))
            {
                LogDestination |= LogDestination.File;
            }
        }
    }
}
