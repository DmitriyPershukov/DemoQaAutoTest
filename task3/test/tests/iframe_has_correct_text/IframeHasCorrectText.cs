using NUnit.Framework;
using task3.framework.browser_utils;
using task3.framework.config_utils;
using task3.framework.test;
using task3.framework.testing_utils;
using task3.framework.web_driver;
using task3.test.pages;
using task3.test.tests.button_displays_correct_alert;

namespace task3.test.tests.iframe_has_correct_text
{
    public class IframeHasCorrectText : BaseTest
    {
        MainPage mainPage;
        PlaygroundPage playgroundPage;
        NestedFramesForm nestedFramesForm;
        FramesForm framesForm;
        IframeHasCorrectTextTestData testData;

        [SetUp]
        public override void Setup()
        {
            base.Setup();
            mainPage = new MainPage("Main Page");
            playgroundPage = new PlaygroundPage("Playground Page");
            nestedFramesForm = new NestedFramesForm("Nested Frames Form");
            framesForm = new FramesForm("Frames Form");
            testData = TestDataManager.GetTestDataModel<IframeHasCorrectTextTestData>();
        }

        [TearDown]
        public override void Teardown()
        {
            base.Teardown();
        }

        [Test]
        public void ButtonDisplaysCorrectAlertTest()
        {
            WebDriverProvider.GetInstance().Navigate().GoToUrl(globalTestData.MainPageURL);
            Assert.That(mainPage.IsOpened(), "After navigating to main page it was not opened.");

            mainPage.ClickAlertsWindowsButton();
            playgroundPage.ClickAccordionMenuElement("Alerts", "Nested Frames");
            Assert.That(playgroundPage.IsOpened() && nestedFramesForm.IsOpened(),
                "Alerts, Frame & Windows button was clicked and button Alerts was clicked in left menu " +
                "but Frames form was not opened.");

            Assert.That(nestedFramesForm.AreStringsPresent(testData.NestedFramesRequiredText), 
                "Nested frames form should contain ");
        }
    }
}
