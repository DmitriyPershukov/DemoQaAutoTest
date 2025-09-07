using task3.framework.web_driver;
using task3.Framework.Logging;

namespace task3.Framework.Utils.BrowserUtils
{
    public class WindowsUtils
    {
        private static int currentWindow = 0;

        private static string[] GetWindowHandles()
        {
            return WebDriverProvider.GetInstance().WindowHandles.ToArray();
        }

        public static void SwitchToNewWindow()
        {
            LoggingManager.GetLogger().Info("Switching to a new window or tab.");
            currentWindow++;
            SwitchToCurrentWindow();
        }

        public static int GetWindowCount()
        {
            return GetWindowHandles().Length;
        }

        public static void SwitchToPreviousWindow()
        {
            LoggingManager.GetLogger().Info("Switching to a previous window or tab.");
            currentWindow--;
            SwitchToCurrentWindow();
        }

        private static void SwitchToCurrentWindow()
        {
            WebDriverProvider
                .GetInstance()
                .SwitchTo()
                .Window(GetWindowHandles()[currentWindow]);
        }

        public static void CloseCurrentWindow()
        {
            WebDriverProvider
                .GetInstance()
                .Close();
        }
    }
}
