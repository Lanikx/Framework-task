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
            var isOnMainPage = mainPage.IsOnPage();
            mainPage.CloseCookiePrompt();
            Assert.IsTrue(isOnMainPage, "User is not on main page");
            mainPage.ClickElectronicsSection();
            mainPage.ClickPhonesAndAccessoriesSubsection();
            mainPage.ClickSmartphonesSubSubSection();
            var catalogPage = new CatalogPage();
            var isOnCatalogPage = catalogPage.IsOnPage();
            Assert.IsTrue(isOnCatalogPage, "User is not on catalog page");
            catalogPage.ScrollManufacturersOptionIntoView("Xiaomi");
            catalogPage.SelectManufacturer("Xiaomi");
            catalogPage.ClickOnSortingOption();
            catalogPage.SelectSortingBy("Дорогие");
            var priceCollection = catalogPage.GetItemsPrices();
            CollectionAssert.IsOrdered(priceCollection.Reverse(), "Price collection isn't ordered or empty");
        }

        [TestCase]
        public void AddItemToBasketTest()
        {
            var mainPage = new MainPage();
            var isOnMainPage = mainPage.IsOnPage();
            mainPage.CloseCookiePrompt();
            Assert.IsTrue(isOnMainPage, "User is not on main page");
            mainPage.ClickElectronicsSection();
            mainPage.ClickVideoGamesSubSection();
            mainPage.ClickGameConsolesSubSubSection();
            var catalogPage = new CatalogPage();
            var isOnCatalogPage = catalogPage.IsOnPage();
            Assert.IsTrue(isOnCatalogPage, "User is not on catalog page");
            var itemCatalogName = catalogPage.GetFirstItemName();
            catalogPage.ClickFirstItemProposesButton();
            var itemPage = new ItemPage();
            var isOnItemPage = itemPage.IsOnPage();
            Assert.IsTrue(isOnItemPage, "User is not on item page");
            itemPage.ClickFirstAddToBasket();
            itemPage.ClickGoToBasket();
            var cartPage = new CartPage();
            var isOnCartPage = cartPage.IsOnPage();
            Assert.IsTrue(isOnCartPage, "User is not on cart page");
            var cartItemName = cartPage.GetFirstItemName();
            Assert.That(cartItemName, Is.EqualTo(itemCatalogName));
        }
    }
}
