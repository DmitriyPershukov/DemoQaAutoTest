using OpenQA.Selenium;
using task3.framework.config_utils;
using task3.test.config;

namespace task3.framework.web_driver
{
    public class WebDriverProvider
    {
        private static IWebDriver? instance;
        private WebDriverProvider() { }

        public static IWebDriver GetInstance()
        {
            if (instance == null)
            {
                Config? config = ConfigManager.GetConfigurationModel();
                instance = WebDriverFactory.GetWebDriver(config.Browser);
                instance.Manage().Window.Maximize();
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
