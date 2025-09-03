using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.config_utils;
using task3.framework.testing_utils;
using task3.framework.web_driver;
using task3.test.tests.global_test_data;

namespace task3.framework.test
{
    abstract public class BaseTest
    {
        protected GlobalTestData globalTestData;
        public virtual void Setup()
        {
            LogTestStart();
            globalTestData = TestDataManager.GetTestDataModel<GlobalTestData>();
            
        }

        public virtual void Teardown()
        {
            WebDriverProvider.SetInstanceNull();
            LogTestEnd();
        }

        protected void LogTestStart()
        {
            LoggingManager.GetLogger().Info($"Starting test: {GetType().Name}");
        }

        protected void LogTestEnd()
        {
            LoggingManager.GetLogger().Info($"Ended test: {GetType().Name}");
        }
    }
}
