using OpenQA.Selenium;
using task3.framework.testing_utils;
using task3.framework.web_driver;

namespace task3.framework.browser_utils
{
    public class IframeUtils
    {
        public static void SwitchToIframe(By locator)
        {
            LoggingManager.GetLogger().Debug($"Switching to iframe with locator '{locator}'");
            IWebElement iframe = WebDriverProvider
                .GetInstance()
                .FindElement(locator);
            WebDriverProvider
                .GetInstance()
                .SwitchTo()
                .Frame(iframe);
        }

        public static void SwitchToFirstIframe()
        {
            SwitchToIframe(By.XPath("//iframe"));
        }

        public static void SwitchToDefaultContent()
        {
            WebDriverProvider
                .GetInstance()
                .SwitchTo()
                .DefaultContent();
        }
    }
}
