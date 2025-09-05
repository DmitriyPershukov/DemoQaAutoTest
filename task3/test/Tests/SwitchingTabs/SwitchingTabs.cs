using NUnit.Framework;
using task3.framework.test;
using task3.framework.web_driver;
using task3.Framework.Utils.BrowserUtils;
using task3.test.pages;

namespace task3.test.tests.switching_tabs
{
    public class SwitchingTabs : BaseTest
    {
        MainPage mainPage;
        PlaygroundPage playgroundPage;
        BrowserWindowsForm browserWindowsForm;
        SamplePage samplePage;
        LinksForm linksForm;

        [SetUp]
        public void Setup()
        {
            mainPage = new MainPage();
            playgroundPage = new PlaygroundPage();
            browserWindowsForm = new BrowserWindowsForm();
            samplePage = new SamplePage();
            linksForm = new LinksForm();
        }

        [TearDown]
        public void Teardown()
        {}

        [Test]
        public void SwitchingTabsTest()
        {
            WebDriverProvider.GetInstance().Navigate().GoToUrl(globalTestData.MainPageURL);
            Assert.That(mainPage.IsOpened(), "After navigating to main page it was not opened.");

            mainPage.ClickAlertsWindowsButton();
            playgroundPage.ClickAccordionMenuElement("Alerts", "Browser Windows");
            Assert.That(playgroundPage.IsOpened() && browserWindowsForm.IsOpened(),
                "Alerts, Frame & Windows button was clicked and button 'Browser Windows' was clicked in left menu " +
                "but Browser Windows form was not opened.");

            browserWindowsForm.ClickNewTabButton();
            WindowsUtils.SwitchToNewWindow();
            Assert.That(WindowsUtils.GetWindowCount() == 2,
                "New tab buttons was clicked but new tab was not opened.");
            Assert.That(samplePage.IsOpened(), 
                "New tab buttons was clicked but sample page did not open");

            WindowsUtils.CloseCurrentWindow();
            WindowsUtils.SwitchToPreviousWindow();
            Assert.That(WindowsUtils.GetWindowCount() == 1,
                "Tab close was pressed but tab did not close.");
            Assert.That(browserWindowsForm.IsOpened(), 
                "Tab was closed but browser windows form was not opened");

            playgroundPage.ClickDropDownMenuHeader("Elements");
            playgroundPage.ClickAccordionMenuElement("Elements", "Links");
            Assert.That(linksForm.IsOpened(), 
                "Links button in left side menu was clicked but links form did not open.");

            linksForm.ClickHomeLink();
            WindowsUtils.SwitchToNewWindow();
            Assert.That(WindowsUtils.GetWindowCount() == 2,
                "Home link was clicked but new tab was not opened.");
            mainPage.WaitToLoad(TimeSpan.FromSeconds(2));
            Assert.That(mainPage.IsOpened(),
                "Home link was clicked but main page was not opened.");

            WindowsUtils.SwitchToPreviousWindow();
            Assert.That(linksForm.IsOpened(), 
                "Switched to a previous tab but links form was not opened.");
        }
    }
}
