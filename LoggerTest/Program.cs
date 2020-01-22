using System;

namespace LoggerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Logger logger = Logger.Loggers.LogFactory.GetLogger();
            logger.Error("I'm a small bug");
            logger.Info("I can be useful");
            logger.Warning("Nobody looks at warnings(");
            logger.Error(new StackOverflowException());
        }
    }
}
