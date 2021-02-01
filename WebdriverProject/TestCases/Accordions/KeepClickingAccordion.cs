using NUnit.Framework;
using WebdriverProject.PageObjects;

namespace WebdriverProject.TestCases.Accordions
{
    [TestFixture]
    public class KeepClickingAccordion : BaseTest
    {
        [Test]
        public void CheckExpandedAccordionText()
        {
            Pages.HomePage.ClickAccordionLink();
            Pages.AccordionPage.WaitLoadingCompleteAppear();
            Pages.AccordionPage.ClickKeepClickingAccordion();
            Assert.AreEqual("This text has appeared after 5 seconds!", Pages.AccordionPage.GetExpandedKeepClickingAccordionText());

            Pages.AccordionPage.ClickKeepClickingAccordion();
        }
    }
}