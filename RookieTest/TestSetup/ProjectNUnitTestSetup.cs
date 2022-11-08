﻿using NUnit.Framework;
using SeleniumFramework.TestSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookieTest.TestSetup
{
    public class ProjectNUnitTestSetup : NUnitTestSetup 
    {
        [SetUp]
        public void SetUp()
        {
            driver.Url = "https://demoqa.com/books";
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
