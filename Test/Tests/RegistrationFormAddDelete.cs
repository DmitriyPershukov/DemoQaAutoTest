using NUnit.Framework;
using task3.framework.test;
using task3.Framework.DataManagers;
using task3.test.pages;
using task3.Test.Models;
using task3.Test.TestDataModels;

namespace task3.Test.Tests
{
    [TestFixture]
    public class RegistrationFormAddDelete : BaseTest
    {
        MainPage mainPage;
        PlaygroundPage playgroundPage;
        WebTablesForm webTables;
        UserRegistrationForm userRegistrationForm;
        static RegistrationFormAddDeleteTestData testData =
            TestDataManager.GetTestDataModel<RegistrationFormAddDeleteTestData>();

        [SetUp]
        public void Setup()
        {
            mainPage = new MainPage();
            playgroundPage = new PlaygroundPage();
            webTables = new WebTablesForm();
            userRegistrationForm = new UserRegistrationForm();
        }

        public static IEnumerable<User> TestCases()
        {
            foreach (var user in testData.Users)
            {
                yield return user;
            }
        }

        [TestCaseSource(nameof(TestCases))]
        public void RegistrationFormAddDeleteTest(User user)
        {
            GoToMainPageUrl();
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
            userRegistrationForm.ClickSubmitButton();
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
