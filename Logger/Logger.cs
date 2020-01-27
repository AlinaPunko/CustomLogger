using System;
using Logger.Constants;
using Logger.Loggers;

namespace Logger
{
    public class Logger
    {
        private ILogger logger;
        private readonly LogLevel logLevel;

        public Logger()
        {
            logger = LoggerFactory.GetLogger(out logLevel);
        }

        public void Error(string message)
        {
            logger.Error(message);
        }

        public void Error(Exception ex)
        {
            logger.Error(ex);
        }

        public void Warning(string message)
        {
            if (logLevel != LogLevel.Error)
            {
                logger.Warning(message);
            }
        }

        public void Info(string message)
        {
            if (logLevel == LogLevel.Info)
            {
                logger.Info(message);
            }
        }
    }
}
