using NLog;

namespace task3.Framework.Logging
{
    public class LoggingManager
    {
        private static Logger logger = LogManager.GetLogger("Test Logger");

        public static Logger GetLogger()
        {
            return logger;
        }

        public static void Shutdown()
        {
            LogManager.Shutdown();
        }
    }
}
