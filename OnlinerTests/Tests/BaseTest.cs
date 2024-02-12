using Microsoft.Extensions.Logging;
using NUnit.Framework;
using OnlinerTests.PageObjects.Basic;
using OpenQA.Selenium;
using PageObjects.Config;

namespace OnlinerTests.Tests
{
    public class BaseTest
    {
        protected TestDataConfig config = new TestDataConfig();
        protected ILogger logger;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {           
            WebDriverProvider.Start(); 
            using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
            logger = factory.CreateLogger("Test run");   
        }

        [SetUp]
        public void SetUp() 
        {
            WebDriverProvider.Driver.Navigate().GoToUrl("https://catalog.onliner.by/");
            logger.LogInformation("Driver started");
            logger.LogInformation(TestContext.CurrentContext.Test.Name);
        }

        [TearDown]
        public void TearDown()
        {
            Screenshot ss = ((ITakesScreenshot)WebDriverProvider.Driver).GetScreenshot();
            var testName = TestContext.CurrentContext.Test.Name;
            string Runname = testName + " " + DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss");
            string screenshotfilename = "D:\\screenshots\\" + Runname + ".jpg";
            ss.SaveAsFile(screenshotfilename, ScreenshotImageFormat.Jpeg);
            logger.LogInformation("Tear down completed");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            WebDriverProvider.Quit();
            
        }
    }
}
