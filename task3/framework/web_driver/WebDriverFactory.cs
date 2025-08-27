using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace task3.framework.web_driver
{
    internal class WebDriverFactory
    {
        public static IWebDriver GetWebDriver(string browserName)
        {
            switch (browserName)
            {
                case "Chrome":
                    return new ChromeDriver();

                case "Firefox":
                    return new FirefoxDriver();

                default:
                    throw new ArgumentException(
                        String.Format("Provided name '{0}' does not correspond to any available browser",
                        browserName));
            }
        }
    }
}
