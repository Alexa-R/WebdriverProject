using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WebdriverProject.WrapperElement;

namespace WebdriverProject.PageObjects
{
    public class DropdownCheckboxesRadioButtonsPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='checkboxes']/label[.//input[@type='checkbox']]")]
        private IList<IWebElement> _optionsCheckboxesList;

        [FindsBy(How = How.XPath, Using = "//*[@id='radio-buttons']/input")]
        private IList<IWebElement> _colorsRadioButtonsList;

        [FindsBy(How = How.XPath, Using = "//*[@id='radio-buttons-selected-disabled']/input")]
        private IList<IWebElement> _plantsRadioButtonsList;

        [FindsBy(How = How.XPath, Using = "//*[@id='fruit-selects']/option")]
        private IList<IWebElement> _fruitsDropdownList;

        public void ClickDropdownMenuElement(int dropdownMenuIndex, int elementIndex)
        {
            new WrapperWebElement(By.XPath($"//*[@id='dropdowm-menu-{dropdownMenuIndex}']/option[{elementIndex}]")).Click();
        }

        public void ClickOptionFromOptionsCheckboxesList(int optionIndex)
        {
            _optionsCheckboxesList[optionIndex].Click();
        }

        public void SelectYellowFromColorsRadioButtonsList()
        {
            _colorsRadioButtonsList[2].Click();
        }

        public bool IsCabbageFromPlantsRadioButtonsListDisabled()
        {
            return !_plantsRadioButtonsList[1].Enabled;
        }

        public bool IsOrangeFromFruitsDropdownListDisabled()
        {
            return !_fruitsDropdownList[1].Enabled;
        }

        public void SelectAppleFromFruitsDropdownList()
        {
            _fruitsDropdownList[0].Click();
        }
    }
}