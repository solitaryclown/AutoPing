using log4net;
using log4net.Appender;
using log4net.Repository.Hierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPing
{
    public class AppLogger
    {
        
        private readonly static ILog logger=LogManager.GetLogger(typeof(AppLogger));
        
        public static void LogInfo(string message)
        {
            logger.Info(message);
        }
        public static void LogWarn(string message) {  logger.Warn(message); }
        public static void LogError(string message) { logger.Error(message); }
        public static void LogFatal(string message) { logger.Fatal(message); }
        public  static void AddAppender(AppenderSkeleton appender)
        {
            Logger logger1 = logger.Logger as Logger;
            logger1?.AddAppender(appender);
        }
    }
}
