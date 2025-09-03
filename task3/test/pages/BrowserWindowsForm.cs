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
    public class BrowserWindowsForm : BaseForm
    {
        BaseButton newTabsButton;
        public BrowserWindowsForm(string name) : base(
            new BareElement(By.Id("browserWindows"), "BrowserWindowsForm identifying element"), name)
        {
            newTabsButton = new BaseButton(By.Id("tabButton"), "New tabs");
        }

        public void ClickNewTabsButton()
        {
            newTabsButton.Click();
        }
    }
}
