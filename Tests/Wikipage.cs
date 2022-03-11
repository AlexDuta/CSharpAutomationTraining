using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Tests
{
    class Wikipage
    {
        private IWebDriver driver;
        private PageObject pageObject;
        private SelectElement dropdownList;

        private IWebElement PageHeaderText => driver.FindElement(By.TagName("h1"));
        private IWebElement TextAreaField => driver.FindElement(By.Id("htmlVersion"));


        public Wikipage(IWebDriver driver)
        {
            this.driver = driver;
            this.pageObject = new PageObject(driver);
            
        }
        public Wikipage CheckTextAreaIsDisplayed()
        {
            pageObject.WaitElementToBeDisplayed(driver, TextAreaField, 5);
            Assert.AreEqual(true, TextAreaField.Displayed);
            return this;
        }
        public Wikipage CheckAndFill(string value)
        {
            CheckTextAreaIsDisplayed();
            TextAreaField.SendKeys(value);
            return this;
        }
        public Wikipage CheckHeader()
        {
            pageObject.WaitElementToBeDisplayed(driver, PageHeaderText, 5);
            Assert.IsTrue(PageHeaderText.Text.Equals("WikiPage") && PageHeaderText.Displayed);
            return this;
        }
        public Wikipage CheckDropdownDisplayed(string text1, string text2)
        {
            pageObject.WaitElementToBeDisplayed(driver, TextAreaField, 5);
            this.dropdownList = new SelectElement(driver.FindElement(By.Id("htmlversions")));
            dropdownList.SelectByText(text1);
            Assert.AreEqual(text2, TextAreaField.Text);
            return this;
        }
        public Wikipage CheckHeaderLinks()
        {
            var headerLinks = driver.FindElements(By.XPath("//header//a"));
            foreach (var link in headerLinks)
            {
                Assert.IsTrue(link.Displayed);
            }
            return this;
        }
        public Wikipage CheckFooterLinks()
        {
            var footerLinks = driver.FindElements(By.XPath("//footer//a"));
            foreach (var link in footerLinks)
            {
                Assert.IsTrue(link.Displayed);
            }
            return this;
        }
    }
}
