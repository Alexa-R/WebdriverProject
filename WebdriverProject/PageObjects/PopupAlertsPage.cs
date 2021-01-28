using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using WebdriverProject.WrapperFactory;

namespace WebdriverProject.PageObjects
{
    public class PopupAlertsPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='button1']")]
        private IWebElement _jSAlertClickMeButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='button2']")]
        private IWebElement _modalPopupClickMeButton;

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-header']//*[@class='close']")]
        private IWebElement _alertPopupXCloseButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='button4']")]
        private IWebElement _jSConfirmBoxClickMeButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='confirm-alert-text']")]
        private IWebElement _confirmAlertLabel;

        public void ClickJsAlertClickMeButton()
        {
            _jSAlertClickMeButton.Click();
        }
        
        public void ClickModalPopupClickMeButton()
        {
            _modalPopupClickMeButton.Click();
        }

        public void ClickAlertPopupXCloseButton()
        {
            var wait = new WebDriverWait(WebDriverFactory.Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(_alertPopupXCloseButton));

            _alertPopupXCloseButton.Click();
        }

        public void ClickJsConfirmBoxClickMeButton()
        {
            _jSConfirmBoxClickMeButton.Click();
        }

        public string GetConfirmAlertLabelText()
        {
            return _confirmAlertLabel.Text;
        }
    }
}