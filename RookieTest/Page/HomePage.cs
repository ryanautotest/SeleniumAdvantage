using OpenQA.Selenium;
using SeleniumFramework.DriverCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookieTest.Page
{
    public class HomePage : WebDriverAction
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        private readonly string bttLogin = "//button[@id='login']";
        private readonly string inputSearch = "//input[@id='searchBox']";

        public void ClickLogin()
        {
            Click(bttLogin);
        }

        public void InputSearchBox(string keyword)
        {
            SendKeys_(inputSearch, keyword);
        }
    }
}
