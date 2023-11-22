using NUnit.Framework;
using OnlinerTests.PageObjects;
using OnlinerTests.PageObjects.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinerTests.Tests
{
    internal class MainPageTests : BaseTest
    {

        [TestCase]
        public void IsAtMainPage()
        {
            MainPage mainPage = new MainPage();

            Assert.IsTrue(mainPage.IsLogoPresent(), "Logo is not present");
        }
    }
}
