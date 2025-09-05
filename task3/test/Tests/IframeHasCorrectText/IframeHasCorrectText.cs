using NUnit.Framework;
using task3.framework.config_utils;
using task3.framework.test;
using task3.framework.web_driver;
using task3.test.pages;

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
            mainPage = new MainPage();
            playgroundPage = new PlaygroundPage();
            nestedFramesForm = new NestedFramesForm();
            framesForm = new FramesForm();
            testData = TestDataManager.GetTestDataModel<IframeHasCorrectTextTestData>();
        }

        [TearDown]
        public override void Teardown()
        {
            base.Teardown();
        }

        [Test]
        public void IframeHasCorrectTextTest()
        {
            WebDriverProvider.GetInstance().Navigate().GoToUrl(globalTestData.MainPageURL);
            Assert.That(mainPage.IsOpened(), "After navigating to main page it was not opened.");

            mainPage.ClickAlertsWindowsButton();
            playgroundPage.ClickAccordionMenuElement("Alerts", "Nested Frames");
            Assert.That(playgroundPage.IsOpened() && nestedFramesForm.IsOpened(),
                "Alerts, Frame & Windows button was clicked and button 'Nested Frames' was clicked in left menu " +
                "but Nested Frames form was not opened.");

            Assert.That(nestedFramesForm.AreStringsPresent(testData.NestedFramesRequiredText), 
                "Nested frames form should contain ");

            playgroundPage.ClickAccordionMenuElement("Alerts", "Frames");
            Assert.That(playgroundPage.IsOpened() && framesForm.IsOpened(),
                "Alerts, Frame & Windows button was clicked and button 'Frames' was clicked in left menu " +
                "but Frames form was not opened.");

            var topIframeText = framesForm.GetTopIframeText();
            var bottomIframeText = framesForm.GetBottomIframeText();
            Assert.That(topIframeText, Is.EqualTo(bottomIframeText),
                "Text from top fram should be equal to the text in the bottom frame " +
                "but following values were received.\n" +
                $"Top iframe text: {topIframeText}\n" +
                $"Bottom iframe text: {bottomIframeText}");
        }
    }
}
