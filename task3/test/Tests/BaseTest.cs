using NUnit.Framework;
using task3.framework.web_driver;
using task3.Framework.DataManagers;
using task3.Framework.Logging;
using task3.Test.TestDataModels;

namespace task3.framework.test
{
    [TestFixture]
    public abstract class BaseTest
    {
        protected GlobalTestData globalTestData;

        [SetUp]

        public void Setup()
        {
            LogTestStart();
            globalTestData = TestDataManager.GetTestDataModel<GlobalTestData>();

        }

        [TearDown]
        public void Teardown()
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

        protected void GoToMainPageUrl()
        {
            WebDriverProvider.GetInstance().Navigate().GoToUrl(globalTestData.MainPageURL);
        }
    }
}
