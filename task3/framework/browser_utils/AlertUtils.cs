using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            WebDriverProvider
                    .GetInstance()
                    .SwitchTo()
                    .Alert()
                    .SendKeys(text);
        }
    }
}
