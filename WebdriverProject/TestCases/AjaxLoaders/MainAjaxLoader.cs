using NUnit.Framework;
using WebdriverProject.PageObjects;

namespace WebdriverProject.TestCases.AjaxLoaders
{
    [TestFixture]
    public class MainAjaxLoader : BaseTest
    {
        [Test]
        public void CheckAjaxLoaderHeaderText()
        {
            Pages.HomePage.ClickAjaxLoaderLink();
            Pages.AjaxLoaderPage.WaitLoaderBarDisappear();
            Pages.AjaxLoaderPage.ClickGreenClickMeButton();
            
            Assert.That(Pages.AjaxLoaderPage.GetAlertPopupHeaderText(), Contains.Substring("Well Done"));

            Pages.AjaxLoaderPage.ClickAlertPopupXCloseButton();
        }
    }
}