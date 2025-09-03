using OpenQA.Selenium;
using task3.framework.element_utils;
using task3.framework.page;

namespace task3.test.pages
{
    public class LinksForm : BaseForm
    {
        BaseButton homeLink;
        public LinksForm(string name) : base(
            new BareElement(By.Id("linkWrapper"), "LinksForm identifying element"), name)
        {
            homeLink = new BaseButton(By.Id("simpleLink"), "Home Link");
        }

        public void ClickHomeLink()
        {
            homeLink.Click();
        }
    }
}
