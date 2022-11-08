using NUnit.Framework;
using RookieTest.Page;
using RookieTest.TestSetup;

namespace RookieTest
{
    public class RegisterTest : ProjectNUnitTestSetup
    {
        [Test]
        public void Register()
        {
            HomePage homePage = new HomePage(driver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(driver);
            loginPage.ClickNewUser();
            
            RegisterPage registerPage = new RegisterPage(driver);
            registerPage.InputFirstName("Ryan");
            registerPage.InputLastName("Nguyen");
            registerPage.InputUserName("ryanautotest");
            registerPage.InputPassword("123456");
            registerPage.CheckCaptcha();
            registerPage.ClickRegister();
        }
    }
}