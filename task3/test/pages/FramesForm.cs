using OpenQA.Selenium;
using task3.framework.element_utils;
using task3.framework.page;
using task3.Framework.Utils.BrowserUtils;

namespace task3.test.pages
{
    public class FramesForm : BaseForm
    {
        private const string name = "Frames Form";
        public FramesForm() : base(
            new BareElement(By.XPath("//*[@id='framesWrapper']//*[contains(text(), 'Frames')]"),
            "FramesForm identifying element"), 
            name){}

        public string GetTopIframeText()
        {
            return GetIframeText("frame1");
        }
        public string GetBottomIframeText()
        {
            return GetIframeText("frame2");
        }

        private string GetIframeText(string id)
        {
            IframeUtils.SwitchToIframe(By.Id(id));
            var text = GetCurrentIframeText();
            IframeUtils.SwitchToDefaultContent();
            return text;
        }

        private string GetCurrentIframeText()
        {
            BareElement textElement = new BareElement(By.Id("sampleHeading"), "");
            textElement.WaitUntilPresent(TimeSpan.FromSeconds(2));
            return textElement.GetText();
        }
    }
}
