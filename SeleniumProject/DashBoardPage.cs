using CoreProject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
     class DashBoardPage
    {
        private IWebDriver driver;
        private Browser browser;

        private IWebElement PageHeaderText => driver.FindElement(By.TagName("h1"));
        public DashBoardPage(IWebDriver driver)
        {
            this.driver = driver;
            browser = new Browser(driver);
        }

        public DashBoardPage VerifyPageHeader(string expectedText)
        {
            //assert aici sau in clasa de test
            Assert.AreEqual(expectedText, PageHeaderText.Text);
            return this;
        }

        public string GetPageHeader()
        {
            return PageHeaderText.Text;
        }
    }
}
