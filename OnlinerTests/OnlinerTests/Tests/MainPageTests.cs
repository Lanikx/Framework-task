using NUnit.Framework;
using OnlinerTests.PageObjects;

namespace OnlinerTests.Tests
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
