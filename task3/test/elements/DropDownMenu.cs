using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.BrowsingContext;
using System.Reflection.Emit;
using task3.framework.element_utils;
using task3.framework.web_driver;

namespace task3.test.elements
{
    public class DropDownMenu : BaseElement
    {
        private MenuElementList menuElements;
        public DropDownMenu(By locator, string name) : base(locator, name){}

        public DropDownMenu(string label, string name) : base(
            By.XPath($"//*[contains(text(), '{label}')]//ancestor::*[contains(@class, 'element-group')]"), 
            name)
        {
            menuElements = new MenuElementList(label, $"Element list of drop down menu with label {label}");
        }

        public MenuElementList GetElementList()
        {
            return menuElements;
        }
    }
}
