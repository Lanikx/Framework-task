using OpenQA.Selenium;
using WebElement = PageObjects.Framework.WebElements.WebElement;

namespace OnlinerTests.PageObjects
{
    public class MainPage : BasePage
    {
        private WebElement PageTitleElement => new WebElement(By.XPath("//div[@class='catalog-navigation__title' and contains(text(),'Каталог')]"));

        private WebElement ElectronicsSectionElement => new WebElement(By.XPath("//span[@class='catalog-navigation-classifier__item-title']/*[text()='Электроника']/.."));

        private WebElement OnlinerLogoElement => new WebElement(By.XPath("//div/a/img[@class='onliner_logo']"));

        private WebElement PhonesAndAccessoriesSubsectionElement => new WebElement(By.XPath("//div[@class='catalog-navigation-list__aside-title' and contains(text(),'Мобильные')]"));

        private WebElement VideoGamesSubSectionElement => new WebElement(By.XPath("//div[@class='catalog-navigation-list__aside-title' and contains(text(), 'Видеоигры')]"));

        private WebElement SmartphonesSubSubSectionElement => new WebElement(By.XPath("//div[contains(text(),'Мобильные')]/..//span[contains(text(), 'Смартфоны')]"));

        private WebElement GameConsolesSubSubSectionElement => new WebElement(By.XPath("//div[contains(text(),'Видеоигры')]/..//span[contains(text(), 'Игровые приставки')]"));

        private WebElement SignInButton => new WebElement(By.XPath("//div[contains(text(),'Вход')]"));

        private WebElement CookieAgreeButton => new WebElement(By.XPath("//p[@class='fc-button-label' and contains(text(), 'Соглашаюсь')]"));

        public bool IsLogoPresent()
        {
            return OnlinerLogoElement.IsDisplayed();
        }

        public void ClickElectronicsSection()
        {
            ElectronicsSectionElement.Click();
        }

        public void ClickPhonesAndAccessoriesSubsection()
        {
            PhonesAndAccessoriesSubsectionElement.Click();
        }

        public void ClickSmartphonesSubSubSection()
        {
            SmartphonesSubSubSectionElement.Click();
        }

        public override bool IsOnPage()
        {
            return PageTitleElement.IsDisplayed();
        }

        public void ClickSignInButton()
        {
            SignInButton.Click();
        }

        public void ClickVideoGamesSubSection()
        {
            VideoGamesSubSectionElement.WaitIsVisible();
            VideoGamesSubSectionElement.Click();
        }

        public void ClickGameConsolesSubSubSection()
        {
            GameConsolesSubSubSectionElement.Click();
        }

        public void CloseCookiePrompt()
        {
            CookieAgreeButton.Click();
        }
    }
}