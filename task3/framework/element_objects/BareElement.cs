using OpenQA.Selenium;

namespace task3.framework.element_utils
{
    public class BareElement : BaseElement
    {
        public BareElement(By locator, string name) : base(locator, name)
        {
        }
    }
}
