using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebdriverProject.WrapperFactory;

namespace WebdriverProject.Helpers
{
    public static class WaitHelper
    {
        public static WebDriverWait CreateExplicitWait(double secondsNumber)
        { 
            var wait = new WebDriverWait(WebDriverFactory.Driver, TimeSpan.FromSeconds(secondsNumber));
            
            return wait;
        }

        public static void WaitUntilTextToBePresentInElement(double secondsNumber, IWebElement element, string text)
        {
            CreateExplicitWait(secondsNumber).Until(ExpectedConditions.TextToBePresentInElement(element, text));
        }

        public static void WaitUntilElementDisappear(double secondsNumber, IWebElement element)
        {
            CreateExplicitWait(secondsNumber).Until((d) => !element.Displayed);
        }

        public static void WaitUntilElementDisplayed(double secondsNumber, IWebElement element)
        {
            CreateExplicitWait(secondsNumber).Until((d) => element.Displayed);
        }
        
        public static void WaitUntilElementToBeClickable(double secondsNumber, IWebElement element)
        {
            CreateExplicitWait(secondsNumber).Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public static void WaitUntilItemsListCountEqualNumber(double secondsNumber, IList<IWebElement> itemsList, int number)
        {
            CreateExplicitWait(secondsNumber).Until((d) => itemsList.Count == number);
        }
    }
}