using System.Configuration;
using NUnit.Framework;
using WebdriverProject.WrapperFactory;

namespace WebdriverProject.TestCases
{
    [TestFixture]
    public class BaseTest
    {
        [SetUp]
        public void SetUpTest()
        {
            WebDriverFactory.InitBrowser("Chrome");
            WebDriverFactory.GoToUrl(ConfigurationManager.AppSettings["URL"]);
            WebDriverFactory.Driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void OneTimeTearDownTest()
        {
            WebDriverFactory.CloseAllDrivers();
        }
    }
}
