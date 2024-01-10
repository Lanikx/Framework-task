using NUnit.Framework;
using OnlinerTests.PageObjects.Basic;
using OpenQA.Selenium;

namespace OnlinerTests.Tests
{
    public class BaseTest
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            WebDriverProvider.Start();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            WebDriverProvider.Quit();
        }
    }
}
