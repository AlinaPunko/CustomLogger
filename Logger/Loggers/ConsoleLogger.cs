using System;

namespace Logger.Loggers
{
    class ConsoleLogger : Logger
    {
        private LoggerLevels LogLevel;

        public ConsoleLogger(LoggerLevels LogLevel)
        {
            this.LogLevel = LogLevel;
        }

        public override void Error(string message)
        {
            Console.WriteLine($"Error: {message} occured at { DateTime.Now}");
        }

        public override void Error(Exception ex)
        {
            Console.WriteLine($"Error: {ex.ToString()} occured at {DateTime.Now}");
        }

        public override void Warning(string message)
        {
            if (LogLevel <= LoggerLevels.Warning)
            {
                Console.WriteLine($"Warning: {message} occured at {DateTime.Now}");
            }
        }

        public override void Info(string message)
        {
            if (LogLevel <= LoggerLevels.Info)
            {
                Console.WriteLine($"Info: {message} at { DateTime.Now}");
            }
        }
    }
}
