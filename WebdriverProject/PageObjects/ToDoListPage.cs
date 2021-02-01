using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using WebdriverProject.Helpers;
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
            WaitHelper.WaitUntilItemsListCountEqualNumber(5, _itemsList, 4);

            return _itemsList.Count;
        }
    }
}