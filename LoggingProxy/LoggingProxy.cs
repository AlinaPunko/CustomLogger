using System.Dynamic;
using System.Reflection;
using ImpromptuInterface;
using Logger;
using Logger.Constants;

namespace LoggingProxy
{
    class LoggingProxy : DynamicObject
    {
        private readonly ILogger logger;
        private static object loggedObject;
        private readonly LogLevel logLevel;

        public LoggingProxy()
        {
            logger = LoggerFactory.GetLogger(out logLevel);
        }

        public static T CreateInstance<T>(T obj) where T: class
        {
            loggedObject = obj;
            return new LoggingProxy().ActLike<T>();
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            MethodInfo invokedMethod = loggedObject.GetType().GetMethod(binder.Name);

            if (invokedMethod != null)
            {
                result = invokedMethod.Invoke(loggedObject, args);
                if (logLevel <= LogLevel.Info)
                {
                    logger.Info(binder.Name);
                }
                return true;
            }
            
            logger.Error(binder.Name);
            result = null;
            return false;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            if (logLevel <= LogLevel.Info)
            {
                logger.Info($"{binder.Name} was set into {value}");
            }
            return true;
        }

    }
}
