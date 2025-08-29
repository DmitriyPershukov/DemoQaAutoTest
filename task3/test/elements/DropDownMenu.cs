using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.BrowsingContext;
using System.Reflection.Emit;
using task3.framework.element_utils;
using task3.framework.web_driver;

namespace task3.test.elements
{
    internal class DropDownMenu : BaseElement
    {
        public DropDownMenu(By locator, string name) : base(locator, name){}

        public DropDownMenu(string label, string name) : base(
            By.XPath($"//*[contains(text(), '{label}')]//ancestor::*[contains(@class, 'element-group')]"), 
            name){}

        public bool IsCollapsed()
        {    
            return !GetElement().FindElement(By.XPath("//*[contains(@class, 'element-list')]"))
                .GetAttribute("class")
                .Contains("show");
        }
    }
}
