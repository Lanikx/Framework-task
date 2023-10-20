using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace OnlinerTests.PageObjects.Basic
{
    public class WebElement
    {
        private IWebElement? _element;
        private List<IWebElement>? _elements;
        private IWebDriver _driver;
        private By _strategy;
        private WebDriverWait wait;

        public IWebElement Element { 
            get {
                if (_element == null)
                {
                    wait.Until(ElementIsInDom());
                    InitElement();
                }
                return _element;
            } 
        }

        public WebElement(IWebDriver driver, By strategy)
        {
            _driver = driver;
            _strategy = strategy;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        private void InitElement()
        {
            _element = _driver.FindElement(_strategy);
        }

        private void InitElements()
        {
            _elements = _driver.FindElements(_strategy).ToList();
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

        private Func<IWebDriver, bool> ElementIsInDom()
        {
            return drv => _driver.FindElements(_strategy).Count != 0;
        }

        public bool IsElementInDom()
        {
            InitElements();
            return _elements.Count != 0;
        }
    }
}
