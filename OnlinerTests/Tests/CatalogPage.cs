using NUnit.Framework;
using OnlinerTests.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinerTests.Tests
{
    internal class CatalogPage : BaseTest
    {
        [TestCase]
        public void SortByPrice()
        {
            MainPage mainPage = new MainPage(provider.driver);
            Assert.IsTrue(mainPage.IsOnPage("https://www.onliner.by/"));
            mainPage.ClickElectronicsSection();
            mainPage.ClickPhonesAndAccessoriesSubsection();
            mainPage.ClickSmartphonesSubSubSection();
            //div[@class='schema-product__group']
        }
    }
}
