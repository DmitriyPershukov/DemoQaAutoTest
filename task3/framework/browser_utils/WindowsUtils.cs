using task3.framework.testing_utils;
using task3.framework.web_driver;

namespace task3.framework.browser_utils
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
            LoggingManager.GetLogger().Debug($"current window handles: {GetWindowHandles()}");
            LoggingManager.GetLogger().Debug($"current window handle: {currentWindow}");
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
