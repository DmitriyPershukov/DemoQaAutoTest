using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenQA.Selenium;

namespace task3.Framework.ConfigModel
{
    public class Config : IConfig
    {
        private const string ConfigFilePath = "Framework\\ConfigModel\\config.json";
        public static string GetConfigFilePath()
        {
            return ConfigFilePath;
        }

        public string? Browser;

        [JsonConverter(typeof(StringEnumConverter))]
        public PageLoadStrategy PageLoadStrategy;
    }
}
