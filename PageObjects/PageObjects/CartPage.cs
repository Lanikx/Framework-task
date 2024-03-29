﻿using OpenQA.Selenium;
using WebElement = OnlinerTests.PageObjects.Basic.WebElement;

namespace OnlinerTests.PageObjects
{
    public class CartPage : BasePage
    {
        private WebElement CartTitle => new WebElement(By.XPath("//div[contains(text(),'Корзина')]"));

        private WebElement FirstItemName => new WebElement(By.XPath("//div[@class='cart-form__description cart-form__description_primary cart-form__description_base-alter cart-form__description_font-weight_semibold cart-form__description_condensed-specific']/a"));

        public override bool IsOnPage()
        {
            return CartTitle.Displayed;
        }

        public string GetFirstItemName()
        {
            return FirstItemName.GetText();
        }
    }
}
