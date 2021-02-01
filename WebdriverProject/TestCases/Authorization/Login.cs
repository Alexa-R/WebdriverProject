using System.Configuration;
using NUnit.Framework;
using WebdriverProject.Helpers;
using WebdriverProject.PageObjects;

namespace WebdriverProject.TestCases.Authorization
{
    [TestFixture]
    public class Login : BaseTest
    {
        [Test]
        public void CheckFailedLoginAlertText()
        {
            Pages.HomePage.ClickLoginPortalLink();
            Pages.LoginPortalPage.EnterLogin(ConfigurationManager.AppSettings["Login"]);
            Pages.LoginPortalPage.EnterPassword(ConfigurationManager.AppSettings["Password"]);
            Pages.LoginPortalPage.ClickLoginButton();
            Assert.AreEqual("validation failed", AlertHelper.GetAlertText());

            AlertHelper.AcceptAlert();
        }
    }
}
