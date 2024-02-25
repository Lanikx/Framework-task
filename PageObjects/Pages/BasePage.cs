using OpenQA.Selenium;
using PageObjects.Framework.WebDriver;

namespace OnlinerTests.PageObjects
{
    public abstract class BasePage
    {
        protected static IWebDriver _currentDriver => DriverFactory.GetDriver(WebDriverTypes.Chrome);

        public abstract bool IsOnPage();
    }
}