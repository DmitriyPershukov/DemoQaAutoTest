using OpenQA.Selenium;
using task3.framework.element_utils;

namespace task3.test.elements
{
    public class Accordion : BaseElement
    {
        private Dictionary<string, DropDownMenu> accordionElements;
        public Accordion(string name) : base(By.XPath("//*[contains(@class, 'accordion')]"), name)
        {
            accordionElements = new Dictionary<string, DropDownMenu>();
        }

        public DropDownMenu GetDropDownMenu(string label)
        {
            if (!accordionElements.ContainsKey(label))
            {
                accordionElements.Add(label, new DropDownMenu(label, $"Drop down menu with label: {label}"));
            }
            return accordionElements[label];
        }
    }
}
