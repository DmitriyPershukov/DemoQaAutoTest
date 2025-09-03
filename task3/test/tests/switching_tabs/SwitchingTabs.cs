using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.framework.config_utils;
using task3.framework.test;
using task3.framework.web_driver;
using task3.test.pages;
using task3.test.tests.global_test_data;
using task3.test.tests.registration_form_add_delete;

namespace task3.test.tests.switching_tabs
{
    public class SwitchingTabs : BaseTest
    {
        MainPage mainPage;
        PlaygroundPage playgroundPage;
        BrowserWindowsForm browserWindowsForm;
        SamplePage samplePage;

        [SetUp]
        public override void Setup()
        {
            base.Setup();
            mainPage = new MainPage("Main Page");
            playgroundPage = new PlaygroundPage("Playground Page");
            browserWindowsForm = new BrowserWindowsForm("Browser Windows Form");
            samplePage = new SamplePage("Sample Page");
        }

        [TearDown]
        public override void Teardown()
        {
            base.Teardown();
        }

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
            Assert.That(samplePage.IsOpened(), 
                "New tab buttons was clicked but sample page did not open");
        }
    }
}
