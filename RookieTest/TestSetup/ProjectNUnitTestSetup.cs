using NUnit.Framework;
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
            driver.Url = "https://demo.guru99.com/v4/";
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
