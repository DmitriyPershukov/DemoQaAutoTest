using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.element_utils;
using task3.framework.page;
using task3.test.elements;
using task3.test.tests.registration_form_add_delete;

namespace task3.test.pages
{
    public class UserRegistrationForm : BaseForm
    {
        private InputField firstNameField;
        private InputField lastNameField;
        private InputField emailField;
        private InputField ageField;
        private InputField salaryField;
        private InputField departmentField;
        private BaseButton submitButton;

        public UserRegistrationForm(string name) : base(
            new BareElement(By.Id("userForm"), "UserREgistrationForm identifying element"), name)
        {
            firstNameField = new InputField(By.Id("firstName"), "FirstName input field");
            lastNameField = new InputField(By.Id("lastName"), "LastName input field");
            emailField = new InputField(By.Id("userEmail"), "Email input field");
            ageField = new InputField(By.Id("age"), "Age input field");
            salaryField = new InputField(By.Id("salary"), "Salary input field");
            departmentField = new InputField(By.Id("department"), "Department input field");
            submitButton = new BaseButton(By.Id("submit"), "Submit");
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
