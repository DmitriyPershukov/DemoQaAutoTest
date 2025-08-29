using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.config_utils;
using task3.framework.web_driver;
using task3.test.tests.global_test_data;

namespace task3.framework.test
{
    abstract public class BaseTest
    {
        protected GlobalTestData globalTestData;
        public virtual void Setup()
        {
            globalTestData = ConfigManager.GetConfigurationModel<GlobalTestData>();
        }

        public virtual void Teardown()
        {
            WebDriverProvider.SetInstanceNull();
        }
    }
}
