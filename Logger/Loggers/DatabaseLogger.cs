using System;
using System.Collections.Generic;

namespace Logger.Loggers
{
    class DatabaseLogger : ILogger
    {
        private List<string> LoggingDb { get;}


        public DatabaseLogger()
        {
            LoggingDb = new List<string>();
        }

        public void Error(string message)
        {
            LoggingDb.Add($"Error: {message} occured at {DateTime.Now}");
        }

        public void Error(Exception ex)
        {
            LoggingDb.Add($"Error: {ex} occured at {DateTime.Now}");
        }

        public void Warning(string message)
        {
            LoggingDb.Add($"Warning: {message} occured at {DateTime.Now}");
        }

        public void Info(string message)
        {
            LoggingDb.Add($"Info: {message} occured at {DateTime.Now}");
        }
    }
}
