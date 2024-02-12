using OpenQA.Selenium;

namespace OnlinerTests.PageObjects.Basic
{
    public class WebElement
    {
        private IWebElement _element;
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

        public WebElement(By strategy)
        {
            _strategy = strategy;
        }

        internal WebElement(IWebElement element)
        {
            _element = element;
        }

        private void InitElement()
        {            
            WaitIsPresentOnPage();
            _element = _currentDriver.FindElement(_strategy);
        }

        public bool IsEnabled() => Element.Enabled;

        public bool IsDisplayed() => Element.Displayed;

        public string GetText() => Element.Text;

        public void ClickViaActions()
        {
            _currentDriver.GetActions().Click(Element).Perform();
        }

        public void ClickViaJS()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)_currentDriver;
            executor.ExecuteScript("arguments[0].click();", Element);
        }

        public void Click()
        {
            Element.Click();
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
            _element.Clear();
        }

        public void WaitIsPresentOnPage()
        {
            _currentDriver.GetWait().Until(drv => drv.FindElements(_strategy).Count() != 0);
        }

        public void WaitIsVisible()
        {
            _currentDriver.GetWait().Until(drv => _element.Displayed);
        }

        public void WaitIsEnabled()
        {
            _currentDriver.GetWait().Until(drv => _element.Enabled);
        }
    }
}