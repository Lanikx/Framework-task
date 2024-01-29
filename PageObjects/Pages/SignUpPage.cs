using OpenQA.Selenium;
using WebElement = OnlinerTests.PageObjects.Basic.WebElement;

namespace OnlinerTests.PageObjects
{
    public class SignUpPage
    {
        private WebElement RegisterLink => new WebElement(By.XPath("//a[contains(text(),'Зарегистрироваться')]"));

        private WebElement RegisterEmailInput => new WebElement(By.XPath("//input[@type='email']"));

        private WebElement RegisterPasswordInput => new WebElement(By.XPath("//input[contains(@placeholder,'Придумайте')]"));

        private WebElement IncorrectEmailErrorMessage => new WebElement(By.XPath("//div[contains(text(),'Некорректный e-mail')]"));

        private WebElement ShortPasswordErrorMessage => new WebElement(By.XPath("//div[contains(text(),'Минимум 8 ')]"));

        private WebElement RepeatPasswordInput => new WebElement(By.XPath("//input[contains(@placeholder, 'Повторите')]"));

        private WebElement PasswordsDontMatchErrorMessage => new WebElement(By.XPath("//div[contains(text(),'Пароли не совпадают')]"));

        public void ClickGoToRegisterForm()
        {
            RegisterLink.Click();
        }

        public void InputEmail(string inputString) 
        {
            RegisterEmailInput.SendKeys(inputString);
        }

        public void ClearEmail()
        {
            RegisterEmailInput.Clear();
        }

        public void InputPassword(string inputString)
        {
            RegisterPasswordInput.SendKeys(inputString);
        }

        public void ClearPassword()
        {
            RegisterPasswordInput.Clear();
        }

        public bool IsEmailErrorPresent()
        {
            return IncorrectEmailErrorMessage.IsDisplayed();
        }

        public bool IsPasswordErrorPresent()
        {
            return ShortPasswordErrorMessage.IsDisplayed();
        }

        public void InputPasswordRepeat(string input)
        {
            RepeatPasswordInput.SendKeys(input);
        }

        public bool IsPasswordsDontMatchErrorPresent()
        {
            return PasswordsDontMatchErrorMessage.IsDisplayed();
        }
    }
}