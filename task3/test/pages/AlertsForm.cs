using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.element_utils;
using task3.framework.page;

namespace task3.test.pages
{
    internal class AlertsForm : BaseForm
    {
        BaseButton alertButton;
        BaseButton confirmBoxButton;
        BaseButton promptBoxButton;
        public AlertsForm(string name) : base(new BareElement(By.Id("javascriptAlertsWrapper"), 
            "AlertsForm identifying element"), 
            name)
        {
            alertButton = new BaseButton(By.Id("alertButton"), "'Click Button to see alert' button");
            confirmBoxButton = new BaseButton(By.Id("confirmButton"), 
                "'On button click, confirm box will appear' button");
            promptBoxButton = new BaseButton(By.Id("promtButton"),
                "'On button click, prompt box will appear' button");
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

        public bool IsConfirmBoxOkMessageDisplayed()
        {
            BareElement confirmationMessage = new BareElement(By.Id("confirmResult"), 
                                                                    "Confirm box pressed ok message");
            if (!confirmationMessage.IsPresent())
            {
                return false;
            }
            if(confirmationMessage.GetText().Equals("You selected Ok"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
