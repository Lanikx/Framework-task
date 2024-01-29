using OpenQA.Selenium;

namespace OnlinerTests.PageObjects.Basic
{
    public class WebElement
    {
        private IWebElement _element;
        private List<IWebElement> _elements;
        private static IWebDriver _currentDriver => WebDriverProvider.Driver;
        private By _strategy;

        public IWebElement Element
        {
            get
            {
                if (_element == null)
                {
                    InitElement();
                }
                return _element;
            }
        }

        public List<IWebElement> Elements
        {
            get
            {
                if (_elements.Count == 0)
                {
                    InitElements();
                }
                return _elements;
            }
        }

        public WebElement(By strategy)
        {
            _strategy = strategy;
        }

        private void InitElement()
        {
            _currentDriver.GetWait().Until(drv => drv.FindElements(_strategy).Count() != 0);
            _element = _currentDriver.FindElement(_strategy);
        }

        private void InitElements()
        {
            _currentDriver.GetWait().Until(drv => drv.FindElements(_strategy).Count() != 0);
            _elements = _currentDriver.FindElements(_strategy).ToList();
        }

        public bool IsEnabled() => Element.Enabled;

        public bool IsDisplayed() => Element.Displayed;

        public void Click()
        {
            _currentDriver.GetActions().Click(Element).Perform();
        }

        public void ScrollToElement()
        {
            _currentDriver.GetActions().MoveToElement(Element);
        }

        public void SendKeys(string keys)
        {
            Element.SendKeys(keys);
        }

        public void Clear()
        {
            Element.Clear();
        }

        public void WaitIsDisplayed()
        {
            _currentDriver.GetWait().Until(el => Element.Displayed);
        }

        public string GetText()
        {
            return Element.Text;
        }
    }
}