using System;
using System.IO;

namespace Logger.Loggers
{
    class FileLogger : ILogger
    {
        private string LogFilePath { get;}

        public FileLogger(string FilePath = "@log.txt")
        {
            LogFilePath = FilePath;
        }

        public void Error(string message)
        {
            File.AppendAllText(LogFilePath, $"Error: {message} occured at {DateTime.Now} \n");
        }

        public void Error(Exception ex)
        {
            File.AppendAllText(LogFilePath, $"Error: {ex} occured at {DateTime.Now} \n");
        }

        public void Warning(string message)
        {
            File.AppendAllText(LogFilePath, $"Warning: {message} occured at {DateTime.Now} \n");
        }

        public void Info(string message)
        {
            File.AppendAllText(LogFilePath, $"Info: {message} at {DateTime.Now} \n");
        }
    }
}
