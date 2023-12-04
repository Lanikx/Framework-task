using OpenQA.Selenium;
using System.Diagnostics;
using System.Text.RegularExpressions;
using WebElement = OnlinerTests.PageObjects.Basic.WebElement;

namespace OnlinerTests.PageObjects
{
    public class CatalogPage : BasePage
    {
        public CatalogPage() : base()
        {

        }

        private WebElement _cellphoneHeader => new WebElement(By.XPath("//h1[contains(text(),'Мобильные телефоны')]"));

        private WebElement _sortingOption => new WebElement(By.XPath("//a[@class='schema-order__link']"));

        private string _manufacturerSelectOptionXpath = "//div[@class='schema-filter__facet']/ul//span[contains(text(),'{0}')]";

        private string _sortByOption = "//div[contains(@class,'schema-order__item')]/span[contains(text(),'{0}')]";

        private WebElement _itemsPrice => new WebElement(By.XPath("//a[@class='schema-product__price-value schema-product__price-value_primary js-product-price-link']"));

        public void ClickOnSortingOption()
        {
            _sortingOption.Click();
        }

        public void SelectManufacturer(string manufacturerName)
        {
            var manufacturerSelectOption = new WebElement(By.XPath(string.Format(_manufacturerSelectOptionXpath, manufacturerName)));
            manufacturerSelectOption.Click();
        }

        public void SelectSortingBy(string option)
        {
            var sortByOption = new WebElement(By.XPath(string.Format(_sortByOption, option)));
            sortByOption.Click();
        }

        public void ScrollManufacturersOptionIntoView(string manufacturerName)
        {
            var manufacturerSelectOption = new WebElement(By.XPath(string.Format(_manufacturerSelectOptionXpath, manufacturerName)));
            manufacturerSelectOption.ScrollToElement();
        }

        public override bool IsOnPage()
        {
            return _cellphoneHeader.Displayed;
        }

        public IEnumerable<double> GetItemsPrices()
        {
            Regex regex = new Regex("[0-9]+,[0-9]+", RegexOptions.IgnoreCase);
            return from price in _itemsPrice.GetElements() select double.Parse(regex.Match(price.Text).Value);
        }
    }
}
