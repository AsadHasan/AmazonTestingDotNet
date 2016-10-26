using AmazonTesting.BrowserFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonTesting.PageObjects
{
    class Homepage:BasePage
    {
        private SelectElement select;
        private Browser browser;

       [FindsBy(How = How.Id, Using = "searchDropdownBox")]
        private IWebElement searchDropdownBox;

       [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        private IWebElement searchTextBox;

       [FindsBy(How = How.Id, Using = "nav-search-submit-text")]
        private IWebElement searchSubmitButton;

       [FindsBy(How = How.Id, Using = "nav-link-yourAccount")]
        private IWebElement yourAccount;

       [FindsBy(How = How.Id, Using = "nav-link-shopall")]
        private IWebElement departmentsDropdown;

    public Homepage(IWebDriver driver)
        :base(driver)
    { 
        PageFactory.InitElements(driver,this);
    }
    public Homepage navigateToHomepage(){
            browser.getDriver("chrome")
                    .get("https://www.amazon.com/");
            return this;
        }

    public Homepage searchForItem(String text)
    {
        searchTextBox.SendKeys("text");
        return this;
    }

    public Homepage autoComplete()
    {
        searchTextBox.SendKeys(Keys.ArrowDown);
        searchTextBox.SendKeys(Keys.Enter);
        return this;
    }

    public Homepage selectSearchCategory(String suggestions)
    {
        select = new SelectElement(searchDropdownBox);
        select.SelectByText(suggestions);
        return this;
    }

    public Homepage selectDepartmentOptions(String term)
    {
        select = new SelectElement(departmentsDropdown);
        select.SelectByText(term);
        return this;
    }

    public Homepage submitSearch()
    {
        browser.getWait().Until(ExpectedConditions.ElementToBeClickable(searchSubmitButton));
        browser.getActions().MoveToElement(searchSubmitButton).Click().Build().Perform();
        return this;
    }
    }
}
