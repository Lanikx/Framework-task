using OpenQA.Selenium;

namespace OnlinerTests.PageObjects
{
    class BasePage
    {

        public BasePage()
        {
        }

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool IsOnPage(string pageUrl)
        {
            return driver.Url == pageUrl;
        }
    }
}
