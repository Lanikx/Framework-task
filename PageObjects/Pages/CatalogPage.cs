using OnlinerTests.PageObjects.Basic;
using OpenQA.Selenium;
using System.Text.RegularExpressions;
using WebElement = OnlinerTests.PageObjects.Basic.WebElement;

namespace OnlinerTests.PageObjects
{
    public class CatalogPage : BasePage
    {
        private const string ManufacturerSelectOptionXpath = "//div[@class='catalog-form__line catalog-form__line_condensed-other']/ul//div[contains(text(),'{0}')]";

        private const string SortByOptionXpath = "//option[contains(text(),'{0}')]";

        private readonly By ItemsPriceElementXpath = By.XPath("//a[@class='schema-product__price-value schema-product__price-value_primary js-product-price-link']");
        
        private WebElement CatalogPageHeader => new WebElement(By.XPath("//h1[@class='catalog-form__title catalog-form__title_big-alter']"));

        private WebElement SortingOptionElement => new WebElement(By.XPath("//div[contains(text(),'Сначала популярные')]/following-sibling::select"));

        private WebElement FirstItemProposesElement => new WebElement(By.XPath("//div/a[contains(text(), 'предлож')]"));

        private WebElement ItemNameElement => new WebElement(By.XPath("//div[contains(@class,'catalog-form__description_base-additional')]/a"));


        public void ClickOnSortingOption()
        {
            SortingOptionElement.ClickViaJS();
        }

        public void SelectManufacturer(string manufacturerName)
        {
            var manufacturerSelectOption = new WebElement(By.XPath(string.Format(ManufacturerSelectOptionXpath, manufacturerName)));
            manufacturerSelectOption.ClickViaActions();
        }

        public void SelectSortingBy(string option)
        {
            var sortByOption = new WebElement(By.XPath(string.Format(SortByOptionXpath, option)));
            sortByOption.WaitIsVisible();
            sortByOption.ClickViaJS();
        }

        public void ScrollManufacturersOptionIntoView(string manufacturerName)
        {
            var manufacturerSelectOption = new WebElement(By.XPath(string.Format(ManufacturerSelectOptionXpath, manufacturerName)));
            manufacturerSelectOption.ScrollToElement();
        }

        public override bool IsOnPage()
        {
            return CatalogPageHeader.IsDisplayed();
        }

        public IEnumerable<double> GetItemsPrices()
        {
            Regex regex = new Regex("[0-9]+,[0-9]+", RegexOptions.IgnoreCase);
            var priceElements = _currentDriver.FindWebElements(ItemsPriceElementXpath);
            var itemsPrices = from priceElement in priceElements select double.Parse(regex.Match(priceElement.GetText()).Value);
            return itemsPrices;
        }

        public string GetFirstItemName()
        {
            return ItemNameElement.GetText();
        }

        public void ClickFirstItemProposesButton()
        {
            FirstItemProposesElement.Click();
        }
    }
}