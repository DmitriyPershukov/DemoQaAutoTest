using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.framework.testing_utils
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
