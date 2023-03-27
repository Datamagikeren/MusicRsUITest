namespace MusicRsUITest
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Edge;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.IE;
    using OpenQA.Selenium.Support.UI;
    using System;

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

        string url = "http://127.0.0.1:5500/JavaScript/index.html";
        [TestMethod]
        public void TestTitle()
        {
            //string url = "file:///C:/andersb/javascript/sayhelloVue3/index.htm";
            //string url = "https://anbo-sayhello.azurewebsites.net/";
            //string url = "http://localhost:5502/index.htm";
            _driver.Navigate().GoToUrl(url);

            Assert.AreEqual("DDKRREST", _driver.Title);


        }
    }
    }