using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProj
{
    public class DashboardPage
    {
        private IWebDriver driver;
        private Browser browser;

        private IWebElement PageHeaderText => driver.FindElement(By.TagName("h1"));

        public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;
            browser = new Browser(driver);
        }

        public DashboardPage VerifyPageHeader(string expectedText)
        {
            Assert.AreEqual(expectedText, PageHeaderText.Text);
            return this;
        }

        public string GetPageHeader()
        {
            return PageHeaderText.Text;
        }
    }
}
