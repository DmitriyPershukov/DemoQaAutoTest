using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using task3.framework.config_utils;
using task3.test.config;

namespace task3.framework.web_driver
{
    public class WebDriverFactory
    {
        public static IWebDriver GetWebDriver(string browserName)
        {
            PageLoadStrategy pageLoadStrategy = ConfigManager.GetConfigurationModel<Config>().PageLoadStrategy;
            switch (browserName)
            {
                case "Chrome":
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.PageLoadStrategy = pageLoadStrategy;
                    return new ChromeDriver(chromeOptions);

                case "Firefox":
                    FirefoxOptions firefoxOptions = new FirefoxOptions();
                    firefoxOptions.PageLoadStrategy = pageLoadStrategy;
                    return new FirefoxDriver(firefoxOptions);

                default:
                    throw new ArgumentException(
                        String.Format("Provided name '{0}' does not correspond to any available browser",
                        browserName));
            }
        }
    }
}
