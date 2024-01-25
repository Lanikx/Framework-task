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
            signUpPage.InputEmail("rehdf,j,th");
            var emailErrorPresent = signUpPage.IsEmailErrorPresent();
            Assert.IsTrue(emailErrorPresent);
            signUpPage.ClearEmail();
            signUpPage.InputPassword("zgthlj");
            var paswordErrorPresent = signUpPage.IsPasswordErrorPresent();
            Assert.IsTrue(paswordErrorPresent);
            signUpPage.ClearPassword();
            signUpPage.InputEmail("sobaka@gmail.com");
            signUpPage.InputPassword("DoNotH4ck17");
            signUpPage.InputPasswordRepeat("OkYouC4nH4ck17");
            var dontMatchPresent = signUpPage.IsPasswordsDontMatchErrorPresent();
            Assert.IsTrue(dontMatchPresent);    
        }
    }
}
