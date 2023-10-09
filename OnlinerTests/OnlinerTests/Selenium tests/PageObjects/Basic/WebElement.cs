using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace OnlinerTests.Selenium_tests.PageObjects.WebElement
{
    public class WebElement
    {
        private IWebElement _element;
        private List<IWebElement> _elements;
        private IWebDriver _driver;
        private SearchStrategy _strategy;
        private string _searchValue;
        private WebDriverWait wait;

        public WebElement(IWebDriver driver, SearchStrategy strategy, string searchValue)
        {
            _driver = driver;
            _strategy = strategy;
            _searchValue = searchValue;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        private void InitElement()
        {
            _element = _driver.FindElement(Using(_strategy));
        }

        private void InitElements()
        {
            _elements = _driver.FindElements(Using(_strategy)).ToList<IWebElement>();
        }

        public IWebElement GetElement()
        {
            if (_element == null)
            {
                wait.Until(ElementIsInDom());
                InitElement();
            }
            return _element;
        }

        public List<IWebElement> GetElements()
        {
            if (_elements == null)
            {
                wait.Until(ElementIsInDom());
                InitElements();
            }
            return _elements;
        }

        private By Using(SearchStrategy strategy)
        {
            switch (strategy)
            {
                case SearchStrategy.Xpath: return By.XPath(_searchValue);
                case SearchStrategy.CssSelector: return By.CssSelector(_searchValue);
                default: return By.XPath(_searchValue);
            }
        }

        private Func<IWebDriver, bool> ElementIsInDom()
        {
            return drv => _driver.FindElements(Using(_strategy)).Count != 0;
        }

        public bool IsElementInDom()
        {
            InitElements();
            return _elements.Count != 0;
        }
    }
}
