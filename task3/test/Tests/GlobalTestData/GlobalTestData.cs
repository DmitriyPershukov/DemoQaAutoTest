using task3.Framework.Utils.ConfigUtils;

namespace task3.test.tests.global_test_data
{
    public class GlobalTestData : IConfig
    {
        private const string ConfigFilePath = "Test\\Tests\\GlobalTestData\\global_test_data.json";
        public static string GetConfigFilePath()
        {
            return ConfigFilePath;
        }

        public string? MainPageURL;
    }
}
