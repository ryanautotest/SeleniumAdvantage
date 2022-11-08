using OpenQA.Selenium;
using SeleniumFramework.DriverCore;
using System;
namespace RookieTest.Page
{
    public class LoginPage : WebDriverAction
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        private readonly String txtFirstName = "//input[@id='userName']";
        private readonly String txtPassword = "//input[@id='password']";
        private readonly String btnLogin = "//button[@id='login']";
        private readonly String btnNewUser = "//button[@id='newUser']";

        public void InputFirstName(String firstName)
        {
            SendKeys_(txtFirstName, firstName);
        }

        public void InputPassword(String password)
        {
            SendKeys_(txtPassword, password);
        }

        public void ClickLogin()
        {
            Click(btnLogin);
        }

        public void ClickNewUser()
        {
            Click(btnNewUser);
        }
    }
}
