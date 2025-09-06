using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.Framework.ConfigModel;

namespace task3.Test.TestDataModels
{
    public class IframeHasCorrectTextTestData : IConfig
    {
        private const string ConfigFilePath =
            "Test\\TestData\\iframe_has_correct_text_test_data.json";
        public static string GetConfigFilePath()
        {
            return ConfigFilePath;
        }

        public string[]? NestedFramesRequiredText;
    }
}
