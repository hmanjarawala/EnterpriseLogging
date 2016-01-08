using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Enterprise.Logging
{
    public static class Log
    {
        static Logger _logger;

        public static Logger Logger
        {
            get { return _logger; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));
                _logger = value;
            }
        }

        public static void Write(LogType logType, string message)
        {
            switch (logType)
            {
                case LogType.DEBUG:
                    _logger.Debug(message);
                    break;
                case LogType.ERROR:
                    _logger.Error(message);
                    break;
                case LogType.FATAL:
                    _logger.Fatal(message);
                    break;
                case LogType.INFO:
                    _logger.Info(message);
                    break;
                case LogType.WARN:
                    _logger.Warn(message);
                    break;
            }
        }

        public static void Write(LogType logType, Exception exception, string message)
        {
            switch (logType)
            {
                case LogType.DEBUG:
                    _logger.Debug(exception, message);
                    break;
                case LogType.ERROR:
                    _logger.Error(exception, message);
                    break;
                case LogType.FATAL:
                    _logger.Fatal(exception, message);
                    break;
                case LogType.INFO:
                    _logger.Info(exception, message);
                    break;
                case LogType.WARN:
                    _logger.Warn(exception, message);
                    break;
            }
        }

        public static void Write(LogType logType, string messageTemplate, params object[] propertyValues)
        {
            switch (logType)
            {
                case LogType.DEBUG:
                    _logger.Debug(messageTemplate, propertyValues);
                    break;
                case LogType.ERROR:
                    _logger.Error(messageTemplate, propertyValues);
                    break;
                case LogType.FATAL:
                    _logger.Fatal(messageTemplate, propertyValues);
                    break;
                case LogType.INFO:
                    _logger.Info(messageTemplate, propertyValues);
                    break;
                case LogType.WARN:
                    _logger.Warn(messageTemplate, propertyValues);
                    break;
            }
        }

        public static void Write(LogType logType, Exception exception, string messageTemplate, params object[] propertyValues)
        {
            switch (logType)
            {
                case LogType.DEBUG:
                    _logger.Debug(exception, messageTemplate, propertyValues);
                    break;
                case LogType.ERROR:
                    _logger.Error(exception, messageTemplate, propertyValues);
                    break;
                case LogType.FATAL:
                    _logger.Fatal(exception, messageTemplate, propertyValues);
                    break;
                case LogType.INFO:
                    _logger.Info(exception, messageTemplate, propertyValues);
                    break;
                case LogType.WARN:
                    _logger.Warn(exception, messageTemplate, propertyValues);
                    break;
            }
        }
    }
}
