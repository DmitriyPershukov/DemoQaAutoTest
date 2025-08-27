using task3.framework.config_utils;

namespace task3.test.configs.config_data_models
{
    internal class Config : IConfig
    {
        private const string ConfigFileName = "config.json";
        public static string GetConfigFileName()
        {
            return ConfigFileName;
        }

        public string? Browser;
    }
}
