using WebElement = OnlinerTests.PageObjects.Basic.WebElement;
using IWebDriver = OpenQA.Selenium.IWebDriver;
using OpenQA.Selenium;

namespace OnlinerTests.PageObjects
{
    class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver, "https://www.onliner.by/")
        {

        }

        private WebElement onlinerLogo => new WebElement(driver, By.XPath("//div/a/img[@class='onliner_logo']"));

        public bool IsLogoPresent()
        {
            return onlinerLogo.IsElementInDom();
        }
    }
}
