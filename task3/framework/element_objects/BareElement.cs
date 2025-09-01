using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.framework.element_utils
{
    internal class BareElement : BaseElement
    {
        public BareElement(By locator, string name) : base(locator, name)
        {
        }
    }
}
