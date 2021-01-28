using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WebdriverProject.WrapperFactory;

namespace WebdriverProject.PageObjects
{
    public class HomePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='login-portal']")]
        private IWebElement _loginPortalLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='page-object-model'][.//h1[contains(text(),'ACCORDION')]]")]
        private IWebElement _accordionLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='dropdown-checkboxes-radiobuttons']")]
        private IWebElement _dropdownCheckboxesRadiobuttonsLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='ajax-loader']")]
        private IWebElement _ajaxLoaderLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='actions']")]
        private IWebElement _actionsLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='popup-alerts']")]
        private IWebElement _popupAlertsLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='iframe']")]
        private IWebElement _iFrameLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='file-upload']")]
        private IWebElement _fileUploadLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='to-do-list']")]
        private IWebElement _toDoListLink;

        public void ClickLoginPortalLink()
        {
            _loginPortalLink.Click();
            SwitchToLastWindow();
        }

        public void ClickAccordionLink()
        {
            _accordionLink.Click();
            SwitchToLastWindow();
        }

        public void ClickDropdownCheckboxesRadiobuttonsLink()
        {
            _dropdownCheckboxesRadiobuttonsLink.Click();
            SwitchToLastWindow();
        }

        public void ClickAjaxLoaderLink()
        {
            _ajaxLoaderLink.Click();
            SwitchToLastWindow();
        }

        public void ClickActionsLink()
        {
            _actionsLink.Click();
            SwitchToLastWindow();
        }

        public void ClickPopupAlertsLink()
        {
            _popupAlertsLink.Click();
            SwitchToLastWindow();
        }

        public void ClickIFrameLink()
        {
            _iFrameLink.Click();
            SwitchToLastWindow();
        }

        public void ClickFileUploadLink()
        {
            _fileUploadLink.Click();
            SwitchToLastWindow();
        }

        public void ClickToDoListLink()
        {
            _toDoListLink.Click();
            SwitchToLastWindow();
        }

        private static void SwitchToLastWindow()
        {
            WebDriverFactory.Driver.SwitchTo().Window(WebDriverFactory.Driver.WindowHandles[WebDriverFactory.Driver.WindowHandles.Count - 1]);
        }
    }
}