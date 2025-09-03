using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.config_utils;
using task3.framework.element_utils;
using task3.framework.page;
using task3.framework.test;
using task3.framework.testing_utils;
using task3.framework.web_driver;
using task3.test.pages;
using task3.test.tests.global_test_data;
using task3.test.tests.iframe_has_correct_text;

namespace task3.test.tests.registration_form_add_delete
{
    public class RegistrationFormAddDelete : BaseTest
    {
        MainPage mainPage;
        PlaygroundPage playgroundPage;
        WebTablesForm webTables;
        UserRegistrationForm userRegistrationForm;
        static RegistrationFormAddDeleteTestData testData = 
            TestDataManager.GetTestDataModel<RegistrationFormAddDeleteTestData>();

        [SetUp]
        public override void Setup()
        {
            base.Setup();
            mainPage = new MainPage("Main Page");
            playgroundPage = new PlaygroundPage("Playground Page");
            webTables = new WebTablesForm("Web Tables Page");
            userRegistrationForm = new UserRegistrationForm("User Registration Form");
        }

        [TearDown]
        public override void Teardown()
        {
            base.Teardown();
        }

        public static IEnumerable<User> TestCases()
        {
            foreach(var user in testData.Users){
                yield return user;
            }
        }

        [TestCaseSource(nameof(TestCases))]
        public void RegistrationFormAddDeleteTest(User user)
        {
            WebDriverProvider.GetInstance().Navigate().GoToUrl(globalTestData.MainPageURL);
            Assert.That(mainPage.IsOpened(), "After navigating to main page it was not opened.");

            mainPage.ClickElementsButton();
            playgroundPage.ClickAccordionMenuElement("Elements", "Web Tables");
            Assert.That(playgroundPage.IsOpened() && webTables.IsOpened(),
                "Alerts, Frame & Windows button was clicked and button 'Web Tables' was clicked in left menu " +
                "but Web Tables form was not opened.");

            webTables.ClickAddButton();
            Assert.That(userRegistrationForm.IsOpened(), 
                "Add button was clicked but user registration form was not opened.");

            userRegistrationForm.EnterUserData(user);
            userRegistrationForm.Submit();
            User[] usersInTable = webTables.GetUsers();
            Assert.That(usersInTable.Contains(user),
                "Registration form with user data was submitted but user does not appear in the table.");
        }
    }
}
