using OpenQA.Selenium;
using task3.framework.web_driver;
using task3.Framework.Logging;

namespace task3.Framework.Utils.BrowserUtils
{
    public class AlertUtils
    {
        public static string GetAlertText()
        {
            return WebDriverProvider
                .GetInstance()
                .SwitchTo()
                .Alert()
                .Text;
        }

        public static void ClickOk()
        {
            LoggingManager.GetLogger().Debug("Clicking alert 'Ok' button");
            WebDriverProvider
                    .GetInstance()
                    .SwitchTo()
                    .Alert()
                    .Accept();
        }

        public static bool IsAlertPresent()
        {
            try
            {
                WebDriverProvider.GetInstance().SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException Ex)
            {
                return false;
            }
        }

        public static void EnterText(string text)
        {
            LoggingManager.GetLogger().Debug($"Entering text '{text}' into the alert input field.");
            WebDriverProvider
                    .GetInstance()
                    .SwitchTo()
                    .Alert()
                    .SendKeys(text);
        }
    }
}
