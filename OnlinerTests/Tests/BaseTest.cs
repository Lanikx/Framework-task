using NUnit.Framework;
using OnlinerTests.PageObjects.Basic;
using OpenQA.Selenium;
using PageObjects.Config;

namespace OnlinerTests.Tests
{
    public class BaseTest
    {
        protected TestDataConfig config = new TestDataConfig();

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {           
            WebDriverProvider.Start();            
        }

        [SetUp]
        public void SetUp() 
        {
            WebDriverProvider.Driver.Navigate().GoToUrl("https://catalog.onliner.by/");
        }

        [TearDown]
        public void TearDown()
        {
            Screenshot ss = ((ITakesScreenshot)WebDriverProvider.Driver).GetScreenshot();
            var testName = TestContext.CurrentContext.Test.Name;
            string Runname = testName + " " + DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss");
            string screenshotfilename = "D:\\screenshots\\" + Runname + ".jpg";
            ss.SaveAsFile(screenshotfilename, ScreenshotImageFormat.Jpeg);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            WebDriverProvider.Quit();
        }
    }
}
