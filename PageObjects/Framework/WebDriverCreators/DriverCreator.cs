using OpenQA.Selenium;

namespace PageObjects.Framework.WebDriverCreators
{
    internal abstract class DriverCreator
    {
        internal abstract IWebDriver CreateDriver();
    }
}
