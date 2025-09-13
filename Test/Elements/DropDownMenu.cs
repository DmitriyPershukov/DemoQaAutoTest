using OpenQA.Selenium;
using task3.framework.element_utils;

namespace task3.test.elements
{
    public class DropDownMenu : Button
    {
        private MenuElementList menuElements;
        public DropDownMenu(By locator, string name) : base(locator, name) { }

        public DropDownMenu(string label, string name) : base(
            By.XPath($"//*[contains(text(), '{label}')]//ancestor::*[contains(@class, 'element-group')]"),
            name)
        {
            menuElements = new MenuElementList(label, $"Element list of drop down menu with label: '{label}'");
        }

        public MenuElementList GetElementList()
        {
            return menuElements;
        }
    }
}
