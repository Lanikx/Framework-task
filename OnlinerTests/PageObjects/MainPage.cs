using WebElement = OnlinerTests.PageObjects.Basic.WebElement;
using IWebDriver = OpenQA.Selenium.IWebDriver;
using OnlinerTests.PageObjects.Basic;
using OpenQA.Selenium;

namespace OnlinerTests.PageObjects
{
    class MainPage : BasePage
    {
        public MainPage() : base()
        {

        }
        private WebElement electronicsSection => new WebElement(WebDriverProvider.Driver, By.XPath("//span[@class='catalog-navigation-classifier__item-title']/*[text()='Электроника']/.."));

        private WebElement onlinerLogo => new WebElement(WebDriverProvider.Driver, By.XPath("//div/a/img[@class='onliner_logo']"));

        private WebElement phonesAndAccessoriesSubsection => new WebElement(WebDriverProvider.Driver, By.XPath("//div[@class='catalog-navigation-list__aside-title' and contains(text(),'Мобильные')]"));

        private WebElement smartphonesSubSubSection => new WebElement(WebDriverProvider.Driver, By.XPath("//div[contains(text(),'Мобильные')]/..//span[contains(text(), 'Смартфоны')]"));

        public bool IsLogoPresent()
        {
            return onlinerLogo.GetElement().Displayed; 
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
