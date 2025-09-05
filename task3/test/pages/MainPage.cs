using OpenQA.Selenium;
using task3.framework.element_utils;
using task3.framework.page;

namespace task3.test.pages
{
    public class MainPage : BaseForm
    {
        private const string name = "Main Page";

        BaseButton alertsWindowsButton;
        BaseButton elementsButton;
        
        public MainPage() : base(new BareElement(By.XPath("//*[contains(@class, 'home-content')]"), 
            name + " unique element"), name)
        {
            alertsWindowsButton = new BaseButton(
                By.XPath("//*[contains(@class, 'top-card')]//*[contains(text(), 'Alerts')]"),
                "Alerts, Frame & Windows");
            elementsButton = new BaseButton(
                By.XPath("//*[contains(@class, 'top-card')]//*[contains(text(), 'Elements')]"),
                "Alerts, Frame & Windows");
        }

        public void ClickAlertsWindowsButton()
        {
            alertsWindowsButton.Click();
        }

        public void ClickElementsButton()
        {
            elementsButton.Click();
        }
    }
}
