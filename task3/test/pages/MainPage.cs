using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.element_utils;
using task3.framework.page;
using task3.test.elements;

namespace task3.test.pages
{
    public class MainPage : BaseForm
    {
        BaseButton alertsWindowsButton;
        public MainPage(string name) : base(new BareElement(By.XPath("//*[contains(@class, 'home-content')]"), 
            name + " unique element"), name)
        {
            alertsWindowsButton = new BaseButton(
                By.XPath("//*[contains(text(), 'Alerts')]//ancestor::*[contains(@class, 'top-card')]"),
                "Alerts, Frame & Windows");
        }

        public void ClickAlertsWindowsButton()
        {
            alertsWindowsButton.Click();
        }
    }
}
