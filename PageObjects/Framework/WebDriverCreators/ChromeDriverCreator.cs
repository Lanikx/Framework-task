using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObjects.Framework.WebDriverCreators
{
    public class ChromeDriverCreator : DriverCreator
    {
        public override IWebDriver CreateDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("disable-gpu");
            var newDriver = new ChromeDriver(options);
            newDriver.Manage().Window.Maximize();
            return newDriver;
        }
    }
}