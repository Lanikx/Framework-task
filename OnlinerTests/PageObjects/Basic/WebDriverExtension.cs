using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace OnlinerTests.PageObjects.Basic
{
    public static class WebDriverExtension
    {
        static WebDriverExtension() { }

        public static WebDriverWait GetWait(this IWebDriver driver)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
    }
}
