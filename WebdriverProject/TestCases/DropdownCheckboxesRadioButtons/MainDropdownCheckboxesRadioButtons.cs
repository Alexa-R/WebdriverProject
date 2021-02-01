using NUnit.Framework;
using WebdriverProject.Enums;
using WebdriverProject.PageObjects;

namespace WebdriverProject.TestCases.DropdownCheckboxesRadioButtons
{
    [TestFixture]
    public class MainDropdownCheckboxesRadioButtons : BaseTest
    {
        [Test]
        public void CheckCabbageRadioButtonAndOrangeOptionAreDisabled()
        {
            Pages.HomePage.ClickDropdownCheckboxesRadiobuttonsLink();
            Pages.DropdownCheckboxesRadioButtonsPage.SelectCSharpFromLanguageDropdownList();
            Pages.DropdownCheckboxesRadioButtonsPage.SelectMavenFromFrameworksDropdownList();
            Pages.DropdownCheckboxesRadioButtonsPage.SelectCssFromWebDropdownList();
            Pages.DropdownCheckboxesRadioButtonsPage.ClickOptionFromOptionsCheckboxesList((int)OptionsCheckboxesEnum.Option1);
            Pages.DropdownCheckboxesRadioButtonsPage.ClickOptionFromOptionsCheckboxesList((int)OptionsCheckboxesEnum.Option3);
            Pages.DropdownCheckboxesRadioButtonsPage.SelectYellowFromColorsRadioButtonsList();
            Assert.IsTrue(Pages.DropdownCheckboxesRadioButtonsPage.IsCabbageFromPlantsRadioButtonsListDisabled());
            
            Assert.IsTrue(Pages.DropdownCheckboxesRadioButtonsPage.IsOrangeFromFruitsDropdownListDisabled());

            Pages.DropdownCheckboxesRadioButtonsPage.SelectAppleFromFruitsDropdownList();
        }
    }
}