using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using WebdriverProject.WrapperFactory;

namespace WebdriverProject.PageObjects
{
    public class ToDoListPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='container']//input[contains(@placeholder,'Add')]")]
        private IWebElement _addNewItemInputField;

        [FindsBy(How = How.XPath, Using = "//*[@id='container']//li")]
        private IList<IWebElement> _itemsList;

        [FindsBy(How = How.XPath, Using = "//*[@id='container']//li[last()]//*[@class='fa fa-trash']")]
        private IWebElement _lastItemTrash;

        public void AddNewItem(string item)
        {
            var builder = new Actions(WebDriverFactory.Driver);
            builder.SendKeys(_addNewItemInputField, item).SendKeys(Keys.Enter).Build().Perform();
        }

        public void RemoveLastItem()
        {
            _lastItemTrash.Click();
        }

        public int GetItemsListCount()
        {
            var wait = new WebDriverWait(WebDriverFactory.Driver, TimeSpan.FromSeconds(5));
            wait.Until((d) => _itemsList.Count == 4);

            return _itemsList.Count;
        }
    }
}