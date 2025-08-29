using OpenQA.Selenium;
using task3.framework.web_driver;

namespace task3.framework.element_utils
{
    public class BaseElement
    {
        private By locator;
        private string name;
        public BaseElement(By locator, string name) {
            this.locator = locator;
            this.name = name;
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

        public string Name { get { return name; } }

        protected IWebElement FindElement()
        {
            return WebDriverProvider.GetInstance().FindElement(locator);
        }
    }
}
