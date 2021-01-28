using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using WebdriverProject.WrapperFactory;

namespace WebdriverProject.PageObjects
{
    public class AccordionPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='hidden-text']")]
        private IWebElement _loaderBar;

        [FindsBy(How = How.XPath, Using = "//*[@id='click-accordion']")]
        private IWebElement _keepClickingAccordion;

        [FindsBy(How = How.XPath, Using = "//*[@id='timeout']")]
        private IWebElement _expandedKeepClickingAccordion;

        public void WaitLoadingCompleteAppear()
        {
            var wait = new WebDriverWait(WebDriverFactory.Driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.TextToBePresentInElement(_loaderBar, "LOADING COMPLETE."));
        }

        public void ClickKeepClickingAccordion()
        {
            _keepClickingAccordion.Click();
        }

        public string GetExpandedKeepClickingAccordionText()
        {
            return _expandedKeepClickingAccordion.Text;
        }
    }
}