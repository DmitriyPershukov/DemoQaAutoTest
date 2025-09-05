using task3.Framework.ConfigModel;

namespace task3.test.tests.button_displays_correct_alert
{
    public class ButtonDisplaysCorrectAlertTestData : IConfig
    {
        private const string ConfigFilePath = 
            "Test\\Tests\\ButtonDisplaysCorrectAlert\\button_displays_correct_alert_test_data.json";
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
