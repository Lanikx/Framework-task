using NUnit.Framework;
using OnlinerTests.PageObjects;

namespace OnlinerTests.Tests
{
    public class MainPageTests : BaseTest
    {
        [TestCase]
        public void IsAtMainPage()
        {
            MainPage mainPage = new MainPage();
            var isLogoPresent = mainPage.IsLogoPresent();
            Assert.IsTrue(isLogoPresent, "Logo is not present, user is not on the page");
        }
    }
}
