using OpenQA.Selenium;
using task3.framework.element_utils;

namespace task3.Framework.ElementObjects
{
    public class ElementContainer : BaseElement
    {
        public ElementContainer(By locator, string name) : base(locator, name)
        {
        }
    }
}
