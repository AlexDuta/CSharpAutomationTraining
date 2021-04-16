using ClassLibrary3;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProj
{
    public class Dashboardpage
    {
        private IWebDriver driver;
        private Browser browser;

        private IWebElement PageHeader { get { return driver.FindElement(By.TagName("h1")); } }

        public Dashboardpage(IWebDriver driver)
        {
            this.driver = driver;
            browser = new Browser(driver);
        }

        public string GetPageHeaderText()
        {
            return PageHeader.Text;
        }

        public Dashboardpage VerifyPageHeader(string expectedText)
        {
            Assert.AreEqual(expectedText, PageHeader.Text);
            return this;
        }
    }
}
