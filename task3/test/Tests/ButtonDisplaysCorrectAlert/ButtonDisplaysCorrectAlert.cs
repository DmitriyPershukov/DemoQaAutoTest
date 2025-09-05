using NUnit.Framework;
using task3.framework.test;
using task3.framework.testing_utils;
using task3.framework.web_driver;
using task3.Framework.Utils.BrowserUtils;
using task3.Framework.Utils.ConfigUtils;
using task3.test.pages;

namespace task3.test.tests.button_displays_correct_alert
{
    public class ButtonDisplaysCorrectAlert : BaseTest
    {
        MainPage mainPage;
        PlaygroundPage playgroundPage;
        AlertsForm alertsForm;
        ButtonDisplaysCorrectAlertTestData testData;

        [SetUp]
        public override void Setup()
        {
            base.Setup();
            mainPage = new MainPage();
            playgroundPage = new PlaygroundPage();
            alertsForm = new AlertsForm();
            testData = TestDataManager.GetTestDataModel<ButtonDisplaysCorrectAlertTestData>();
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

            alertsForm.ClickAlertButton();
            Assert.That(AlertUtils.GetAlertText(), Is.EqualTo(testData.AlertText),
                "'Click Button to see alert' button was clicked " +
                $"but alert with text '{testData.AlertText}' did not appear.");

            AlertUtils.ClickOk();
            Assert.That(!AlertUtils.IsAlertPresent(),
                "Ok button on alert was clicked but alert is still present.");

            alertsForm.ClickConfirmBoxButton();
            Assert.That(AlertUtils.GetAlertText(), Is.EqualTo(testData.ConfirmBoxAlertText),
                "'On button click, confirm box will appear' button was clicked " +
                $"but alert with text '{testData.ConfirmBoxAlertText}' did not appear.");

            AlertUtils.ClickOk();
            Assert.That(!AlertUtils.IsAlertPresent(), 
                "Ok button in confirm box alert was clicked but alert was not closed.");
            Assert.That(alertsForm.GetConfirmBoxConfirmationText(), Is.EqualTo(testData.ConfirmBoxConfirmationText),
                $"Ok button in confirm box alert was clicked " +
                $"but '{testData.ConfirmBoxConfirmationText}' did not appear.");

            alertsForm.ClickPromptBoxButton();
            Assert.That(AlertUtils.GetAlertText(), Is.EqualTo(testData.PromptBoxAlertText),
                "'On button click, prompt box will appear' button was clicked " +
                $"but alert with text '{testData.PromptBoxAlertText}' did not appear.");

            var randomText = RandomUtils.GetRandomText(testData.PromptBoxRandomTextLength);
            AlertUtils.EnterText(randomText);
            AlertUtils.ClickOk();
            Assert.That(!AlertUtils.IsAlertPresent(),
                "Ok button in prompt box alert was clicked but alert was not closed.");
            Assert.That(alertsForm.GetPromptBoxConfirmationText(), Is.EqualTo(randomText),
                $"Ok button in prompt box alert was clicked but text '{randomText}' did not appear.");
        }
    }
}
