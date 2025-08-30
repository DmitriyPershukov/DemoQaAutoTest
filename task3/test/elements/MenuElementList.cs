using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.element_utils;

namespace task3.test.elements
{
    public class MenuElementList : BaseElement
    {
        public MenuElementList(By locator, string name) : base(locator, name)
        {
        }

        public bool IsCollapsed()
        {
            return !GetElement().GetAttribute("class").Contains("show");
        }
    }
}
