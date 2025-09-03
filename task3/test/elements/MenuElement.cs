using OpenQA.Selenium;
using task3.framework.element_utils;

namespace task3.test.elements
{
    public class MenuElement : BaseButton
    {
        public MenuElement(By locator, string name) : base(locator, name)
        {
        }

        public MenuElement(string menuLabel, string label, string name) : base(By.XPath($"//*[contains(text(), '{menuLabel}')]" +
                $"//ancestor::*[contains(@class, 'element-group')]" +
                $"//*[contains(@class, 'element-list')]" +
                $"//*[contains(text(),'{label}')]/.."), name) { }
    }
}
