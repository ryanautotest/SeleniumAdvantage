﻿using OpenQA.Selenium;
using SeleniumFramework.DriverCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookieTest.Page
{
    public class LoginPage : WebDriverAction
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        private readonly String tfUsername = "//input[@name='uid']";

        public void InputUserName(String UserName)
        {
            SendKeys_(tfUsername, UserName);
        }
    }
}
