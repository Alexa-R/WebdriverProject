using NUnit.Framework;
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
            Pages.DropdownCheckboxesRadioButtonsPage.ClickOption1FromOptionsCheckboxesList();
            Pages.DropdownCheckboxesRadioButtonsPage.ClickOption3FromOptionsCheckboxesList();
            Pages.DropdownCheckboxesRadioButtonsPage.SelectYellowFromColorsRadioButtonsList();
            Assert.IsTrue(Pages.DropdownCheckboxesRadioButtonsPage.IsCabbageFromPlantsRadioButtonsListDisabled());
            
            Assert.IsTrue(Pages.DropdownCheckboxesRadioButtonsPage.IsOrangeFromFruitsDropdownListDisabled());

            Pages.DropdownCheckboxesRadioButtonsPage.SelectAppleFromFruitsDropdownList();
        }
    }
}