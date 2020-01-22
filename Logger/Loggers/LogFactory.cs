using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Logger.ConfigElements;

namespace Logger.Loggers
{
    public static class LogFactory
    {
        const string LOG_SECTION = "logSection";

        public static Logger GetLogger()
        {
            LogSection group = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).GetSection(LOG_SECTION) as LogSection;

            Enum.TryParse(group.Level.MinLevel, out LoggerLevels level);
            Enum.TryParse(group.Target.LoggerType, out LoggerTypes type);

            if (level == 0)
            {
                level = LoggerLevels.Info;
            }

            if (type == 0)
            {
                type = LoggerTypes.Console;
            }

            switch (type)
            {
                case LoggerTypes.File:
                    return new FileLogger(level, group.Target.FileName);
                case LoggerTypes.Console:
                    return new ConsoleLogger(level);
                case LoggerTypes.Database:
                    return new DatabaseLogger(level);
                default:
                    return new ConsoleLogger(level);
            }
        }
    }
}
