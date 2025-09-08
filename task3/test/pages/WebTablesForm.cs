using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Reflection.Metadata;
using task3.framework.element_utils;
using task3.framework.page;
using task3.framework.web_driver;
using task3.Framework.ElementObjects;
using task3.Framework.Logging;
using task3.Test.Elements;
using task3.Test.Models;

namespace task3.test.pages
{
    public class WebTablesForm : BaseForm
    {
        private const string name = "Web Tables Form";

        private Button addButton;
        private int rowCount;
        private Table table;

        public WebTablesForm() : base(
            new ElementContainer(By.XPath("//*[contains(@class, 'rt-table')]"), "WebTables Page identifying element"),
            name)
        {
            addButton = new Button(By.Id("addNewRecordButton"), "Add new record");
            table = new Table("Table");
        }

        private Button AddButton { get => addButton; }

        private Table Table { get => table; }

        public void ClickAddButton()
        {
            AddButton.Click();
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
            Table.DeleteUser(user);
        }

        public User[] GetUsers()
        {
            return Table.GetRows().Select(r => r.GetUser()).ToArray();
        }
    }
}
