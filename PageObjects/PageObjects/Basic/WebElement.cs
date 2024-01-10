using OpenQA.Selenium;

namespace OnlinerTests.PageObjects.Basic
{
    public class WebElement
    {
        private IWebElement _element;
        private List<IWebElement> _elements;
        private static IWebDriver _currentDriver => WebDriverProvider.Driver;
        private By _strategy;

        public bool Enabled
        {
            get
            {
                if (_element == null)
                {
                    InitElement();
                }
                return _element.Enabled;
            }
        }

        public bool Displayed
        {
            get
            {
                if (_element == null)
                {
                    InitElement();
                }
                return _element.Displayed;
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

        public IWebElement GetElement()
        {
            SetElement();
            return _element;
        }

        public List<IWebElement> GetElements()
        {
            SetElement();
            return _elements;
        }

        public void Click()
        {
            SetElement();
            _currentDriver.GetActions().Click(_element).Perform();
        }

        public void ScrollToElement()
        {
            _currentDriver.GetActions().MoveToElement(GetElement());
        }

        public void SendKeys(string keys)
        {
            SetElement();
            _element.SendKeys(keys);
        }

        public void Clear()
        {
            SetElement();
            _element.Clear();
        }

        public void WaitIsDisplayed()
        {
            SetElement();
            _currentDriver.GetWait().Until(el => _element.Displayed);
        }

        public string GetText()
        {
            SetElement();
            return _element.Text;
        }

        private void SetElement()
        {
            if (_element == null)
            {
                InitElement();
            }
        }
    }
}
