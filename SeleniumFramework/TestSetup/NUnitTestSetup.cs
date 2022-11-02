using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumFramework.DriverCore;

namespace SeleniumFramework.TestSetup;

public class NUnitTestSetup
{
    public IWebDriver? driver;
    public WebDriverAction? driverBaseAction;

    [SetUp]
    public void Setup()
    {
        WebDriverManager_.InitDriver("chrome", 1920, 1080);
        driver = WebDriverManager_.GetCurrentDriver();
    }

    [TearDown]
    public void TearDown()
    {
        // _driver?.Quit();
        TestStatus testStatus = TestContext.CurrentContext.Result.Outcome.Status;
        if (testStatus.Equals(TestStatus.Passed))
        {
            TestContext.WriteLine("Passed");
        }
        else if (testStatus.Equals(TestStatus.Failed))
        {
            TestContext.WriteLine("Failed");
            driverBaseAction.CapturedScreen();
        }
    }

}
