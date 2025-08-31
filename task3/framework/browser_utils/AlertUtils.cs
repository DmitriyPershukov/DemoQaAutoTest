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
            return WebDriverProvider
                    .GetInstance()
                    .SwitchTo()
                    .Alert()
                    .Text
                    .Equals(text);
        }
    }
}
