using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.element_utils;

namespace task3.test.elements
{
    public class HomeContentContainer : BaseElement
    {
        public HomeContentContainer(string name) : 
            base(By.XPath("//*[contains(@class, 'home-content')]"),
            name){}
    }
}
