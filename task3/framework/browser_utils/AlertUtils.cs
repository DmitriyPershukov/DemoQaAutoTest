using OpenQA.Selenium;
using task3.framework.testing_utils;
using task3.framework.web_driver;

namespace task3.framework.browser_utils
{
    public class AlertUtils
    {
        public static bool IsAlertWithTextPresent(string text)
        {
            if (IsAlertPresent())
            {
                return WebDriverProvider
                    .GetInstance()
                    .SwitchTo()
                    .Alert()
                    .Text
                    .Equals(text);
            }
            else
            {
                return false;
            }
            
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
