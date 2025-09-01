using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.web_driver;

namespace task3.framework.browser_utils
{
    public class IframeUtils
    {
        public static void SwitchToIframe(string id)
        {
            IWebElement iframe1 = WebDriverProvider
                .GetInstance()
                .FindElement(By.Name("iframe1-name"));
            WebDriverProvider
                .GetInstance()
                .SwitchTo()
                .Frame(iframe1);
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
