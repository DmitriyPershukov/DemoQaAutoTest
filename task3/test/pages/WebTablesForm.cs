using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using task3.framework.element_utils;
using task3.framework.page;
using task3.framework.web_driver;
using task3.Framework.Logging;
using task3.Test.TestDataModels;

namespace task3.test.pages
{
    public class WebTablesForm : BaseForm
    {
        private const string name = "Web Tables Form";

        private Button addButton;
        private int rowCount;
        
        public WebTablesForm() : base(
            new TextBox(By.XPath("//*[contains(@class, 'rt-table')]"), "WebTables Page identifying element"), 
            name)
        {
            addButton = new Button(By.Id("addNewRecordButton"), "Add new record");
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
                WebDriverWait wait = new WebDriverWait(WebDriverProvider.GetInstance(), TimeSpan.FromSeconds(2));
                string[] cellsText = new string[6];
                try
                {
                    wait.Until(d =>
                    {
                        cellsText = row
                            .FindElements(By.XPath(".//*[@role='gridcell']"))
                            .Select(cell => cell.Text)
                            .ToArray();
                        foreach (var text in cellsText) 
                        {
                            if (String.IsNullOrWhiteSpace(text))
                            {
                                return false;
                            }
                        }
                        return true;
                    });
                }
                catch (Exception ex)
                {
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
                if (RowCountChanged())
                {
                    rowCount = GetRowCount();
                    return true;
                }
                return false;
            });
        }

        public bool RowCountChanged()
        {
            return rowCount != GetRowCount();
        }

        public void RefreshRowCount()
        {
            rowCount = GetRowCount();
        }

        private int GetRowCount()
        {
            return WebDriverProvider
                .GetInstance()
                .FindElements(By.XPath("//*[contains(@class, 'rt-tbody')]" +
                "//*[@role='row' and not(contains(@class, '-padRow'))]"))
                .Count();
        }

        public void DeleteUser(User user)
        {
            var rows = WebDriverProvider.GetInstance()
                .FindElements(By.XPath("//*[contains(@class, 'rt-tbody')]" +
                "//*[@role='row' and not(contains(@class, '-padRow'))]"));
            foreach (var row in rows)
            {
                WebDriverWait wait = new WebDriverWait(WebDriverProvider.GetInstance(), TimeSpan.FromSeconds(2));
                string[] cellsText = new string[6];
                try
                {
                    wait.Until(d =>
                    {
                        cellsText = row
                            .FindElements(By.XPath(".//*[@role='gridcell']"))
                            .Select(cell => cell.Text)
                            .ToArray();
                        foreach (var text in cellsText)
                        {
                            if (String.IsNullOrWhiteSpace(text))
                            {
                                return false;
                            }
                        }
                        return true;
                    });
                }
                catch (Exception ex)
                {
                }
                if(new User(cellsText[0], cellsText[1], Int32.Parse(cellsText[2]),
                        cellsText[3], Int32.Parse(cellsText[4]), cellsText[5]).Equals(user))
                {
                    LoggingManager.GetLogger().Debug($"Deleting user: {user}");
                    row.FindElement(By.XPath(".//*[contains(@id, 'delete-record')]")).Click();
                    break;
                }
            }
        }
    }
}
