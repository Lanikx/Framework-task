using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace OnlinerTests.PageObjects.Basic
{
    public static class WebDriverExtension
    {
        public static WebDriverWait GetWait(this IWebDriver driver) => new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        public static Actions GetActions(this IWebDriver driver) =>  new Actions(driver);

        public static List<WebElement> FindWebElements(this IWebDriver driver, By strategy)
        {
            var WebElements = driver.FindElements(strategy);
            List<WebElement> result = new List<WebElement>();
            foreach (var element in WebElements)
            {
                result.Add(new WebElement(element));
            }
            return result;
        }
    }
}
