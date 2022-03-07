
using CoreProject;
using OpenQA.Selenium;
using System;


namespace PageObjects
{
     public class Homepage
    {
        private IWebDriver driver;
        private Browser browser;

        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            browser = new Browser(driver);
        }
    }
}
