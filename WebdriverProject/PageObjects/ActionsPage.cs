using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using WebdriverProject.WrapperFactory;

namespace WebdriverProject.PageObjects
{
    public class ActionsPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='draggable']")]
        private IWebElement _dragMeElement;

        [FindsBy(How = How.XPath, Using = "//*[@id='droppable']")]
        private IWebElement _dropHereElement;

        [FindsBy(How = How.XPath, Using = "//*[@id='double-click']")]
        private IWebElement _doubleClickMeElement;

        [FindsBy(How = How.XPath, Using = "//*[@class='dropdown'][.//button[contains(text(),'Second')]]")]
        private IWebElement _secondDropdownMenu;

        [FindsBy(How = How.XPath, Using = "//*[@class='dropdown'][.//button[contains(text(),'Second')]]//a[@class='list-alert']")]
        private IList<IWebElement> _secondDropdownList;

        [FindsBy(How = How.XPath, Using = "//*[@id='click-box']")]
        private IWebElement _clickAndHoldElement;

        private Actions _builder = new Actions(WebDriverFactory.Driver);

        public void DragAndDropDragMeElement()
        {
            _builder.DragAndDrop(_dragMeElement, _dropHereElement).Build().Perform();
        }

        public string GetDropHereElementText()
        {
            return _dropHereElement.Text;
        }

        public void DoubleClickDoubleClickMeElement()
        {
            _builder.DoubleClick(_doubleClickMeElement).Build().Perform();
        }

        public string GetDoubleClickMeElementColor()
        {
            return _doubleClickMeElement.GetCssValue("background-color");
        }

        public void HoverSecondDropdownMenu()
        {
            _builder.MoveToElement(_secondDropdownMenu).Build().Perform();
        }

        public void ClickLinkOneFromSecondDropdownList()
        {
            _secondDropdownList[0].Click();
        }

        public void ClickAndHoldClickAndHoldElement()
        {
            _builder.ClickAndHold(_clickAndHoldElement).Build().Perform();
        }

        public string GetClickAndHoldElementText()
        {
            return _clickAndHoldElement.Text;
        }
    }
}