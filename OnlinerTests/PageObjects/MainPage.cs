using OnlinerTests.PageObjects.Basic;
using IWebDriver = OpenQA.Selenium.IWebDriver;
using OpenQA.Selenium;
using WebElement = OnlinerTests.PageObjects.Basic.WebElement;

namespace OnlinerTests.PageObjects
{
    class MainPage : BasePage
    {
        private static IWebDriver _driver = WebDriverProvider.Driver;
        public MainPage() : base()
        {
            _driver.Navigate().GoToUrl("https://catalog.onliner.by/");
        }

        private WebElement _pageTitle => new WebElement(By.XPath("//div[@class='catalog-navigation__title' and contains(text(),'Каталог')]"));

        private WebElement _electronicsSection => new WebElement(By.XPath("//span[@class='catalog-navigation-classifier__item-title']/*[text()='Электроника']/.."));

        private WebElement _onlinerLogo => new WebElement(By.XPath("//div/a/img[@class='onliner_logo']"));

        private WebElement _phonesAndAccessoriesSubsection => new WebElement(By.XPath("//div[@class='catalog-navigation-list__aside-title' and contains(text(),'Мобильные')]"));

        private WebElement _smartphonesSubSubSection => new WebElement(By.XPath("//div[contains(text(),'Мобильные')]/..//span[contains(text(), 'Смартфоны')]"));

        private WebElement _signInButton => new WebElement(By.XPath("//div[contains(text(),'Вход')]"));

        public bool IsLogoPresent()
        {
            return _onlinerLogo.Displayed; 
        }

        public void ClickElectronicsSection()
        {
            _electronicsSection.Click();
        }

        public void ClickPhonesAndAccessoriesSubsection()
        {
            _phonesAndAccessoriesSubsection.Click();
        }

        public void ClickSmartphonesSubSubSection()
        {
            _smartphonesSubSubSection.Click();
        }

        public override bool IsOnPage()
        {
            return _pageTitle.Displayed;
        }

        public void ClickSignInButton()
        {
            _signInButton.Click();
        }
    }
}
