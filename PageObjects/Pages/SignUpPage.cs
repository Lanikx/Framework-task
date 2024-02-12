using OpenQA.Selenium;
using WebElement = OnlinerTests.PageObjects.Basic.WebElement;

namespace OnlinerTests.PageObjects
{
    public class SignUpPage
    {
        private WebElement RegisterLink => new WebElement(By.XPath("//a[contains(text(),'Зарегистрироваться')]"));

        private WebElement RegisterEmailInput => new WebElement(By.XPath("//input[@type='email']"));

        private WebElement RegisterPasswordInput => new WebElement(By.XPath("//input[contains(@placeholder,'Придумайте')]"));

        private WebElement IncorrectEmailErrorMessageElement => new WebElement(By.XPath("//div[contains(text(),'Некорректный e-mail')]"));

        private WebElement ShortPasswordErrorMessageElement => new WebElement(By.XPath("//div[contains(text(),'Минимум 8 ')]"));

        private WebElement RepeatPasswordInput => new WebElement(By.XPath("//input[contains(@placeholder, 'Повторите')]"));

        private WebElement PasswordsDontMatchErrorMessageElement => new WebElement(By.XPath("//div[contains(text(),'Пароли не совпадают')]"));

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
            return IncorrectEmailErrorMessageElement.IsDisplayed();
        }

        public bool IsPasswordErrorPresent()
        {
            return ShortPasswordErrorMessageElement.IsDisplayed();
        }

        public void InputPasswordRepeat(string input)
        {
            RepeatPasswordInput.SendKeys(input);
        }

        public bool IsPasswordsDontMatchErrorPresent()
        {
            return PasswordsDontMatchErrorMessageElement.IsDisplayed();
        }
    }
}