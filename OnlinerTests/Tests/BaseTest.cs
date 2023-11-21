using NUnit.Framework;
using OnlinerTests.PageObjects.Basic;
using OpenQA.Selenium;

namespace OnlinerTests.Tests
{
    class BaseTest
    {

        protected static IWebDriver driver = WebDriverProvider.Driver;

        protected object[] data;

        [SetUp]
        public void AhSHereWeGoAgain()
        {
            WebDriverProvider.Driver = null; // I have "setter" but not sure how to set it properly here.
        }

        [TearDown]
        public void YouHadToFollowTheDamnTrainCJ()
        {
            provider.Quit();
        }

        [OneTimeSetUp]
        public void ReadTheBook()
        {
            //no config book yet
        }
    }
}
