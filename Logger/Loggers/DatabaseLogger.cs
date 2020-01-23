using System;
using System.Collections.Generic;

namespace Logger.Loggers
{
    class DatabaseLogger : Logger
    {
        public LoggerLevels LogLevel { get; }
        private List<string> LoggingDb { get; set; }

        public DatabaseLogger(LoggerLevels LogLevel)
        {
            this.LogLevel = LogLevel;
        }

        public DatabaseLogger()
        {
            LoggingDb = new List<string>();
        }

        public override void Error(string message)
        {
            LoggingDb.Add($"Error: {message} occured at {DateTime.Now}");
        }

        public override void Error(Exception ex)
        {
            LoggingDb.Add($"Error: {ex.ToString()} occured at {DateTime.Now}");
        }

        public override void Warning(string message)
        {
            if (LogLevel <= LoggerLevels.Warning)
            {
                LoggingDb.Add($"Warning: {message} occured at {DateTime.Now}");
            }
        }

        public override void Info(string message)
        {
            if (LogLevel <= LoggerLevels.Info)
            {
                LoggingDb.Add($"Info: {message} occured at {DateTime.Now}");
            }
        }
    }
}
