using OpenQA.Selenium;
using task3.framework.config_utils;

namespace task3.test.config
{
    internal class Config : IConfig
    {
        private const string ConfigFilePath = "test\\config\\config.json";
        public static string GetConfigFilePath()
        {
            return ConfigFilePath;
        }

        public string? Browser;
        public PageLoadStrategy PageLoadStrategy;
    }
}
