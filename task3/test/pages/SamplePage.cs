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
    public class SamplePage : BaseForm
    {
        public SamplePage(string name) : base(
            new BareElement(By.Id("//*[@id='sampleHeading']"), "SamplePage identifying element"), name)
        {}
    }
}
