using NUnit.Framework;
using OnlinerTests.PageObjects.Basic;
using OpenQA.Selenium;

namespace OnlinerTests.Tests
{
    public class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            WebDriverProvider.Start();
        }

        [TearDown]
        public void TearDown()
        {
            WebDriverProvider.Quit();
        }
    }
}
