using NUnit.Framework;
using OnlinerTests.PageObjects;

namespace OnlinerTests.Tests
{
    internal class CatalogPageTests : BaseTest
    {
        [TestCase]
        public void SortByPrice()
        {
            MainPage mainPage = new MainPage();
            Assert.IsTrue(mainPage.IsOnPage(), "User is not on main page");
            mainPage.ClickElectronicsSection();
            mainPage.ClickPhonesAndAccessoriesSubsection();
            mainPage.ClickSmartphonesSubSubSection();
            CatalogPage catalogPage = new CatalogPage();
            Assert.IsTrue(catalogPage.IsOnPage(), "User is not on catalog page");
            catalogPage.ScrollManufacturersOptionIntoView("Xiaomi");
            catalogPage.SelectManufacturer("Xiaomi");
            catalogPage.ClickOnSortingOption();
            catalogPage.SelectSortingBy("Дорогие");
            var priceCollection = catalogPage.GetItemsPrices();
            CollectionAssert.IsOrdered(priceCollection.Reverse());
        }
    }
}
