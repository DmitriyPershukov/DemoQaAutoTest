using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.element_utils;
using task3.Test.Models;

namespace task3.Test.Elements
{
    public class Table : BaseElement
    {
        private static By locator = By.XPath("//*[contains(@class, 'rt-tbody')]");
        public Table(string name) : base(locator, name)
        {}

        private int GetRowCount()
        {
            return GetElement()
                .FindElements(By.XPath(".//*[@role='row' and not(contains(@class, '-padRow'))]"))
                .Count;
        }
        public TableRow[] GetRows()
        {
            int rowCount = GetRowCount();
            TableRow[] rows = new TableRow[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                rows[i] = new TableRow(
                    By.XPath($"({Locator.Criteria}//*[@role='row' and not(contains(@class, '-padRow'))])[{i+1}]"),
                    $"Row number {i}");
            }
            return rows;
        }

        private TableRow GetRow(User user)
        {
            var table = new Table("Table");
            TableRow[] rows = table.GetRows().ToArray();
            foreach (var row in rows)
            {
                if (row.GetUser().Equals(user))
                {
                    return row;
                }
            }
            throw new NoSuchElementException($"No row with user: {user}");
        }

        public void DeleteUser(User user)
        {
            TableRow rowToDelete = GetRow(user);
            rowToDelete.DeleteRow();
        }
    }
}
