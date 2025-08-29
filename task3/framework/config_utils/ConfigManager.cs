using Newtonsoft.Json;

namespace task3.framework.config_utils
{
    public class ConfigManager
    {
        public static T GetConfigurationModel<T>() where T : IConfig
        {
            return FileReader.ReadJsonDataFile<T>();
        }
    }
}
