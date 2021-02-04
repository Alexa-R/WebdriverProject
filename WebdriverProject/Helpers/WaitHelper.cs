using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebdriverProject.WrapperFactory;

namespace WebdriverProject.Helpers
{
    public static class WaitHelper
    {
        public static WebDriverWait CreateExplicitWait(double secondsValue)
        { 
            var wait = new WebDriverWait(WebDriverFactory.Driver, TimeSpan.FromSeconds(secondsValue));
            
            return wait;
        }

        public static void WaitUntilTextToBePresentInElement(double secondsValue, IWebElement element, string text)
        {
            CreateExplicitWait(secondsValue).Until(ExpectedConditions.TextToBePresentInElement(element, text));
        }

        public static void WaitUntilElementDisappear(double secondsValue, IWebElement element)
        {
            CreateExplicitWait(secondsValue).Until((d) => !element.Displayed);
        }

        public static void WaitUntilElementDisplayed(double secondsValue, IWebElement element)
        {
            CreateExplicitWait(secondsValue).Until((d) => element.Displayed);
        }
        
        public static void WaitUntilElementToBeClickable(double secondsValue, IWebElement element)
        {
            CreateExplicitWait(secondsValue).Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public static void WaitUntilItemsListCountEqualNumber(double secondsValue, IList<IWebElement> itemsList, int number)
        {
            CreateExplicitWait(secondsValue).Until((d) => itemsList.Count == number);
        }
    }
}