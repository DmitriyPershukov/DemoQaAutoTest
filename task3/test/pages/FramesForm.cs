using OpenQA.Selenium;
using task3.framework.element_utils;
using task3.framework.page;
using task3.framework.web_driver;

namespace task3.test.pages
{
    public class FramesForm : BaseForm
    {
        public FramesForm(string name) : base(
            new BareElement(By.Id("framesWrapper"), "FramesForm identifying element"), 
            name)
        {}
    }
}
