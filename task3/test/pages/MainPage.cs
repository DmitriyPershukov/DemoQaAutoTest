using OpenQA.Selenium;
using task3.framework.element_utils;
using task3.framework.page;
using task3.Framework.ElementObjects;

namespace task3.test.pages
{
    public class MainPage : BaseForm
    {
        private const string name = "Main Page";

        Button alertsWindowsButton;
        Button elementsButton;
        
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

        public Button AlertsWindowsButton
        {
            get
            {
                return alertsWindowsButton;
            }
        }

        public Button ElementsButton
        {
            get
            {
                return elementsButton;
            }
        }
    }
}
