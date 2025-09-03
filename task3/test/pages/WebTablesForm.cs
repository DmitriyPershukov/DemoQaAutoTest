using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using task3.framework.element_utils;
using task3.framework.page;
using task3.framework.web_driver;
using task3.test.tests.registration_form_add_delete;

namespace task3.test.pages
{
    internal class WebTablesForm : BaseForm
    {
        BaseButton addButton;
        int padrowCount;
        public WebTablesForm(string name) : base(
            new BareElement(By.XPath("//*[contains(@class, 'rt-table')]"), "WebTables Page identifying element"), 
            name)
        {
            addButton = new BaseButton(By.Id("addNewRecordButton"), "Add new record");
            padrowCount = GetPadrowCount();
        }

        public void ClickAddButton()
        {
            addButton.Click();
        }

        public User[] GetUsers()
        {
            List<User> users = new List<User>();
            var rows = WebDriverProvider.GetInstance()
                .FindElements(By.XPath("//*[contains(@class, 'rt-tbody')]" +
                "//*[@role='row' and not(contains(@class, '-padRow'))]"));
            foreach (var row in rows) 
            {
                var cellsText = row
                    .FindElements(By.XPath(".//*[@role='gridcell']"))
                    .Select(cell => cell.Text)
                    .ToArray();
                if (String.IsNullOrWhiteSpace(cellsText[0]))
                {
                    break;
                }
                users.Add(new User(cellsText[0], cellsText[1], Int32.Parse(cellsText[2]),
                        cellsText[3], Int32.Parse(cellsText[4]), cellsText[5]));
            }
            return users.ToArray();
        }

        public void WaitNewRowAppear(TimeSpan timeout)
        {
            WebDriverWait wait = new WebDriverWait(WebDriverProvider.GetInstance(), timeout);
            wait.Until(d => 
            { 
                var newPadrowCount = GetPadrowCount();
                if (padrowCount != newPadrowCount)
                {
                    padrowCount = newPadrowCount;
                    return true;
                }
                return false;
            });
        }

        private int GetPadrowCount()
        {
            return WebDriverProvider
                .GetInstance()
                .FindElements(By.XPath("//*[contains(@class, '-padRow')]"))
                .Count;
        }
    }
}
