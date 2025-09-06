using OpenQA.Selenium;
using task3.framework.element_utils;
using task3.framework.page;

namespace task3.test.pages
{
    public class LinksForm : BaseForm
    {
        private const string name = "Links Form";

        Button homeLink;
        
        public LinksForm() : base(
            new TextBox(By.Id("linkWrapper"), "LinksForm identifying element"), name)
        {
            homeLink = new Button(By.Id("simpleLink"), "Home Link");
        }

        public void ClickHomeLink()
        {
            homeLink.Click();
        }
    }
}
