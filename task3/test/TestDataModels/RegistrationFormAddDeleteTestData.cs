using task3.Framework.ConfigModel;

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

    public class User
    {
        public string? FirstName;
        public string? LastName;
        public string? Email;
        public int Age;
        public int Salary;
        public string? Department;

        public User() { }

        public User(string? firstName, string? lastName, int age, string? email, int salary, string? department)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Age = age;
            Salary = salary;
            Department = department;
        }

        public override bool Equals(object? obj)
        {
            var item = obj as User;
            if (item == null)
            {
                return false;
            }
            return FirstName.Equals(item.FirstName) &&
                   LastName.Equals(item.LastName) &&
                   Email.Equals(item.Email) &&
                   Age == item.Age &&
                   Salary == item.Salary &&
                   Department.Equals(item.Department);
        }

        public override string ToString()
        {
            return $"{{FirstName: {FirstName}, LastName: {LastName}, Email: {Email}, Age: {Age}, Salary: {Salary}," +
                $"Department: {Department}}}";
        }
    }
}
