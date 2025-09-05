using OpenQA.Selenium;
using task3.framework.web_driver;
using task3.Framework.Logging;

namespace task3.Framework.Utils.BrowserUtils
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
