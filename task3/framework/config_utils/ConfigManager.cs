using Newtonsoft.Json;
using task3.framework.config.config_data_models;

namespace task3.framework.config.config_utils
{
    internal class ConfigManager
    {
        internal static T GetConfigurationModel<T>() where T : IConfig
        {
            var configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, 
                "framework\\config\\config_files\\", T.GetConfigFileName());
            var jsonText = File.ReadAllText(configPath);
            return JsonConvert.DeserializeObject<T>(jsonText);
        }
    }
}
