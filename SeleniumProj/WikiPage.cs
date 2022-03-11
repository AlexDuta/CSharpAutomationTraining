using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProj
{
    public class WikiPage
    {
        private IWebDriver driver;
        private Browser browser;

        private IWebElement PageHeaderText => driver.FindElement(By.TagName("h1"));
        private IWebElement TextAreaInput => driver.FindElement(By.Id("htmlVersion"));

        public WikiPage(IWebDriver driver)
        {
            this.driver = driver;
            browser = new Browser(driver);
        }

        public WikiPage ChechTextAreaIsDisplayed()
        {
            browser.WaitElementToBeDisplayed(driver, TextAreaInput, 5);
            Assert.AreEqual(true, TextAreaInput.Displayed);
            return this;
        }


    }

}
