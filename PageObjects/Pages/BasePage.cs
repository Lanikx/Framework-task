using OpenQA.Selenium;
using PageObjects.Framework.WebDriver;
using PageObjects.Framework.WebDriverCreators;

namespace OnlinerTests.PageObjects
{
    public abstract class BasePage
    {
        protected static IWebDriver _currentDriver => DriverFactory.GetDriver();

        public abstract bool IsOnPage();
    }
}