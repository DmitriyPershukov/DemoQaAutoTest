using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.element_utils;
using task3.framework.web_driver;

namespace task3.test.elements
{
    internal class Accordion : BaseElement
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
