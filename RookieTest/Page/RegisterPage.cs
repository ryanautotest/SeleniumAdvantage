using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumFramework.DriverCore;
using System;
using SeleniumExtras;

namespace RookieTest.Page
{
    public class RegisterPage : WebDriverAction
    {
        public RegisterPage(IWebDriver driver) : base(driver)
        {
        }

        private readonly String txtFirstName = "//input[@id='firstname']";
        private readonly String txtLastName = "//input[@id='lastname']";
        private readonly String txtUserName = "//input[@id='userName']";
        private readonly String txtPassword = "//input[@id='password']";
        private readonly String cbCaptcha = "//div[@class='recaptcha-anchor']";
        private readonly String btnRegister = "//button[@id='register']";
        private readonly String btnBackToLogin = "//button[@id='gotologin']";

        public void InputFirstName(String firstName)
        {
            SendKeys_(txtFirstName, firstName);
        }
        public void InputLastName(String lastName)
        {
            SendKeys_(txtLastName, lastName);
        }
        public void InputUserName(String userName)
        {
            SendKeys_(txtUserName, userName);
        }
        public void InputPassword(String password)
        {
            SendKeys_(txtPassword, password);
        }

        public void CheckCaptcha()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.FrameToBeAvailableAndSwitchToIt
                (ByXpath("//iframe[starts-with(@name, 'a-') and starts-with(@src, 'https://www.google.com/recaptcha')]")));
            Click(cbCaptcha);
        }

        public void ClickRegister()
        {
            Click(btnRegister);
        }

        public void ClickBackToLogin()
        {
            Click(btnBackToLogin);
        }
    }
}
