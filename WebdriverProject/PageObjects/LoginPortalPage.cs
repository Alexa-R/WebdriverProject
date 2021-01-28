using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebdriverProject.PageObjects
{
    public class LoginPortalPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='text']")]
        private IWebElement _loginInputField;

        [FindsBy(How = How.XPath, Using = "//*[@id='password']")]
        private IWebElement _passwordInputField;

        [FindsBy(How = How.XPath, Using = "//*[@id='login-button']")]
        private IWebElement _loginButton;

        public void EnterLogin(string mail)
        {
            _loginInputField.SendKeys(mail);
        }

        public void EnterPassword(string password)
        {
            _passwordInputField.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            _loginButton.Click();
        }
    }
}