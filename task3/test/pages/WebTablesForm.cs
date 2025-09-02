using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.element_utils;
using task3.framework.page;

namespace task3.test.pages
{
    internal class WebTablesForm : BaseForm
    {
        public WebTablesForm(string name) : base(
            new BareElement(By.XPath("//*[contains(@class, 'rt - table')]"), "WebTables Page identifying element"), 
            name){}
    }
}
