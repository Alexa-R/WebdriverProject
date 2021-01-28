using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebdriverProject.PageObjects
{
    public class FileUploadPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='myFile']")]
        private IWebElement _uploadFileField;

        [FindsBy(How = How.XPath, Using = "//*[@id='submit-button']")]
        private IWebElement _uploadSubmitButton;

        public void UploadFile(string filePath)
        {
            _uploadFileField.SendKeys(filePath);
        }
        
        public void ClickUploadSubmitButton()
        {
            _uploadSubmitButton.Click();
        }
    }
}