using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.config_utils;

namespace task3.test.tests.registration_form_add_delete
{
    public class RegistrationFormAddDeleteTestData : IConfig
    {
        private const string ConfigFilePath =
            "test\\tests\\registration_form_add_delete\\registration_form_add_delete_test_data.json";
        public static string GetConfigFilePath()
        {
            return ConfigFilePath;
        }

        public int UserNumber;
        public string? FirstName;
        public string? LastName;
        public string? Email;
        public int Age;
        public int Salary;
        public string? Department;
    }
}
