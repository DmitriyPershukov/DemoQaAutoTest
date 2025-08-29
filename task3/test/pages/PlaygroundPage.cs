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
    public class PlaygroundPage : BaseForm
    {
        public PlaygroundPage(string name) : 
            base(new BaseElement(By.XPath("//*[contains(@class, 'playground-body')]"), 
                "Playground page identifying element"), 
                name)
        {}
    }
}
