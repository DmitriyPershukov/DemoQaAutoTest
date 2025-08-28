using OpenQA.Selenium;
using task3.framework.element_utils;

namespace task3.framework.page
{
    internal class BaseForm
    {
        private BaseElement identifyingElement;
        private string name;
        public BaseForm(BaseElement identifyingElement, string name) 
        { 
            this.identifyingElement = identifyingElement;
            this.name = name;
        }

        public string Name { get { return name; } }

        public virtual bool IsOpened()
        {
            return identifyingElement.IsPresent();
        }
    }
}
