using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.element_utils;
using task3.framework.testing_utils;

namespace task3.test.elements
{
    internal class InputField : BaseElement
    {
        public InputField(By locator, string name) : base(locator, name)
        {
        }

        public void SendKeys(string text)
        {
            LoggingManager.GetLogger().Debug($"Entering text '{text}' into input field {Name}");
            GetElement().SendKeys(text);
        }
    }
}
