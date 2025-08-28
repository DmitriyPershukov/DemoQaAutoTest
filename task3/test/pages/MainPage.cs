using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.page;
using task3.test.elements;

namespace task3.test.pages
{
    internal class MainPage : BaseForm
    {
        public MainPage(string name) : base(new HomeContentContainer(name + " unique element"), name) { } 
    }
}
