using NUnit.Framework;
using OnlinerTests.PageObjects.Basic;

namespace OnlinerTests.Tests
{
    class BaseTest
    {

        protected WebDriverProvider provider = new WebDriverProvider();

        protected object[] data;

        [SetUp]
        public void AhShitHereWeGoAgain()
        {
            provider.Start();
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
