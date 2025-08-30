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
        AlertsForm alertsForm;

        [SetUp]
        public override void Setup()
        {
            base.Setup();
            mainPage = new MainPage("Main Page");
            playgroundPage = new PlaygroundPage("Playground Page");
            alertsForm = new AlertsForm("Alerts Form");
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
            playgroundPage.ClickAccordionMenuElement("Alerts", "Alerts");
            Assert.That(playgroundPage.IsOpened() && alertsForm.IsOpened(),
                "Alerts, Frame & Windows button was clicked and button Alerts was clicked in left menu " +
                "but Alerts form was not opened.");
        }
    }
}
