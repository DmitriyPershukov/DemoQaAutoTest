using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.element_utils;
using task3.framework.web_driver;
using task3.Test.Models;

namespace task3.Test.Elements
{
    public class TableRow : BaseElement
    {
        private Button deleteButton;
        public TableRow(By locator, string name) : base(locator, name)
        {
            deleteButton = new Button(
                By.XPath($"{Locator.Criteria}//*[contains(@id, 'delete-record')]"), 
                $"{name} delete");
        }

        private Button DeleteButton { get { return deleteButton; } }

        public void DeleteRow()
        {
            DeleteButton.Click();
        }

        public User GetUser()
        {
            WebDriverWait wait = new WebDriverWait(WebDriverProvider.GetInstance(), TimeSpan.FromSeconds(2));
            string[] cellsText = new string[6];
            for (int i = 0; i < cellsText.Length; i++) 
            {
                wait.Until(d =>
                {
                    string cellText = GetElement()
                        .FindElement(By.XPath($"{Locator.Criteria}//*[@role='gridcell'][{i + 1}]"))
                        .Text;
                    if (String.IsNullOrWhiteSpace(cellText))
                    {
                        return false;
                    }
                    cellsText[i] = cellText;
                    return true;
                });
                
            }
            return new User(cellsText[0], cellsText[1], Int32.Parse(cellsText[2]),
                    cellsText[3], Int32.Parse(cellsText[4]), cellsText[5]);
        }
    }
}
