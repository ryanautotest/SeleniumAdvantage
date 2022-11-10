using NUnit.Framework;
using RookieTest.Page;
using RookieTest.TestSetup;

namespace RookieTest
{
    public class LoginTest : ProjectNUnitTestSetup
    {
        [Test]
        public void Login()
        {
            HomePage homePage = new HomePage(driver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(driver);
            loginPage.InputUserName("ryanautotest");
            loginPage.InputPassword("Aa@123456");
            loginPage.ClickLogin();

            ProfilePage profilePage = new ProfilePage(driver);
            Assert.IsTrue(profilePage.GetUserName().Equals("ryanautotest"));
            TestContext.WriteLine("Login Successfully");

        }
    }
}