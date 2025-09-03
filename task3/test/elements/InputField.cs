using OpenQA.Selenium;
using task3.framework.element_utils;
using task3.framework.testing_utils;

namespace task3.test.elements
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
