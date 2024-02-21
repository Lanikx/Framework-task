using NUnit.Framework;
using OnlinerTests.PageObjects;

namespace OnlinerTests.Tests
{
    public class SignUpPageTests : BaseTest
    {
        [TestCase]
        public void CheckLoginFormTest()
        {
            MainPage mainPage = new MainPage();
            Assert.IsTrue(mainPage.IsOnPage(), "User is not on main page");
            mainPage.ClickSignInButton();
            SignUpPage signUpPage = new SignUpPage();
            signUpPage.ClickGoToRegisterForm();
            signUpPage.InputEmail(testDataConfig.Data["badEmail"]);
            var emailErrorPresent = signUpPage.IsEmailErrorPresent();
            Assert.IsTrue(emailErrorPresent);
            signUpPage.ClearEmail();
            signUpPage.InputPassword(testDataConfig.Data["badPassword"]);
            var paswordErrorPresent = signUpPage.IsPasswordErrorPresent();
            Assert.IsTrue(paswordErrorPresent);
            signUpPage.ClearPassword();
            signUpPage.InputEmail(testDataConfig.Data["goodEmail"]);
            signUpPage.InputPassword(testDataConfig.Data["goodPassword1"]);
            signUpPage.InputPasswordRepeat(testDataConfig.Data["goodPassword2"]);
            var dontMatchPresent = signUpPage.IsPasswordsDontMatchErrorPresent();
            Assert.IsTrue(dontMatchPresent);    
        }
    }
}
