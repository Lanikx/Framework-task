using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using static OnlinerTests.PageObjects.Basic.WebDriverExtension;

namespace OnlinerTests.PageObjects.Basic
{
    public class WebElement
    {
        private IWebElement _element;
        private List<IWebElement> _elements;
        private static IWebDriver currentDriver => WebDriverProvider.Driver;
        private By _strategy;

        public WebElement(IWebDriver driver, By strategy)
        {
            _strategy = strategy;
        }

        private void InitElement()
        {
            currentDriver.GetWait().Until(drv => currentDriver.FindElements(_strategy).Count() != 0);
            _element = currentDriver.FindElement(_strategy);
        }

        private void InitElements()
        {
            currentDriver.GetWait().Until(drv => currentDriver.FindElements(_strategy).Count() != 0);
            _elements = currentDriver.FindElements(_strategy).ToList();
        }

        public IWebElement GetElement()
        {
            if (_element == null)
            {
                InitElement();
            }
            return _element;
        }

        public List<IWebElement> GetElements()
        {
            if (_elements == null)
            {
                InitElements();
            }
            return _elements;
        }
    }
}
