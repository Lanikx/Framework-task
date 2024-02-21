using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace PageObjects.Framework.WebDriverCreators
{
    internal class FireFoxDriverCreator : DriverCreator
    {
        internal override IWebDriver CreateDriver()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.AddArgument("disable-gpu");
            var newDriver = new FirefoxDriver(options);
            newDriver.Manage().Window.Maximize();
            return newDriver;
        }
    }
}