using task3.framework.testing_utils;
using task3.test.config;

namespace task3.framework.config_utils
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
