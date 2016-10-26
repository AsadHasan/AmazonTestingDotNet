using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonTesting.PageObjects
{
    class BasePage
    {
        protected IWebDriver driver;

        [FindsBy(How = How.Id, Using = "navbar")]
        private IWebElement header;

         [FindsBy(How =How.Id,Using ="navFooter")]
        private IWebElement footer;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        // public WebDriver

        public IWebElement getHeader()
        {
            return header;
        }

        public IWebElement getFooter()
        {
            return footer;
        }
    }
}
