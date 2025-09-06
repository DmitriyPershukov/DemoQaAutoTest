using OpenQA.Selenium;
using task3.framework.element_utils;
using task3.framework.page;
using task3.test.elements;
using task3.Test.TestDataModels;

namespace task3.test.pages
{
    public class UserRegistrationForm : BaseForm
    {
        private const string name = "User Registration Form";

        private InputField firstNameField;
        private InputField lastNameField;
        private InputField emailField;
        private InputField ageField;
        private InputField salaryField;
        private InputField departmentField;
        private Button submitButton;
        
        public UserRegistrationForm() : base(
            new BareElement(By.Id("userForm"), "UserREgistrationForm identifying element"), name)
        {
            firstNameField = new InputField(By.Id("firstName"), "FirstName input field");
            lastNameField = new InputField(By.Id("lastName"), "LastName input field");
            emailField = new InputField(By.Id("userEmail"), "Email input field");
            ageField = new InputField(By.Id("age"), "Age input field");
            salaryField = new InputField(By.Id("salary"), "Salary input field");
            departmentField = new InputField(By.Id("department"), "Department input field");
            submitButton = new Button(By.Id("submit"), "Submit");
        }

        public void EnterUserData(User user)
        {
            firstNameField.SendKeys(user.FirstName);
            lastNameField.SendKeys(user.LastName);
            emailField.SendKeys(user.Email);
            ageField.SendKeys(user.Age.ToString());
            salaryField.SendKeys(user.Salary.ToString());
            departmentField.SendKeys(user.Department);
        }

        public void Submit()
        {
            submitButton.Click();
        }
    }
}
