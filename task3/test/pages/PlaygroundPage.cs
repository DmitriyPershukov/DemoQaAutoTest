using OpenQA.Selenium;
using task3.framework.element_utils;
using task3.framework.page;
using task3.test.elements;

namespace task3.test.pages
{
    public class PlaygroundPage : BaseForm
    {
        private const string name = "Playground Page";

        private Accordion accordion;
        
        public PlaygroundPage() : 
            base(new TextBox(By.XPath("//*[contains(@class, 'playgound-body')]"), 
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
            var element = accordion
                .GetDropDownMenu(menuLabel)
                .GetElementList()
                .GetElement(menuElementLabel);
            element.WaitUntilDisplayed(TimeSpan.FromSeconds(2));
            element.Click();
        }

        public void ClickDropDownMenuHeader(string label)
        {
            accordion
                .GetDropDownMenu(label)
                .Click();
        }
    }
}
