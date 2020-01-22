using System;

namespace Logger
{
    public class Logger:ILogger
    {
        public virtual void Error(string message)
        {
            Console.WriteLine($"Error: {message} occured at {DateTime.Now}");
        }

        public virtual void Error(Exception ex)
        {
            Console.WriteLine($"Error: {ex.ToString()} occured at { DateTime.Now}");
        }

        public virtual void Warning(string message)
        {
            Console.WriteLine($"Warning: {message} occured at {DateTime.Now}");
        }

        public virtual void Info(string message)
        {
            Console.WriteLine($"Info: {message} at {DateTime.Now}");
        }
    }
}
