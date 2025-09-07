using OpenQA.Selenium;
using task3.framework.element_utils;
using task3.framework.page;
using task3.Framework.ElementObjects;

namespace task3.test.pages
{
    public class AlertsForm : BaseForm
    {
        private const string name = "Alerts Form";

        private Button alertButton;
        private Button confirmBoxButton;
        private Button promptBoxButton;
        private TextBox confirmBoxConfirmationText;
        private TextBox promptBoxConfirmationText;

        public AlertsForm() : base(new ElementContainer(By.Id("javascriptAlertsWrapper"),
            "AlertsForm identifying element"), name)
        {
            alertButton = new Button(By.Id("alertButton"), "Alert");
            confirmBoxButton = new Button(By.Id("confirmButton"),
                "Confirm box alert");
            promptBoxButton = new Button(By.Id("promtButton"),
                "Prompt box alert");
            confirmBoxConfirmationText = new TextBox(By.Id("confirmResult"),
                                                           "Confirm box alert confirmation text");
            promptBoxConfirmationText = new TextBox(By.Id("promptResult"),
                                                          "Prompt box alert confirmation text");
        }

        private Button AlertButton { get => alertButton; }

        public void ClickAlertButton()
        {
            AlertButton.Click();
        }
        private Button ConfirmBoxButton { get => confirmBoxButton; }

        public void ClickConfirmBoxButton()
        {
            ConfirmBoxButton.Click();
        }
        private Button PromptBoxButton { get => promptBoxButton; }

        public void ClickPromptBoxButton()
        {
            PromptBoxButton.Click();
        }

        private TextBox ConfirmBoxConfirmationText { get => confirmBoxConfirmationText; }

        public string GetConfirmBoxConfirmationText()
        {
            if (ConfirmBoxConfirmationText.IsPresent())
            {
                return ConfirmBoxConfirmationText.GetText(); ;
            }
            else
            {
                throw new Exception("Confirmation text element is missing.");
            }
        }

        private TextBox PromptBoxConfirmationText { get => promptBoxConfirmationText; }

        public string GetPromptBoxConfirmationText()
        {
            if (PromptBoxConfirmationText.IsPresent())
            {
                return PromptBoxConfirmationText.GetText();
            }
            else
            {
                throw new Exception("Confirmation text element is missing.");
            }
        }
    }
}
