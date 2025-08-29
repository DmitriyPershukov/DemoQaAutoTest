using NUnit.Framework;
using task3.framework.test;
using task3.framework.web_driver;
using task3.test.pages;

namespace task3.test.tests.button_displays_correct_alert
{
    public class ButtonDisplaysCorrectAlert : BaseTest
    {
        MainPage mainPage;
        PlaygroundPage playgroundPage;

        [SetUp]
        public override void Setup()
        {
            base.Setup();
            mainPage = new MainPage("Main Page");
            playgroundPage = new PlaygroundPage("Playground Page");
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
            playgroundPage.WaitDropDownMenuAnimationFinish();
            Assert.That(playgroundPage.IsOpened(), "Page is not opened.");
            //Assert.That(!playgroundPage.IsDropDownMenuCollapsed("Alerts, Frame & Windows"), "Alerts, Frame & Windows not opened");
            Assert.That(!playgroundPage.IsDropDownMenuCollapsed("Alerts"), "Alerts not opened");
            Assert.That(playgroundPage.IsOpened() && !playgroundPage.IsDropDownMenuCollapsed("Alerts, Frame & Windows"),
                "Alerts, Frame & Windows button was clicked but Alerts, Frame & Windows page was not opened.");
        }
    }
}
