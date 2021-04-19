using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace TestClassLibrary.Curs10
{
    class WikiPage
    {
        private IWebDriver driver;
        private BrowserCurs10 browser;


        private By WikiFillBy = By.Id("htmlVersion");
        private IWebElement WikiFill { get { return driver.FindElement(By.Id("htmlVersion")); } }

        public WikiPage(IWebDriver driver)
        {
            this.driver = driver;
            this.browser = new BrowserCurs10(driver);
        }

        public WikiPage FillTextAreaField(String input)
        {
            WikiFill.SendKeys(input);
            return this;
        }

        public WikiPage WaitToLoadExplicit()
        {
            browser.ExplicitWaitForElementToBeDisplayed(driver, WikiFillBy, 10);
            return this;
        }

        public WikiPage WaitToLoadFluent()
        {
            browser.FluentWaitForElementToBeDisplayed(driver, WikiFillBy);
            return this;
        }        
        
        public WikiPage WaitToLoadImplicit()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return this;
        }
    }
}
