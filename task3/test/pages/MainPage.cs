using OpenQA.Selenium;
using task3.framework.element_utils;
using task3.framework.page;

namespace task3.test.pages
{
    public class MainPage : BaseForm
    {
        private const string name = "Main Page";

        Button alertsWindowsButton;
        Button elementsButton;
        
        public MainPage() : base(new BareElement(By.XPath("//*[contains(@class, 'home-content')]"), 
            name + " unique element"), name)
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
