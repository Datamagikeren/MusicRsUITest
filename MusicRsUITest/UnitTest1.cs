namespace MusicRsUITest
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Edge;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium.Support.UI;

    [TestClass]
    public class UnitTest1
    {
        private static readonly string DriverDirectory = "C:\\webDrivers";
        // Download drivers to your driver folder.
        // Driver version must match your browser version.
        // http://chromedriver.chromium.org/downloads

        private static IWebDriver _driver;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            //_driver = new ChromeDriver(DriverDirectory); // fast
            //_driver = new FirefoxDriver(DriverDirectory);  // slow
            _driver = new EdgeDriver(DriverDirectory); //  fast
                                                       // driver file must be renamed to MicrosoftWebDriver.exe
        }

        [ClassCleanup]
        public static void TearDown()
        {
            _driver.Dispose();
        }

        string url = "http://127.0.0.1:5500/index.html";
       
        [TestMethod]
        public void TestTitle()
        {
            _driver.Navigate().GoToUrl(url);

            Assert.AreEqual("DKRREST", _driver.Title);
        }

        [TestMethod]
        public void TestIndex1()
        {
            _driver.Navigate().GoToUrl(url);

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement tableMusic = wait.Until(d => d.FindElement(By.Id("table")));
            Assert.IsTrue(tableMusic.Text.Contains("Mamma Mia"));
        }
    }
}