using NUnit.Framework;
using OnlinerTests.PageObjects.Basic;
using OpenQA.Selenium;

namespace OnlinerTests.Tests
{
    class BaseTest
    {
        protected object[] data;

        [SetUp]
        public void AhSHereWeGoAgain()
        {
            WebDriverProvider.Start();
        }

        [TearDown]
        public void YouHadToFollowTheDamnTrainCJ()
        {
            WebDriverProvider.Quit();
        }

        [OneTimeSetUp]
        public void ReadTheBook()
        {
            //no config book yet
        }
    }
}
