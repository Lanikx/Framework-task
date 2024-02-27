using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using PageObjects.Framework.Utils;
using PageObjects.Framework.WebDriverCreators;

namespace PageObjects.Framework.WebDriver
{
    public class DriverFactory
    {
        private static ThreadLocal<IWebDriver> _storedDriver = new ThreadLocal<IWebDriver>();

        private DriverFactory() { }

        private static IWebDriver Create()
        {
            DriverConfig driverConfig = new DriverConfig();
            switch (driverConfig.Data["type"])
            { 
                case "chrome": return new ChromeDriverCreator().CreateDriver();
                case "firefox": return new FireFoxDriverCreator().CreateDriver();
                default: throw new DriveNotFoundException("No driver was specified");
            }
        }

        public static IWebDriver GetDriver()
        {
            if (_storedDriver.Value == null)
            {             
                _storedDriver.Value = Create();
            }
            return _storedDriver.Value;
        }

        public WebDriverWait GetWait() => new WebDriverWait(_storedDriver.Value, TimeSpan.FromSeconds(10));

        public Actions GetActions() => new Actions(_storedDriver.Value);
    }
}