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
            name)
        {
        }

        private bool IsTextPresentOnPage(string text)
        {
            return new TextBox(By.XPath($"//*[contains(text(), '{text}')]"), "").IsPresent();
        }

        public bool AreStringsPresent(string[] strings)
        {
            WebDriverWait wait = new WebDriverWait(WebDriverProvider.GetInstance(), TimeSpan.FromSeconds(2));
            List<string> stringsToCheck = new List<string>(strings);
            foreach (string s in stringsToCheck)
            {
                bool parentIframeHasText = false;
                bool childIframeHasText = false;
                IframeUtils.SwitchToFirstIframe();
                TextBox iframeElement = new TextBox(By.XPath("//iframe"), "iframe body");
                wait.Until(d => iframeElement.IsPresent());
                parentIframeHasText = IsTextPresentOnPage(s);   
                IframeUtils.SwitchToFirstIframe();
                iframeElement = new TextBox(By.XPath("//p"), "iframe body");
                wait.Until(d => iframeElement.IsPresent());
                childIframeHasText = IsTextPresentOnPage(s);
                IframeUtils.SwitchToDefaultContent();
                if ((parentIframeHasText || childIframeHasText).Equals(false))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
