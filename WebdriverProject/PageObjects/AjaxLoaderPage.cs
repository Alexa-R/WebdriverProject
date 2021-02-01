using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WebdriverProject.Helpers;

namespace WebdriverProject.PageObjects
{
    public class AjaxLoaderPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='loader']")]
        private IWebElement _loaderBar;

        [FindsBy(How = How.XPath, Using = "//*[@id='button1']")]
        private IWebElement _greenClickMeButton;

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-title']")]
        private IWebElement _alertPopupTitle;

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-header']//*[@class='close']")]
        private IWebElement _alertPopupXCloseButton;

        public void WaitLoaderBarDisappear()
        {
            WaitHelper.WaitUntilElementDisappear(10, _loaderBar);
        }

        public void ClickGreenClickMeButton()
        {
            _greenClickMeButton.Click();
        }

        public string GetAlertPopupHeaderText()
        {
            WaitHelper.WaitUntilElementDisplayed(5, _alertPopupTitle);
            
            return _alertPopupTitle.Text;
        }

        public void ClickAlertPopupXCloseButton()
        {
            _alertPopupXCloseButton.Click();
        }
    }
}