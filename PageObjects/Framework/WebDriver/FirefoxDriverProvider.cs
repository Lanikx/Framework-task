using OpenQA.Selenium;
using PageObjects.Framework.WebDriverCreators;

namespace PageObjects.Framework.WebDriver
{
    internal class FirefoxDriverProvider
    {
        private static ThreadLocal<IWebDriver> _storedDriver = new ThreadLocal<IWebDriver>();

        private FirefoxDriverProvider() { }

        public static IWebDriver GetDriver()
        {
            if (_storedDriver.Value == null)
            {
                _storedDriver.Value = new FireFoxDriverCreator().CreateDriver();
            }
            return _storedDriver.Value;
        }
    }
}