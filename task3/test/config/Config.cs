using task3.framework.config_utils;

namespace task3.test.config
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
