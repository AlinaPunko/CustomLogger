using System;

namespace Logger.Loggers
{
    class ConsoleLogger : ILogger
    {
        public void Error(string message)
        {
            Console.WriteLine($"Error: {message} occured at { DateTime.Now}");
        }

        public void Error(Exception ex)
        {
            Console.WriteLine($"Error: {ex} occured at {DateTime.Now}");
        }

        public void Warning(string message)
        {
            Console.WriteLine($"Warning: {message} occured at {DateTime.Now}");
        }

        public void Info(string message)
        {
            Console.WriteLine($"Info: {message} at { DateTime.Now}");
        }
    }
}
