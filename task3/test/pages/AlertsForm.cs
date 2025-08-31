using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.element_utils;
using task3.framework.page;

namespace task3.test.pages
{
    internal class AlertsForm : BaseForm
    {
        BaseButton alertOnClickButton;
        public AlertsForm(string name) : base(new BareElement(By.Id("javascriptAlertsWrapper"), 
            "AlertsForm identifying element"), 
            name)
        {
            alertOnClickButton = new BaseButton(By.Id("alertButton"), "'Click Button to see alert' button");
        }

        public void ClickAlertOnClickButton()
        {
            alertOnClickButton.Click();
        }
    }
}
