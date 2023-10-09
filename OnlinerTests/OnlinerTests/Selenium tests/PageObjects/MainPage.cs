using WebElement = OnlinerTests.Selenium_tests.PageObjects.WebElement.WebElement;
using IWebDriver = OpenQA.Selenium.IWebDriver;

namespace OnlinerTests.PageObjects
{
    class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver, "https://www.onliner.by/")
        {

        }

        private WebElement onlinerLogo => new WebElement(driver, SearchStrategy.Xpath, "//div/a/img[@class='onliner_logo']");

        public bool IsLogoPresent()
        {
            return onlinerLogo.IsElementInDom();
        }
    }
}
