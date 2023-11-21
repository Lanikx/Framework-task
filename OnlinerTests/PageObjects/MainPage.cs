using WebElement = OnlinerTests.PageObjects.Basic.WebElement;
using IWebDriver = OpenQA.Selenium.IWebDriver;
using OnlinerTests.PageObjects.Basic;
using OpenQA.Selenium;

namespace OnlinerTests.PageObjects
{
    class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver, "https://www.onliner.by/")
        {

        }
        private WebElement electronicsSection => new WebElement(driver, By.XPath("//span[@class='catalog-navigation-classifier__item-title']/*[text()='Электроника']/.."));

        private WebElement onlinerLogo => new WebElement(driver, By.XPath("//div/a/img[@class='onliner_logo']"));

        private WebElement phonesAndAccessoriesSubsection => new WebElement(driver, By.XPath("//div[@class='catalog-navigation-list__aside-title' and contains(text(),'Мобильные')]"));

        private WebElement smartphonesSubSubSection => new WebElement(driver, By.XPath("//div[contains(text(),'Мобильные')]/..//span[contains(text(), 'Смартфоны')]"));

        public bool IsLogoPresent()
        {
            return onlinerLogo.IsElementInDom();
        }

        public void ClickElectronicsSection()
        {
            electronicsSection.GetElement().Click();
        }

        public void ClickPhonesAndAccessoriesSubsection()
        {
            phonesAndAccessoriesSubsection.GetElement().Click();
        }

        public void ClickSmartphonesSubSubSection()
        {
            smartphonesSubSubSection.GetElement().Click();
        }
    }
}
