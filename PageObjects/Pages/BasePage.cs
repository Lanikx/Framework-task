using OpenQA.Selenium;
using PageObjects.Framework.WebDriver;

namespace OnlinerTests.PageObjects
{
    public abstract class BasePage
    {
        protected static IWebDriver _currentDriver => DriverFactory.GetDriver();

        public abstract bool IsOnPage();
    }
}