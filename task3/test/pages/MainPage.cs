using OpenQA.Selenium;
using task3.framework.element_utils;
using task3.framework.page;
using task3.Framework.ElementObjects;

namespace task3.test.pages
{
    public class MainPage : BaseForm
    {
        private const string name = "Main Page";

        private Button alertsWindowsButton;
        private Button elementsButton;
        
        public MainPage() : base(new ElementContainer(By.XPath("//*[contains(@class, 'home-content')]"), 
            "Main page identifying element"), name)
        {
            alertsWindowsButton = new Button(
                By.XPath("//*[contains(@class, 'top-card')]//*[contains(text(), 'Alerts')]"),
                "Alerts, Frame & Windows");
            elementsButton = new Button(
                By.XPath("//*[contains(@class, 'top-card')]//*[contains(text(), 'Elements')]"),
                "Alerts, Frame & Windows");
        }

        private Button AlertsWindowsButton { get => alertsWindowsButton; }
        private Button ElementsButton { get => elementsButton; }

        public void ClickAlertsWindowsButton()
        {
            AlertsWindowsButton.Click();
        }

        public void ClickElementsButton()
        {
            ElementsButton.Click();
        }
    }
}
