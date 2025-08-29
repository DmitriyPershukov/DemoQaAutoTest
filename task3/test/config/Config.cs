using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenQA.Selenium;
using task3.framework.config_utils;

namespace task3.test.config
{
    public class Config : IConfig
    {
        private const string ConfigFilePath = "test\\config\\config.json";
        public static string GetConfigFilePath()
        {
            return ConfigFilePath;
        }

        public string? Browser;

        [JsonConverter(typeof(StringEnumConverter))]
        public PageLoadStrategy PageLoadStrategy;
    }
}
