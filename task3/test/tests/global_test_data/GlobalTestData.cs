using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.config_utils;

namespace task3.test.tests.global_test_data
{
    public class GlobalTestData : IConfig
    {
        private const string ConfigFilePath = "test\\tests\\global_test_data\\global_test_data.json";
        public static string GetConfigFilePath()
        {
            return ConfigFilePath;
        }

        public string? MainPageURL;
    }
}
