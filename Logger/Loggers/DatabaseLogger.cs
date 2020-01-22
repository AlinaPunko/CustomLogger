using System;
using System.Collections.Generic;

namespace Logger.Loggers
{
    class DatabaseLogger : Logger
    {
        private LoggerLevels LogLevel;
        private List<string> LoggingDB { get; set; }

        public DatabaseLogger(LoggerLevels LogLevel)
        {
            this.LogLevel = LogLevel;
        }

        public DatabaseLogger()
        {
            LoggingDB = new List<string>();
        }

        public override void Error(string message)
        {
            LoggingDB.Add($"Error: {message} occured at {DateTime.Now}");
        }

        public override void Error(Exception ex)
        {
            LoggingDB.Add($"Error: {ex.ToString()} occured at {DateTime.Now}");
        }

        public override void Warning(string message)
        {
            if (LogLevel <= LoggerLevels.Warning)
            {
                LoggingDB.Add($"Warning: {message} occured at {DateTime.Now}");
            }
        }

        public override void Info(string message)
        {
            if (LogLevel <= LoggerLevels.Info)
            {
                LoggingDB.Add($"Info: {message} occured at {DateTime.Now}");
            }
        }
    }
}
