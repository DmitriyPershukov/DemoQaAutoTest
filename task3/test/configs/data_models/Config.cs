namespace task3.framework.config.config_data_models
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
