using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace PageObjects.Framework.WebDriver
{
    public static class WebDriverExtension
    {
        public static WebDriverWait GetWait(this IWebDriver driver) => new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        public static Actions GetActions(this IWebDriver driver) => new Actions(driver);
    }
}