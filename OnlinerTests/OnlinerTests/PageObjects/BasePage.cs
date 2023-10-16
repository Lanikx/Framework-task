using OpenQA.Selenium;

namespace OnlinerTests.PageObjects
{
    class BasePage
    {
        protected readonly IWebDriver driver;

        public BasePage(IWebDriver driver, string pageUrl)
        {
            this.driver = driver;
            this.driver.Navigate().GoToUrl(pageUrl);
            this.driver.Manage().Window.Maximize();
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
