using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumFramework.Reporter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleniumFramework.DriverCore
{
    public class WebDriverAction
    {
        public IWebDriver driver;

        public WebDriverAction(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By ByXpath(String locator)
        {
            return By.XPath(locator);
        }

        public string getTitle()
        {
            return driver.Title;
        }

        public IWebElement FindElementByXpath(string locator)
        {
            IWebElement e = driver.FindElement(ByXpath(locator));
            highlightElement(e);
            return e;
        }

        public IList<IWebElement> FindElementsByXpath(String locator)
        {
            return driver.FindElements(ByXpath(locator));
        }

        public void Click(IWebElement e)
        {
            try
            {
                highlightElement(e);
                e.Click();
                TestContext.WriteLine("Click into element " + e.ToString + " successfuly");

            }
            catch (Exception ex)
            {
                TestContext.WriteLine("Click into element " + e.ToString + " failed");
                HtmlReport.Fail("Click into element " + e.ToString + " failed", TakeScreenShot());
                throw ex;
            }
        }

        public void Click(String locator)
        {
            try
            {
                FindElementByXpath(locator).Click();
                TestContext.WriteLine("Click into element " + locator + " successfuly");
            }
            catch (Exception ex)
            {
                TestContext.WriteLine("Click into element " + locator + " failed");
                HtmlReport.Fail("Click into element " + locator + " failed", TakeScreenShot());
                throw ex;
            }
        }
        public void SendKeys_(IWebElement e, string key)
        {
            try
            {
                e.SendKeys(key);
                TestContext.WriteLine("Sendkey into element " + e.ToString + " successfuly");
            }
            catch (Exception ex)
            {
                TestContext.WriteLine("Sendkey into element " + e.ToString + " failed");
                throw ex;
            }
        }
        public void SendKeys_(String locator, String key)
        {
            try
            {
                FindElementByXpath(locator).SendKeys(key);
                TestContext.WriteLine("Sendkey into element " + locator + " successfuly");
                HtmlReport.Pass("Sendkey into element " + locator + " successfuly");
            }
            catch (Exception ex)
            {
                TestContext.WriteLine("Sendkey into element " + locator + " failed");
                HtmlReport.Fail("Sendkey into element " + locator + " failed", TakeScreenShot());
                throw ex;
            }
        }
        // action select option
        public void SelectOption(String locator, String key)
        {
            try
            {
                IWebElement mySelectOption = FindElementByXpath(locator);
                SelectElement dropdown = new SelectElement(mySelectOption);
                dropdown.SelectByText(key);
                TestContext.WriteLine("Select element " + locator + " successfuly with " + key);
            }
            catch (Exception ex)
            {
                TestContext.WriteLine("Select element " + locator + " failed with " + key);
                throw ex;
            }
        }
        // action double click
        public void DoubleClick(String locator)
        {
            try
            {
                IWebElement doubleClick = FindElementByXpath(locator);
                WebDriverAction action = new WebDriverAction(driver);
                action.DoubleClick(locator);
                TestContext.WriteLine("Double click on element " + locator + " successfuly");
            }
            catch (Exception ex)
            {
                TestContext.WriteLine("Double click on element " + locator + " failed with");
                throw ex;
            }
        }

        //action get text

        public string GetText(string locator)
        {
            return FindElementByXpath(locator).Text;
        }

        // action get screenshot

        public string TakeScreenShot()
        {
            string path = HtmlReportDirectory.SCREENSHOT_PATH + ("/screenshot_" + DateTime.Now.ToString("yyyyMMddHHmmss")) + ".png";
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
            return path;
            
        }
        
        /*public IWebElement WaitForClickable()
        {
            return WebDriverManager_.GetCurrentDriver().WaitForElementToBeClickable(locator, timeout);
        }*/
        public IWebElement highlightElement(IWebElement element)
        {
                IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
                jse.ExecuteScript("arguments[0].style.border='2px solid red'", element);
                return element;
            }
        }
}


