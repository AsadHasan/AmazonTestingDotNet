using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonTesting.BrowserFactory
{
    class Browser
    {
        protected IWebDriver driver;

        protected WebDriverWait wait;

        protected Actions actions;

        private static Dictionary<String, IWebDriver> drivers = new Dictionary<string, IWebDriver>();
            public IWebDriver getDriver(String browserName) {
            IWebDriver driver = null;

                switch (browserName) {
                    case "chrome":
                        if (driver == null) {
                            driver = new ChromeDriver(@"C:\PathTo\IEDriverServer");
                        drivers.Add("chrome", driver);
                        }
                        break;
                    case "phantom":
                        if (driver == null) {
                            driver = new PhantomJSDriver(@"C:\PathTo\IEDriverServer");
                        drivers.Add("phantom", driver);
                        }
                        break;
                    case "htmlunit":
                        if (driver == null) {
                            driver = new HtmlUnitDriver();
                        drivers.Add("htmlunit", driver);
                        }
                        break;
                }
                return driver;
            }
      
        public WebDriverWait getWait()
        {
            wait = new WebDriverWait(driver, 60);
            return wait;
        }

        public Actions getActions()
        {
            actions = new Actions(driver);
            return actions;
        }

        public String pageTitle()
        {
            return driver.Title;
        }

        public Browser maximise()
        {
            driver.Manage().Window.Maximize();
            return this;
        }
    }
}
