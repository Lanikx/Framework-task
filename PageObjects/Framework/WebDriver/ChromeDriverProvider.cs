using OpenQA.Selenium;
using PageObjects.Framework.WebDriverCreators;

namespace PageObjects.Framework.WebDriver
{
    public class ChromeDriverProvider
    {
        private static ThreadLocal<IWebDriver> _storedDriver = new ThreadLocal<IWebDriver>();

        private ChromeDriverProvider() { }

        public static IWebDriver GetDriver()
        {
            if (_storedDriver.Value == null)
            {
                _storedDriver.Value = new ChromeDriverCreator().CreateDriver();
            }
            return _storedDriver.Value;
        }
    }
}