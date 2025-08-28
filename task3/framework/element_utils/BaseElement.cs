using OpenQA.Selenium;
using task3.framework.web_driver;

namespace task3.framework.element_utils
{
    internal class BaseElement
    {
        private By locator;
        public BaseElement(By locator) {
            this.locator = locator;
        }
        public bool IsPresent()
        {
            var elements = WebDriverProvider.GetInstance().FindElements(locator);
            if (elements.Count > 0)
            {
                return true;
            }
            return false;
        }

        private IWebElement findElement()
        {
            return WebDriverProvider.GetInstance().FindElement(locator);
        }
    }
}
