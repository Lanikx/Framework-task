using OpenQA.Selenium;
using WebElement = OnlinerTests.PageObjects.Basic.WebElement;

namespace OnlinerTests.PageObjects
{
    public class ItemPage : BasePage
    {
        private WebElement ItemTitleHeader => new WebElement(By.XPath("//h1[@class = 'catalog-masthead__title js-nav-header']"));

        private WebElement FirstAddToBasket => new WebElement(By.XPath("//div[contains(@class,'offers-list__control offers-list__control_default helpers_hide_tablet')]/a[contains(text(),'В корзину')]"));

        private WebElement GoToBasketButton => new WebElement(By.XPath("//div[@class='product-recommended__sidebar-overflow']//a[contains(text(),'Перейти в корзину')]"));

        public override bool IsOnPage()
        {
            return ItemTitleHeader.Displayed;
        }

        public void ClickFirstAddToBasket()
        {
            FirstAddToBasket.Click();
        }

        public void ClickGoToBasket()
        {
            GoToBasketButton.Click();
        }
    }
}