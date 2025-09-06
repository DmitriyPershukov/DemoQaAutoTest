using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.element_utils;

namespace task3.Framework.ElementObjects
{
    internal class ElementContainer : BaseElement
    {
        public ElementContainer(By locator, string name) : base(locator, name)
        {
        }
    }
}
