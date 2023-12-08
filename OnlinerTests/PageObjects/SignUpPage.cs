using OpenQA.Selenium;
using WebElement = OnlinerTests.PageObjects.Basic.WebElement;

namespace OnlinerTests.PageObjects
{
    internal class SignUpPage
    {
        private WebElement _registerLink => new WebElement(By.XPath("//a[contains(text(),'Зарегистрироваться')]"));

        private WebElement _registerEmailInput => new WebElement(By.XPath("//input[@type='email']"));

        private WebElement _registerPasswordInput => new WebElement(By.XPath("//input[contains(@placeholder,'Придумайте')]"));

        private WebElement _incorrectEmailErrorMessage => new WebElement(By.XPath("//div[contains(text(),'Некорректный e-mail')]"));

        private WebElement _shortPasswordErrorMessage => new WebElement(By.XPath("//div[contains(text(),'Минимум 8 ')]"));

        private WebElement _repeatPasswordInput => new WebElement(By.XPath("//input[contains(@placeholder, 'Повторите')]"));

        private WebElement _passwordsDontMatchErrorMessage => new WebElement(By.XPath("//div[contains(text(),'Пароли не совпадают')]"));

        public void ClickGoToRegisterForm()
        {
            _registerLink.Click();
        }

        public void InputEmail(string inputString) 
        {
            _registerEmailInput.SendKeys(inputString);
        }

        public void ClearEmail()
        {
            _registerEmailInput.Clear();
        }

        public void InputPassword(string inputString)
        {
            _registerPasswordInput.SendKeys(inputString);
        }

        public void ClearPassword()
        {
            _registerPasswordInput.Clear();
        }

        public bool IsEmailErrorPresent()
        {
            return _incorrectEmailErrorMessage.Displayed;
        }

        public bool IsPasswordErrorPresent()
        {
            return _shortPasswordErrorMessage.Displayed;
        }

        public void InputPasswordRepeat(string input)
        {
            _repeatPasswordInput.SendKeys(input);
        }

        public bool IsPasswordsDontMatchErrorPresent()
        {
            return _passwordsDontMatchErrorMessage.Displayed;
        }
    }
}
