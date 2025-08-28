using Newtonsoft.Json;

namespace task3.framework.config_utils
{
    internal class ConfigManager
    {
        internal static T GetConfigurationModel<T>() where T : IConfig
        {
            return FileReader.ReadJsonDataFile<T>();
        }
    }
}
