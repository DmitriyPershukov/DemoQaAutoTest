using NUnit.Framework;
using task3.framework.config_utils;
using task3.framework.test;
using task3.framework.web_driver;
using task3.test.pages;

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
            mainPage = new MainPage();
            playgroundPage = new PlaygroundPage();
            webTables = new WebTablesForm();
            userRegistrationForm = new UserRegistrationForm();
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

            webTables.RefreshRowCount();
            webTables.DeleteUser(user);
            Assert.That(webTables.RowCountChanged(), 
                $"Delete button was pressed in user {user} row but row count was not changed.");
            usersInTable = webTables.GetUsers();
            Assert.That(!usersInTable.Contains(user),
                $"Delete button was pressed in user {user} row but user is still in the table.");
        }
    }
}
