using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using WebdriverProject.WrapperFactory;

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
            var wait = new WebDriverWait(WebDriverFactory.Driver, TimeSpan.FromSeconds(10));
            wait.Until((d) => !_loaderBar.Displayed);
        }

        public void ClickGreenClickMeButton()
        {
            _greenClickMeButton.Click();
        }

        public string GetAlertPopupHeaderText()
        {
            var wait = new WebDriverWait(WebDriverFactory.Driver, TimeSpan.FromSeconds(5));
            wait.Until((d) => _alertPopupTitle.Displayed);
            
            return _alertPopupTitle.Text;
        }

        public void ClickAlertPopupXCloseButton()
        {
            _alertPopupXCloseButton.Click();
        }
    }
}