using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.testing_utils;

namespace task3.framework.element_utils
{
    public class BaseButton : BaseElement
    {
        public BaseButton(By locator, string name) : base(locator, name)
        {
        }

        public void Click()
        {
            LoggingManager.GetLogger().Debug($"Clicking '{name}' button.");
            GetElement().Click();
        }
    }
}
