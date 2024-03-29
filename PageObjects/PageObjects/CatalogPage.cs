﻿using OpenQA.Selenium;
using System.Diagnostics;
using System.Text.RegularExpressions;
using WebElement = OnlinerTests.PageObjects.Basic.WebElement;

namespace OnlinerTests.PageObjects
{
    public class CatalogPage : BasePage
    {
        public CatalogPage() : base() { }

        private string _manufacturerSelectOptionXpath = "//div[@class='schema-filter__facet']/ul//span[contains(text(),'{0}')]";

        private string _sortByOption = "//div[contains(@class,'schema-order__item')]/span[contains(text(),'{0}')]";

        private WebElement CellphoneHeader => new WebElement(By.XPath("//h1[contains(text(),'Мобильные телефоны')]"));

        private WebElement SortingOption => new WebElement(By.XPath("//a[@class='schema-order__link']"));

        private WebElement FirstItemProposes => new WebElement(By.XPath("//div/a[contains(text(), 'предлож')]"));

        private WebElement ItemName => new WebElement(By.XPath("//span[@data-bind='html: product.extended_name || product.full_name']"));

        private WebElement ItemsPrice => new WebElement(By.XPath("//a[@class='schema-product__price-value schema-product__price-value_primary js-product-price-link']"));

        public void ClickOnSortingOption()
        {
            SortingOption.Click();
        }

        public void SelectManufacturer(string manufacturerName)
        {
            var manufacturerSelectOption = new WebElement(By.XPath(string.Format(_manufacturerSelectOptionXpath, manufacturerName)));
            manufacturerSelectOption.Click();
        }

        public void SelectSortingBy(string option)
        {
            var sortByOption = new WebElement(By.XPath(string.Format(_sortByOption, option)));
            sortByOption.WaitIsDisplayed();
            sortByOption.Click();
        }

        public void ScrollManufacturersOptionIntoView(string manufacturerName)
        {
            var manufacturerSelectOption = new WebElement(By.XPath(string.Format(_manufacturerSelectOptionXpath, manufacturerName)));
            manufacturerSelectOption.ScrollToElement();
        }

        public override bool IsOnPage()
        {
            return CellphoneHeader.Displayed;
        }

        public IEnumerable<double> GetItemsPrices()
        {
            Regex regex = new Regex("[0-9]+,[0-9]+", RegexOptions.IgnoreCase);
            var priceElements = ItemsPrice.GetElements();
            var itemsPrices = from price in ItemsPrice.GetElements() select double.Parse(regex.Match(price.Text).Value);
            return itemsPrices;
        }

        public string GetFirstItemName()
        {
            return ItemName.GetText();
        }

        public void ClickFirstItemProposesButton()
        {
            FirstItemProposes.Click();
        }
    }
}
