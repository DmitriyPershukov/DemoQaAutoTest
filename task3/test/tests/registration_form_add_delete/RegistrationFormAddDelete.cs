using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.config_utils;
using task3.framework.element_utils;
using task3.framework.page;
using task3.framework.test;
using task3.framework.web_driver;
using task3.test.pages;
using task3.test.tests.global_test_data;
using task3.test.tests.iframe_has_correct_text;

namespace task3.test.tests.registration_form_add_delete
{
    public class RegistrationFormAddDelete : BaseTest
    {
        MainPage mainPage;
        PlaygroundPage playgroundPage;
        WebTablesForm webTables;
        RegistrationFormAddDeleteTestData testData;

        [SetUp]
        public override void Setup()
        {
            base.Setup();
            mainPage = new MainPage("Main Page");
            playgroundPage = new PlaygroundPage("Playground Page");
            webTables = new WebTablesForm("Web Tables Page");
            testData = TestDataManager.GetTestDataModel<RegistrationFormAddDeleteTestData>();
        }

        [TearDown]
        public override void Teardown()
        {
            base.Teardown();
        }

        [Test]
        public void RegistrationFormAddDeleteTest()
        {
            WebDriverProvider.GetInstance().Navigate().GoToUrl(globalTestData.MainPageURL);
            Assert.That(mainPage.IsOpened(), "After navigating to main page it was not opened.");

            mainPage.ClickElementsButton();
            playgroundPage.ClickAccordionMenuElement("Elements", "Web Tables");
            Assert.That(playgroundPage.IsOpened() && webTables.IsOpened(),
                "Alerts, Frame & Windows button was clicked and button 'Web Tables' was clicked in left menu " +
                "but Web Tables form was not opened.");
        }
    }
}
