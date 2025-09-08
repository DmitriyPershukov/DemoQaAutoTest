using task3.Framework.ConfigModel;
using task3.Framework.Logging;
using task3.Framework.Utils;

namespace task3.Framework.DataManagers
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
