using System;
using System.IO;

namespace Logger.Loggers
{
    class FileLogger : Logger
    {
        private string LogFilePath { get; set; }
        private LoggerLevels LogLevel;

        public FileLogger(LoggerLevels LogLevel, string FilePath = "@log.txt")
        {
            LogFilePath = FilePath;
            this.LogLevel = LogLevel;
        }

        public override void Error(string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(this.LogFilePath, true))
                streamWriter.WriteLine($"Error: {message} occured at {DateTime.Now}");
        }

        public override void Error(Exception ex)
        {
            using (StreamWriter streamWriter = new StreamWriter(this.LogFilePath, true))
            {
                streamWriter.WriteLine($"Error: {ex.ToString()} occured at {DateTime.Now}");
            }
        }

        public override void Warning(string message)
        {
            if (LogLevel <= LoggerLevels.Warning)
            {
                using (StreamWriter streamWriter = new StreamWriter(this.LogFilePath, true))
                {
                    streamWriter.WriteLine($"Warning: {message} occured at {DateTime.Now}");
                }
            }
        }

        public override void Info(string message)
        {
            if (LogLevel <= LoggerLevels.Info)
            {
                using (StreamWriter streamWriter = new StreamWriter(this.LogFilePath, true))
                {
                    streamWriter.WriteLine($"Info: {message} at {DateTime.Now}");
                }
            }
        }
    }
}
