using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Reflection;
using ImpromptuInterface;

namespace LoggingProxy
{
    class LoggingProxy: DynamicObject
    {
        private readonly Logger.Logger _logger;
        static object loggedObject;

        public LoggingProxy()
        {
            _logger = Logger.Loggers.LogFactory.GetLogger();
        }

        public static T CreateInstance <T> (T obj) where T: class
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
                _logger.Info(binder.Name);
                return true;
            }

            _logger.Error(binder.Name);
            result = null;
            return false;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            _logger.Info($"{binder.Name} was set into {value.ToString()}");
            return true;
        }

    }
}
