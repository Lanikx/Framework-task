using NUnit.Framework;
using OnlinerTests.PageObjects;

namespace OnlinerTests.Tests
{
    internal class CatalogPageTests : BaseTest
    {
        [TestCase]
        public void SortByPriceTest()
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

        [TestCase]
        public void AddItemToBasketTest()
        {
            MainPage mainPage = new MainPage();
            mainPage.ClickElectronicsSection();
            mainPage.ClickVideoGamesSubSection();
            mainPage.ClickGameConsolesSubSubSection();
            CatalogPage catalogPage = new CatalogPage();
            string itemCatalogName = catalogPage.GetFirstItemName();
            catalogPage.ClickFirstItemProposesButton();
            ItemPage itemPage = new ItemPage();
            itemPage.ClickFirstAddToBasket();
            itemPage.ClickGoToBasket();
            CartPage cartPage = new CartPage();
            cartPage.IsOnPage();
            string cartItemName = cartPage.GetFirstItemName();
            Assert.That(cartItemName, Is.EqualTo(itemCatalogName));
        }
    }
}
