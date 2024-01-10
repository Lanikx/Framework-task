using NUnit.Framework;
using OnlinerTests.PageObjects;

namespace OnlinerTests.Tests
{
    public class CatalogPageTests : BaseTest
    {
        [TestCase]
        public void SortByPriceTest()
        {
            var mainPage = new MainPage();
            Assert.IsTrue(mainPage.IsOnPage(), "User is not on main page");
            mainPage.ClickElectronicsSection();
            mainPage.ClickPhonesAndAccessoriesSubsection();
            mainPage.ClickSmartphonesSubSubSection();
            var catalogPage = new CatalogPage();
            Assert.IsTrue(catalogPage.IsOnPage(), "User is not on catalog page");
            catalogPage.ScrollManufacturersOptionIntoView("Xiaomi");
            catalogPage.SelectManufacturer("Xiaomi");
            catalogPage.ClickOnSortingOption();
            catalogPage.SelectSortingBy("Дорогие");
            var priceCollection = catalogPage.GetItemsPrices();
            CollectionAssert.IsOrdered(priceCollection.Reverse());
        }

        [TestCase]
        public void AddItemToBasketTest()
        {
            var mainPage = new MainPage();
            mainPage.ClickElectronicsSection();
            mainPage.ClickVideoGamesSubSection();
            mainPage.ClickGameConsolesSubSubSection();
            var catalogPage = new CatalogPage();
            var itemCatalogName = catalogPage.GetFirstItemName();
            catalogPage.ClickFirstItemProposesButton();
            var itemPage = new ItemPage();
            itemPage.ClickFirstAddToBasket();
            itemPage.ClickGoToBasket();
            var cartPage = new CartPage();
            cartPage.IsOnPage();
            var cartItemName = cartPage.GetFirstItemName();
            Assert.That(cartItemName, Is.EqualTo(itemCatalogName));
        }
    }
}
