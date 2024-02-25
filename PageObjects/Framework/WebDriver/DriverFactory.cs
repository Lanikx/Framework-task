using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using PageObjects.Framework.WebDriverCreators;

namespace PageObjects.Framework.WebDriver
{
    public class DriverFactory
    {
        private static ThreadLocal<IWebDriver> _storedDriver = new ThreadLocal<IWebDriver>();
        private DriverFactory() { }

        private static IWebDriver Create(WebDriverTypes webDriverType)
        {
            switch (webDriverType)
            {
                case WebDriverTypes.Chrome: return new ChromeDriverCreator().CreateDriver();
                case WebDriverTypes.FireFox: return new FireFoxDriverCreator().CreateDriver();
                default: return new ChromeDriverCreator().CreateDriver();
            }
        }

        public static IWebDriver GetDriver(WebDriverTypes webDriverType)
        {
            if (_storedDriver.Value == null)
            {
                _storedDriver.Value = Create(webDriverType);
            }
            return _storedDriver.Value;
        }

        public WebDriverWait GetWait() => new WebDriverWait(_storedDriver.Value, TimeSpan.FromSeconds(10));

        public Actions GetActions() => new Actions(_storedDriver.Value);
    }
}