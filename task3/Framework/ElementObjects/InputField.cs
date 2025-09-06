using OpenQA.Selenium;
using task3.framework.element_utils;
using task3.Framework.Logging;

namespace task3.Framework.ElementObjects
{
    public class InputField : BaseElement
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
