using OpenQA.Selenium;

namespace task3.framework.element_utils
{
    public class TextBox : BaseElement
    {
        public TextBox(By locator, string name) : base(locator, name)
        {
        }
    }
}
