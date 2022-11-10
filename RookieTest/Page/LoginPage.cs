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

        private readonly String txtUserName = "//input[@id='userName']";
        private readonly String txtPassword = "//input[@id='password']";
        private readonly String btnLogin = "//button[@id='login']";
        private readonly String btnNewUser = "//button[@id='newUser']";

        public void InputUserName(String userName)
        {
            SendKeys_(txtUserName, userName);
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
