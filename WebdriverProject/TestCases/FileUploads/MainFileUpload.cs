using NUnit.Framework;
using WebdriverProject.Helpers;
using WebdriverProject.PageObjects;

namespace WebdriverProject.TestCases.FileUploads
{
    [TestFixture]
    public class MainFileUpload : BaseTest
    {
        [Test]
        public void CheckExpandedAccordionText()
        {
            Pages.HomePage.ClickFileUploadLink();
            Pages.FileUploadPage.UploadFile("C:/Users/Alexa/source/repos/WebdriverProject/WebdriverProject/Resources/WebDriverTask.docx");
            Pages.FileUploadPage.ClickUploadSubmitButton();

            Assert.True(AlertHelper.IsAlertDisplayed());
        }
    }
}