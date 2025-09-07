using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using task3.framework.element_utils;
using task3.framework.page;
using task3.framework.web_driver;
using task3.Framework.Utils.BrowserUtils;

namespace task3.test.pages
{
    public class NestedFramesForm : BaseForm
    {
        private const string name = "Nested Frames Form";
        public NestedFramesForm() : base(
            new TextBox(By.XPath("//*[@id='framesWrapper']//*[contains(text(), 'Nested Frames')]"),
                "NestedFramesForm identifying element"), 
            name){}

        public string[] GetNestedIframesText()
        {
            WebDriverWait wait = new WebDriverWait(WebDriverProvider.GetInstance(), TimeSpan.FromSeconds(2));
            string[] iframesText = new string[2];
            IframeUtils.SwitchToFirstIframe();
            TextBox iframeElement = new TextBox(By.XPath("//iframe"), "iframe body");
            wait.Until(d => iframeElement.IsPresent());
            iframesText[0] = GetIframeText();
            IframeUtils.SwitchToFirstIframe();
            iframeElement = new TextBox(By.XPath("//p"), "iframe body");
            wait.Until(d => iframeElement.IsPresent());
            iframesText[1] = GetIframeText();
            IframeUtils.SwitchToDefaultContent();
            return iframesText;
        }

        private string GetIframeText()
        {
            return WebDriverProvider.GetInstance().FindElement(By.XPath("//body")).Text;
        }
    }
}
