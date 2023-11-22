using OnlinerTests.PageObjects.Basic;
using OpenQA.Selenium;

namespace OnlinerTests.PageObjects
{
    public class BasePage
    {

        public BasePage()
        {
        }

        public BasePage(IWebDriver driver)
        {
        }

        public bool IsOnPage(string pageUrl)
        {
            return WebDriverProvider.Driver.Url == pageUrl;
        }
    }
}
