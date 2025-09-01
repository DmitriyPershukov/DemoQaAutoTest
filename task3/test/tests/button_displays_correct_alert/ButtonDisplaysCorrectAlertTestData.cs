using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.config_utils;

namespace task3.test.tests.button_displays_correct_alert
{
    public class ButtonDisplaysCorrectAlertTestData : IConfig
    {
        private const string ConfigFilePath = 
            "test\\tests\\button_displays_correct_alert\\button_displays_correct_alert_test_data.json";
        public static string GetConfigFilePath()
        {
            return ConfigFilePath;
        }

        public int PromptBoxRandomTextLength;
        public string? AlertText;
        public string? ConfirmBoxAlertText;
        public string? PromptBoxAlertText;
        public string? ConfirmBoxConfirmationText;
    }
}
