using NUnit.Framework;
using OnlinerTests.PageObjects;
using OnlinerTests.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinerTests.Selenium_tests.Tests
{
    internal class MainPageTests : BaseTest
    {

        [TestCase]
        public void IsAtMainPage()
        {
            MainPage mainPage = new MainPage(provider.driver);
            Assert.IsTrue(mainPage.IsOnPage("https://www.onliner.by/"));
            Assert.IsTrue(mainPage.IsLogoPresent());

        }
    }
}
