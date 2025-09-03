using OpenQA.Selenium;
using task3.framework.element_utils;

namespace task3.test.elements
{
    public class MenuElementList : BaseElement
    {
        private Dictionary<string, MenuElement> elements;
        private string label;
        public MenuElementList(By locator, string name) : base(locator, name) {
            elements = new Dictionary<string, MenuElement>();
        }

        public MenuElementList(string label, string name) : this(By.XPath($"//*[contains(text(), '{label}')]" +
                $"//ancestor::*[contains(@class, 'element-group')]" +
                $"//*[contains(@class, 'element-list')]"), name)
        {
            this.label = label;
        }

        public bool IsCollapsed()
        {
            return !GetElement().GetAttribute("class").Contains("show");
        }

        public MenuElement GetElement(string elementLabel)
        {
            if (!elements.ContainsKey(elementLabel))
            {
                elements.Add(elementLabel, 
                    new MenuElement(this.label, 
                    elementLabel, $"Element '{elementLabel}' of menu list '{this.label}'"));
            }
            return elements[elementLabel];
        }
    }
}
