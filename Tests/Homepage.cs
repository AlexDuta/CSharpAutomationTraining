using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Tests
{
    class Homepage
    {
        private IWebDriver driver;
        private PageObject pageObject;

        private IWebElement emailInput => driver.FindElement(By.Id("email"));
        private IWebElement passwordInput => driver.FindElement(By.Id("password"));
        private IWebElement loginBtn => driver.FindElement(By.Id("login"));
        private IWebElement wikiLink => driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[2]/a"));

        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            this.pageObject = new PageObject(driver);
        }
        public Homepage FillInLoginCredentials(string email, string password)
        {
            pageObject.SendKeys(emailInput, email);
            pageObject.SendKeys(passwordInput, password);
            return this;
        }
        public Dashboardpage ClickLoginBtn()
        {
            loginBtn.Click();
            return new Dashboardpage(driver);
        }
        public Wikipage ClickWikiLink()
        {
            wikiLink.Click();
            return new Wikipage(driver);
        }
    }
}
