using OpenQA.Selenium;
using task3.framework.testing_utils;
using task3.framework.web_driver;

namespace task3.framework.element_utils
{
    public class BaseButton : BaseElement
    {
        public BaseButton(By locator, string name) : base(locator, name)
        {
        }

        public void Click()
        {
            ((IJavaScriptExecutor)WebDriverProvider.GetInstance())
                .ExecuteScript($"window.scrollTo({GetElement().Location.X}, {GetElement().Location.Y});");
            LoggingManager.GetLogger().Debug($"Clicking '{Name}' button.");
            GetElement().Click();
        }
    }
}
