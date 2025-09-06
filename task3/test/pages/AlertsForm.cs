using OpenQA.Selenium;
using System.ComponentModel;
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
        
        public AlertsForm() : base(new ElementContainer(By.Id("javascriptAlertsWrapper"),
            "AlertsForm identifying element"), name)
        {
            alertButton = new Button(By.Id("alertButton"), "Alert");
            confirmBoxButton = new Button(By.Id("confirmButton"), 
                "Confirm box alert");
            promptBoxButton = new Button(By.Id("promtButton"),
                "Prompt box alert");
        }

        public Button AlertButton 
        {
            get {return alertButton;}
        }

        public Button ConfirmBoxButton 
        { 
            get {return confirmBoxButton;}
        }

        public Button PrpromptBoxButton
        {
            get {return promptBoxButton;}
        }

        public string GetConfirmBoxConfirmationText()
        {
            TextBox confirmationMessage = new TextBox(By.Id("confirmResult"),
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
            TextBox confirmationMessage = new TextBox(By.Id("promptResult"),
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
