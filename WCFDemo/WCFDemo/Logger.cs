using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFDemo
{
    public enum LogType
    {
        Error = 0,
        Debug = 1,
        Info = 2
    }

    public class Logger
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Log(LogType logType, string message)
        {
            switch (logType)
            {
                case LogType.Error:
                    log.Error(message);
                    break;

                case LogType.Debug:
                    log.Debug(message);
                    break;

                case LogType.Info:
                    log.Info(message);
                    break;

                default:
                    log.Info(message);
                    break;
            }
        }
    }
}