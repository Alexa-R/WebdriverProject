using WebdriverProject.WrapperFactory;

namespace WebdriverProject.Helpers
{
    public static class AlertHelper
    {
        public static string GetAlertText()
        {
            var alertText = WebDriverFactory.Driver.SwitchTo().Alert().Text;

            return alertText;
        }

        public static void AcceptAlert()
        {
            WebDriverFactory.Driver.SwitchTo().Alert().Accept();
        }

        public static void CancelAlert()
        {
            WebDriverFactory.Driver.SwitchTo().Alert().Dismiss();
        }

        public static bool IsAlertDisplayed()
        {
            var alertText = WebDriverFactory.Driver.SwitchTo().Alert().Text;

            return alertText != null;
        }
    }
}