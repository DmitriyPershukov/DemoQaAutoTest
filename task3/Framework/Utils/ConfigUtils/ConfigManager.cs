using task3.Framework.Logging;
using task3.Framework.Utils;
using task3.test.config;

namespace task3.Framework.Utils.ConfigUtils
{
    public class ConfigManager
    {
        private static Config config; 
        public static Config GetConfigurationModel()
        {
            if (config == null)
            {      
                config = FileReader.ReadJsonDataFile<Config>();
                LoggingManager.GetLogger().Info("Following configuration parameters are applied:\n" +
                    $"Browser: {config.Browser}\n" +
                    $"PageLoadStrategy: {config.PageLoadStrategy}");     
            }
            return config;
        }
    }
}
