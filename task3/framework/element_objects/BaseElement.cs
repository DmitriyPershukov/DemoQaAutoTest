using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using task3.framework.web_driver;

namespace task3.framework.element_utils
{
    public abstract class BaseElement
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

        public bool IsDisplayed()
        {
            return GetElement().Displayed;
        }

        public string Name { get { return name; } }

        protected IWebElement GetElement()
        {
            return WebDriverProvider.GetInstance().FindElement(locator);
        }

        public string GetText()
        {
            return GetElement().Text;
        }

        public void WaitUntilPresent(TimeSpan timeout)
        {
            WebDriverWait wait = new WebDriverWait(WebDriverProvider.GetInstance(), timeout);
            wait.Until(d => IsPresent());
        }

        public void WaitUntilDisplayed(TimeSpan timeout)
        {
            WebDriverWait wait = new WebDriverWait(WebDriverProvider.GetInstance(), timeout);
            wait.Until(d => IsDisplayed());
        }
    }
}
