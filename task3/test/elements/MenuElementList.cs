using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.BrowsingContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.element_utils;

namespace task3.test.elements
{
    public class MenuElementList : BaseElement
    {
        public MenuElementList(By locator, string name) : base(locator, name)
        {
        }

        public bool IsCollapsed()
        {
            return !GetElement().GetAttribute("class").Contains("show");
        }

        public void ClickElement(string label)
        {
            var b = GetElement().Text;
            var a = GetElement()
                .FindElement(By.XPath($"//*[contains(text(), '{label}')]")).Text;
            GetElement()
                .FindElement(By.XPath($"//*[contains(text(), '{label}')]"))
                .Click();
        }
    }
}
