using OpenQA.Selenium;
using task3.framework.config.config_data_models;
using task3.framework.config.config_utils;

namespace task3.framework.web_driver
{
    internal class WebDriverProvider
    {
        private static IWebDriver? instance;
        private WebDriverProvider() { }

        public static IWebDriver GetInstance()
        {
            if (instance == null)
            {
                Config? config = ConfigManager.GetConfigurationModel<Config>();
                instance = WebDriverFactory.GetWebDriver(config.Browser);
            }
            return instance;
        }

        public static void SetInstanceNull()
        {
            if (instance != null)
            {
                instance.Quit();
            }
            instance = null;
        }
    }
}
