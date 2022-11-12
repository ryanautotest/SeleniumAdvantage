using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RookieTest.TestSetup;
using SeleniumFramework.APICore;
using RookieTest.Services;

namespace RookieTest.TestCases
{
    [TestFixture]
    public class APITest : ProjectNUnitTestSetup
    {
        [Test]
        public void APIResquestTest()
        {
            APIResponse response = new MockAPIService().LoginRequest("ryanautotest", "Aa@123456");
            Assert.AreEqual(response.responseStatusCode, "OK");
        }

    }
}
