using WebElement = OnlinerTests.PageObjects.Basic.WebElement;
using IWebDriver = OpenQA.Selenium.IWebDriver;
using OnlinerTests.PageObjects.Basic;

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
