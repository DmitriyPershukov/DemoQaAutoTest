using OpenQA.Selenium;
using task3.framework.element_utils;
using task3.framework.page;
using task3.Framework.ElementObjects;

namespace task3.test.pages
{
    public class LinksForm : BaseForm
    {
        private const string name = "Links Form";

        private Button homeLink;
        
        public LinksForm() : base(
            new ElementContainer(By.Id("linkWrapper"), "LinksForm identifying element"), name)
        {
            homeLink = new Button(By.Id("simpleLink"), "Home Link");
        }

        private Button HomeLink { get => homeLink; }

        public void ClickHomeLink()
        {
            HomeLink.Click();
        }
    }
}
