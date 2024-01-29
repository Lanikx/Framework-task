using OpenQA.Selenium;

namespace OnlinerTests.PageObjects
{
    public abstract class BasePage
    {
        public BasePage() { }

        public abstract bool IsOnPage();
    }
}