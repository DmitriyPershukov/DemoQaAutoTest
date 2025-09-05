using OpenQA.Selenium;
using task3.framework.element_utils;
using task3.framework.page;

namespace task3.test.pages
{
    public class SamplePage : BaseForm
    {
        private const string name = "Sample Page";
        public SamplePage() : base(
            new BareElement(By.Id("sampleHeading"), "SamplePage identifying element"), name)
        {}
    }
}
