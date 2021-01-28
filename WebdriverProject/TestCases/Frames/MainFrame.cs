using NUnit.Framework;
using WebdriverProject.PageObjects;

namespace WebdriverProject.TestCases.Frames
{
    [TestFixture]
    public class MainFrame : BaseTest
    {
        [Test]
        public void CheckWhoAreWeDescriptionText()
        {
            Pages.HomePage.ClickIFrameLink();

            Assert.That(Pages.FramePage.GetWhoAreWeDescriptionText(), Contains.Substring("Lorem ipsum"));

            Pages.FramePage.ClickIFrameNavBarTitle();
        }
    }
}