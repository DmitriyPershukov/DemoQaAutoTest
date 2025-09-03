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
            }
            return config;
        }
    }
}
