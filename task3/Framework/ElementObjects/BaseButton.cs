using OpenQA.Selenium;
using task3.framework.web_driver;
using task3.Framework.Logging;

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
