using OnlinerTests.PageObjects.Basic;
using OpenQA.Selenium;

namespace OnlinerTests.PageObjects
{
    public abstract class BasePage
    {
        public BasePage() { }

        public BasePage(IWebDriver driver) { }

        public abstract bool IsOnPage();
    }
}
