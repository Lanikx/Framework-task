using IWebDriver = OpenQA.Selenium.IWebDriver;
using OpenQA.Selenium;
using WebElement = OnlinerTests.PageObjects.Basic.WebElement;
using OnlinerTests.PageObjects.Basic;

namespace OnlinerTests.PageObjects
{
    public class MainPage : BasePage
    {
        private static IWebDriver _driver = WebDriverProvider.Driver;

        public MainPage() : base()
        {
            _driver.Navigate().GoToUrl("https://catalog.onliner.by/");
        }

        private WebElement PageTitle => new WebElement(By.XPath("//div[@class='catalog-navigation__title' and contains(text(),'Каталог')]"));

        private WebElement ElectronicsSection => new WebElement(By.XPath("//span[@class='catalog-navigation-classifier__item-title']/*[text()='Электроника']/.."));

        private WebElement OnlinerLogo => new WebElement(By.XPath("//div/a/img[@class='onliner_logo']"));

        private WebElement PhonesAndAccessoriesSubsection => new WebElement(By.XPath("//div[@class='catalog-navigation-list__aside-title' and contains(text(),'Мобильные')]"));

        private WebElement VideoGamesSubSection => new WebElement(By.XPath("//div[@class='catalog-navigation-list__aside-title' and contains(text(), 'Видеоигры')]"));

        private WebElement SmartphonesSubSubSection => new WebElement(By.XPath("//div[contains(text(),'Мобильные')]/..//span[contains(text(), 'Смартфоны')]"));

        private WebElement GameConsolesSubSubSection => new WebElement(By.XPath("//div[contains(text(),'Видеоигры')]/..//span[contains(text(), 'Игровые приставки')]"));

        private WebElement SignInButton => new WebElement(By.XPath("//div[contains(text(),'Вход')]"));

        public bool IsLogoPresent()
        {
            return OnlinerLogo.IsDisplayed(); 
        }

        public void ClickElectronicsSection()
        {
            ElectronicsSection.Click();
        }

        public void ClickPhonesAndAccessoriesSubsection()
        {
            PhonesAndAccessoriesSubsection.Click();
        }

        public void ClickSmartphonesSubSubSection()
        {
            SmartphonesSubSubSection.Click();
        }

        public override bool IsOnPage()
        {
            return PageTitle.IsDisplayed();
        }

        public void ClickSignInButton()
        {
            SignInButton.Click();
        }

        public void ClickVideoGamesSubSection()
        {
            VideoGamesSubSection.WaitIsDisplayed();
            VideoGamesSubSection.Click();
        }

        public void ClickGameConsolesSubSubSection()
        {
            GameConsolesSubSubSection.Click();
        }
    }
}