using NUnit.Framework;
using WebdriverProject.Helpers;
using WebdriverProject.PageObjects;

namespace WebdriverProject.TestCases.Actions
{
    [TestFixture]
    public class MainActions : BaseTest
    {
        [Test]
        public void CheckElementIsDroppedChangedColorAlertTextAppearMessageAppear()
        {
            Pages.HomePage.ClickActionsLink();
            Pages.ActionsPage.DragAndDropDragMeElement();
            Assert.AreEqual("Dropped!", Pages.ActionsPage.GetDropHereElementText());

            var clickMeElementColor = Pages.ActionsPage.GetDoubleClickMeElementColor();
            Pages.ActionsPage.DoubleClickDoubleClickMeElement();
            var afterDoubleClickClickMeElementColor = Pages.ActionsPage.GetDoubleClickMeElementColor();
            Assert.AreNotEqual(clickMeElementColor, afterDoubleClickClickMeElementColor);

            Pages.ActionsPage.HoverSecondDropdownMenu();
            Pages.ActionsPage.ClickLinkOneFromSecondDropdownList();
            Assert.AreEqual("Well done you clicked on the link!", AlertHelper.GetAlertText());

            AlertHelper.AcceptAlert();
            Pages.ActionsPage.ClickAndHoldClickAndHoldElement();
            Assert.That(Pages.ActionsPage.GetClickAndHoldElementText(), Contains.Substring("Well done"));
        }
    }
}