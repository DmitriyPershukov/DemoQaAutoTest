using task3.Framework.ConfigModel;

namespace task3.Test.TestDataModels
{
    public class ButtonDisplaysCorrectAlertTestData : IConfig
    {
        private const string ConfigFilePath = 
            "Test\\TestData\\button_displays_correct_alert_test_data.json";
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
