using OpenQA.Selenium;
using WebElement = OnlinerTests.PageObjects.Basic.WebElement;

namespace OnlinerTests.PageObjects
{
    public class ItemPage : BasePage
    {
        private WebElement _itemTitleHeader => new WebElement(By.XPath("//h1[@class = 'catalog-masthead__title js-nav-header']"));

        private WebElement _firstAddToBasket => new WebElement(By.XPath("//div[contains(@class,'offers-list__control offers-list__control_default helpers_hide_tablet')]/a[contains(text(),'В корзину')]"));

        private WebElement _goToBasketButton => new WebElement(By.XPath("//div[@class='product-recommended__sidebar-overflow']//a[contains(text(),'Перейти в корзину')]"));

        public override bool IsOnPage()
        {
            return _itemTitleHeader.Displayed;
        }

        public void ClickFirstAddToBasket()
        {
            _firstAddToBasket.Click();
        }

        public void ClickGoToBasket()
        {
            _goToBasketButton.Click();
        }
    }
}
