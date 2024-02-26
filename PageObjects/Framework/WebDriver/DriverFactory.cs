using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using PageObjects.Config;
using PageObjects.Framework.WebDriverCreators;

namespace PageObjects.Framework.WebDriver
{
    public class DriverFactory
    {
        private static ThreadLocal<IWebDriver> _storedDriver = new ThreadLocal<IWebDriver>();
        private DriverFactory() { }

        private static IWebDriver Create(string driverType)
        {
            switch (driverType.ToLower())
            {
                case "chrome": return new ChromeDriverCreator().CreateDriver();
                case "firefox": return new FireFoxDriverCreator().CreateDriver();
                default: return new ChromeDriverCreator().CreateDriver();
            }
        }

        public static IWebDriver GetDriver()
        {
            if (_storedDriver.Value == null)
            {
                DriverConfig driverConfig = new DriverConfig();
                _storedDriver.Value = Create(driverConfig.Data["type"]);
            }
            return _storedDriver.Value;
        }

        public WebDriverWait GetWait() => new WebDriverWait(_storedDriver.Value, TimeSpan.FromSeconds(10));

        public Actions GetActions() => new Actions(_storedDriver.Value);
    }
}