using OpenQA.Selenium;
using task3.framework.element_utils;
using task3.framework.page;

namespace task3.test.pages
{
    public class BrowserWindowsForm : BaseForm
    {
        BaseButton newTabButton;
        public BrowserWindowsForm(string name) : base(
            new BareElement(By.Id("browserWindows"), "BrowserWindowsForm identifying element"), name)
        {
            newTabButton = new BaseButton(By.Id("tabButton"), "New tab");
        }

        public void ClickNewTabButton()
        {
            newTabButton.Click();
        }
    }
}
