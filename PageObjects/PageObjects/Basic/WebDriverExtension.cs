using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace OnlinerTests.PageObjects.Basic
{
    public static class WebDriverExtension
    {
        public static WebDriverWait GetWait(this IWebDriver driver)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public static Actions GetActions(this IWebDriver driver) =>  new Actions(driver); 
    }
}
