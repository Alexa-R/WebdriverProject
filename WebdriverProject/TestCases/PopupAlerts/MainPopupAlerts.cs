using NUnit.Framework;
using WebdriverProject.Helpers;
using WebdriverProject.PageObjects;

namespace WebdriverProject.TestCases.PopupAlerts
{
    [TestFixture]
    public class MainPopupAlerts : BaseTest
    {
        [Test]
        public void CheckConfirmAlertLabelText()
        {
            Pages.HomePage.ClickPopupAlertsLink();
            Pages.PopupAlertsPage.ClickJsAlertClickMeButton();
            AlertHelper.AcceptAlert();
            Pages.PopupAlertsPage.ClickModalPopupClickMeButton();
            Pages.PopupAlertsPage.ClickAlertPopupXCloseButton();
            Pages.PopupAlertsPage.ClickJsConfirmBoxClickMeButton();
            AlertHelper.AcceptAlert();
            Pages.PopupAlertsPage.ClickJsConfirmBoxClickMeButton();
            AlertHelper.CancelAlert();
            Assert.AreEqual("You pressed Cancel!", Pages.PopupAlertsPage.GetConfirmAlertLabelText());
        }
    }
}