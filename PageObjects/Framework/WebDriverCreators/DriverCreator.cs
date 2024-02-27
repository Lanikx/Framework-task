using OpenQA.Selenium;

namespace PageObjects.Framework.WebDriverCreators
{
    public abstract class DriverCreator
    {
        public abstract IWebDriver CreateDriver();
    }
}
