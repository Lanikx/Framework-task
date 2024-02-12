using OnlinerTests.PageObjects.Basic;
using OpenQA.Selenium;

namespace OnlinerTests.PageObjects
{
    public abstract class BasePage
    {
        protected static IWebDriver _currentDriver => WebDriverProvider.Driver;

        public abstract bool IsOnPage();
    }
}