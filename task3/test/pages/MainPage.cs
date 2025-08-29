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
        public MainPage(string name) : base(new BaseElement(By.XPath("//*[contains(@class, 'home-content')]"), 
            name + " unique element"), name)
        {
            alertsWindowsButton = new BaseButton(
                By.XPath("//*[contains(@class, 'card-body')]//*[contains(text(), 'Alerts')]"),
                "Alerts, Frame & Windows Button");
        }

        public void ClickAlertsWindowsButton()
        {
            alertsWindowsButton.Click();
        }
    }
}
