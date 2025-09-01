using OpenQA.Selenium;
using task3.framework.element_utils;
using task3.framework.page;

namespace task3.test.pages
{
    public class FramesForm : BaseForm
    {
        public FramesForm(string name) : base(
            new BareElement(By.Id("framesWrapper"), "FramesForm identifying element"), 
            name)
        {
        }

        public bool ContainsText (string text)
        {
            var b = IdentifyingElement.GetText();
            return IdentifyingElement.GetText().Contains(text);
        }
    }
}
