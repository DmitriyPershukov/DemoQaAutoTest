using task3.Framework.ConfigModel;
using task3.Test.Models;

namespace task3.Test.TestDataModels
{
    public class RegistrationFormAddDeleteTestData : IConfig
    {
        private const string ConfigFilePath =
            "Test\\TestData\\registration_form_add_delete_test_data.json";
        public static string GetConfigFilePath()
        {
            return ConfigFilePath;
        }

        public User[]? Users;
    }
}
