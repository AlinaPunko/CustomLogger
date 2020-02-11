using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Logger.ConfigElements;
using Logger.Constants;
using Logger.Loggers;

namespace Logger
{
    public static class LoggerFactory
    {
        private const string LogSectionName = "logSection";

        public static ILogger GetLogger(out LogLevel logLevel)
        {
            LogSection group = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).GetSection(LogSectionName) as LogSection;

            if (!Enum.TryParse(group.Level.MinLevel, out LogLevel level))
            {
                level = LogLevel.Default;
            }

            if (!Enum.TryParse(group.Target.LoggerType, out LoggerType type))
            {
                type = LoggerType.Default;
            }

            logLevel = level;

            switch (type)
            {
                case LoggerType.Console:
                    return new ConsoleLogger();
                case LoggerType.Database:
                    return new DatabaseLogger();
                case LoggerType.File:
                    return new FileLogger(group.Target.FileName);
                default:
                    return new ConsoleLogger();
            }
        }
    }
}
