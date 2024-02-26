using Microsoft.Extensions.Logging;
using NUnit.Framework;
using OpenQA.Selenium;
using PageObjects.Config;
using PageObjects.Framework.WebDriver;
using PageObjects.Framework.WebDriverCreators;

namespace OnlinerTests.Tests
{
    public class BaseTest
    {
        protected TestDataConfig testDataConfig = new TestDataConfig();
        protected ILogger logger;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            DriverFactory.GetDriver();
            using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
            logger = factory.CreateLogger("Test run");
        }

        [SetUp]
        public void SetUp()
        {
            DriverFactory.GetDriver().Navigate().GoToUrl("https://catalog.onliner.by/");
            logger.LogInformation("Driver started");
            logger.LogInformation(TestContext.CurrentContext.Test.Name);
        }

        [TearDown]
        public void TearDown()
        {
            Screenshot ss = ((ITakesScreenshot)DriverFactory.GetDriver()).GetScreenshot();
            var testName = TestContext.CurrentContext.Test.Name;
            string Runname = testName + " " + DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss");
            string screenshotfilename = "D:\\screenshots\\" + Runname + ".jpg";
            ss.SaveAsFile(screenshotfilename);
            logger.LogInformation("Tear down completed");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            DriverFactory.GetDriver().Quit();
        }
    }
}
