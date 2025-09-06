using task3.Framework.ConfigModel;

namespace task3.Test.TestDataModels
{
    public class GlobalTestData : IConfig
    {
        private const string ConfigFilePath = "Test\\TestData\\global_test_data.json";
        public static string GetConfigFilePath()
        {
            return ConfigFilePath;
        }

        public string? MainPageURL;
    }
}
