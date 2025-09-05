using OpenQA.Selenium;
using task3.framework.element_utils;
using task3.framework.page;

namespace task3.test.pages
{
    public class AlertsForm : BaseForm
    {
        private const string name = "Alerts Form";

        Button alertButton;
        Button confirmBoxButton;
        Button promptBoxButton;
        
        public AlertsForm() : base(new BareElement(By.Id("javascriptAlertsWrapper"), 
            "AlertsForm identifying element"), 
            name)
        {
            alertButton = new Button(By.Id("alertButton"), "Alert");
            confirmBoxButton = new Button(By.Id("confirmButton"), 
                "Confirm box alert");
            promptBoxButton = new Button(By.Id("promtButton"),
                "Prompt box alert");
        }

        public void ClickAlertButton()
        {
            alertButton.Click();
        }

        public void ClickConfirmBoxButton()
        {
            confirmBoxButton.Click();
        }

        public void ClickPromptBoxButton()
        {
            promptBoxButton.Click();
        }

        public string GetConfirmBoxConfirmationText()
        {
            BareElement confirmationMessage = new BareElement(By.Id("confirmResult"),
                                                                    "Confirm box alert confirmation text");
            if (confirmationMessage.IsPresent())
            {
                return confirmationMessage.GetText();
            }
            else
            {
                throw new Exception("Confirmation text element is missing.");
            }
        }

        public string GetPromptBoxConfirmationText()
        {
            BareElement confirmationMessage = new BareElement(By.Id("promptResult"),
                                                                    "Prompt box alert confirmation text");
            if (confirmationMessage.IsPresent())
            {
                return confirmationMessage.GetText().Substring(12);
            }
            else
            {
                throw new Exception("Confirmation text element is missing.");
            }
        }
    }
}
