using OpenQA.Selenium;
using task3.framework.element_utils;
using task3.framework.page;
using task3.Framework.ElementObjects;

namespace task3.test.pages
{
    public class BrowserWindowsForm : BaseForm
    {
        private const string name = "Browser Windows Form";

        Button newTabButton;
        
        public BrowserWindowsForm() : base(
            new ElementContainer(By.Id("browserWindows"), "BrowserWindowsForm identifying element"), name)
        {
            newTabButton = new Button(By.Id("tabButton"), "New tab");
        }

        public Button NewTabButton { get => newTabButton;}
    }
}
