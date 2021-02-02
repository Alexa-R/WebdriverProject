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
            Pages.DropdownCheckboxesRadioButtonsPage.ClickDropdownMenuElement((int)DropdownMenusEnum.Languages, (int)LanguagesDropdownEnum.CSharp);
            Pages.DropdownCheckboxesRadioButtonsPage.ClickDropdownMenuElement((int)DropdownMenusEnum.Frameworks, (int)FrameworksDropdownEnum.Maven);
            Pages.DropdownCheckboxesRadioButtonsPage.ClickDropdownMenuElement((int)DropdownMenusEnum.Web, (int)WebDropdownEnum.Css);
            Pages.DropdownCheckboxesRadioButtonsPage.ClickOptionFromOptionsCheckboxesList((int)OptionsCheckboxesEnum.Option1);
            Pages.DropdownCheckboxesRadioButtonsPage.ClickOptionFromOptionsCheckboxesList((int)OptionsCheckboxesEnum.Option3);
            Pages.DropdownCheckboxesRadioButtonsPage.SelectYellowFromColorsRadioButtonsList();
            Assert.IsTrue(Pages.DropdownCheckboxesRadioButtonsPage.IsCabbageFromPlantsRadioButtonsListDisabled());
            
            Assert.IsTrue(Pages.DropdownCheckboxesRadioButtonsPage.IsOrangeFromFruitsDropdownListDisabled());

            Pages.DropdownCheckboxesRadioButtonsPage.SelectAppleFromFruitsDropdownList();
        }
    }
}