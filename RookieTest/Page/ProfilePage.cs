using OpenQA.Selenium;
using SeleniumFramework.DriverCore;
using System;
namespace RookieTest.Page
{
    public class ProfilePage : WebDriverAction
    {
        public ProfilePage(IWebDriver driver) : base(driver)
        {
        }

        private readonly String btnLogout = "//button[text()='Log out']";
        private readonly String btnGoToStore = "//button[@id='gotoStore']";
        private readonly String txtfSearch = "//input[@type='text']";
        private readonly String lblUserName = "//label[@id='userName-label']//following-sibling::label";

        public void BookSearch(String keyword)
        {
            SendKeys_(txtfSearch, keyword);
        }

        public void LogOut()
        {
            Click(btnLogout);
        }

        public void GoToStore()
        {
            Click(btnGoToStore);
        }

        public string GetUserName()
        {
            return GetText(lblUserName);
        }
    }
}
