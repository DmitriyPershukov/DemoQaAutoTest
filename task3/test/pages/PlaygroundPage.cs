using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.element_utils;
using task3.framework.page;
using task3.test.elements;

namespace task3.test.pages
{
    public class PlaygroundPage : BaseForm
    {
        private Accordion accordion;
        public PlaygroundPage(string name) : 
            base(new BareElement(By.XPath("//*[contains(@class, 'playgound-body')]"), 
                "Playground page identifying element"), 
                name)
        {
            accordion = new Accordion($"Accordion element of page: {name}");
        }

        public bool IsDropDownMenuCollapsed(string label)
        {
            return accordion.
                GetDropDownMenu(label).
                GetElementList().
                IsCollapsed();
        }

        public void ClickAccordionMenuElement(string menuLabel, string menuElementLabel)
        {
            accordion.
                GetDropDownMenu(menuLabel)
                .GetElementList()
                .GetElement(menuElementLabel)
                .Click();
        }
    }
}
