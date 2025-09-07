using task3.framework.element_utils;

namespace task3.framework.page
{
    public class BaseForm
    {
        private BaseElement identifyingElement;
        private string name;
        public BaseForm(BaseElement identifyingElement, string name)
        {
            this.identifyingElement = identifyingElement;
            this.name = name;
        }

        public string Name { get { return name; } }

        public BaseElement IdentifyingElement { get { return identifyingElement; } }

        public virtual bool IsOpened()
        {
            return identifyingElement.IsPresent();
        }

        public void WaitToLoad(TimeSpan timeout)
        {
            identifyingElement.WaitUntilPresent(timeout);
        }
    }
}
