using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WebdriverProject.WrapperFactory;

namespace WebdriverProject.PageObjects
{
    public class FramePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@class='thumbnail'][.//p[text()='Who Are We?']]//*[@class='caption']/p")]
        private IWebElement _whoAreWeDescription;

        [FindsBy(How = How.XPath, Using = "//*[@id='frame']")]
        private IWebElement _pageObjectModelFrame;

        [FindsBy(How = How.XPath, Using = "//*[@id='nav-title']")]
        private IWebElement _iFrameNavBarTitle;
        
        public string GetWhoAreWeDescriptionText()
        {
            WebDriverFactory.Driver.SwitchTo().Frame(_pageObjectModelFrame);
            var whoAreWeDescriptionText = _whoAreWeDescription.Text;
            WebDriverFactory.Driver.SwitchTo().DefaultContent();

            return whoAreWeDescriptionText;
        }

        public void ClickIFrameNavBarTitle()
        {
            _iFrameNavBarTitle.Click();
        }
    }
}