using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Utils;

namespace TestClassLibrary.Curs10
{
    class WikiPage
    {
        private IWebDriver driver;
        private Browser browser;

        private By textAreaBy = By.Id("htmlVersion");
        private IWebElement pageHeader { get { return driver.FindElement(By.TagName("h1")); } }
        private IWebElement textAreaWikiPage { get { return driver.FindElement(textAreaBy); } }

        private By selectDropDownBy = By.Id("htmlversions");
        private IWebElement selectDropDownButton { get { return driver.FindElement(selectDropDownBy); } }
        private IWebElement selectFirstValue { get { return driver.FindElement(By.XPath("//*[@id='htmlversions']/option[2]")); } }
        private IWebElement selectSecondValue { get { return driver.FindElement(By.XPath("//*[@id='htmlversions']/option[3]")); } }
        private IWebElement selectThirdValue { get { return driver.FindElement(By.XPath("//*[@id='htmlversions']/option[4]")); } }
        private IWebElement selectFourthValue { get { return driver.FindElement(By.XPath("//*[@id='htmlversions']/option[5]")); } }

        private IWebElement headerHomePage { get { return driver.FindElement(By.XPath("//*[@id='navHeader']/a[1]")); } }
        private IWebElement headerHWikiPage { get { return driver.FindElement(By.XPath("//*[@id='navHeader']/a[2]")); } }
        private IWebElement footerHomePage { get { return driver.FindElement(By.XPath("//*[@id='nav']/li[1]/a")); } }
        private IWebElement footerWikiPage { get { return driver.FindElement(By.XPath("//*[@id='nav']/li[2]/a")); } }
        private IWebElement footerContactPage { get { return driver.FindElement(By.XPath("//*[@id='nav']/li[3]/a")); } }

        public WikiPage(IWebDriver driver)
        {
            this.driver = driver;
            browser = new Browser();
        }

        public WikiPage VerifyPageHeaderText(string expectedText)
        {
            Assert.AreEqual(expectedText, pageHeader.Text);
            return this;
        }
       

        public WikiPage CheckDropDownValues()
        {
            browser.WaitElementToBeVisibleExplicit(driver, selectDropDownBy, 10);
            SelectElement selectElement = new SelectElement(selectDropDownButton);
            selectElement.SelectByText("HTML 2.0");
            Assert.IsTrue(selectFirstValue.Text.Equals("HTML 2.0"));
            selectElement.SelectByText("HTML 3.2");
            Assert.IsTrue(selectSecondValue.Text.Equals("HTML 3.2"));
            selectElement.SelectByText("HTML 4.0");
            Assert.IsTrue(selectThirdValue.Text.Equals("HTML 4.0"));
            selectElement.SelectByText("HTML 5");
            Assert.IsTrue(selectFourthValue.Text.Equals("HTML 5"));
            return this;
        }

        public WikiPage checkHeaderLinks()
        {
            Assert.IsTrue(headerHomePage.Displayed);
            Assert.IsTrue(headerHWikiPage.Displayed);
            return this;
        }

        public WikiPage checkFooterLinks()
        {
            Assert.IsTrue(footerHomePage.Displayed);
            Assert.IsTrue(footerWikiPage.Displayed);
            Assert.IsTrue(footerContactPage.Displayed);
            return this;
        }

        public WikiPage explicitPageToLoadt()
        {
            browser.WaitElementToBeVisibleExplicit(driver, textAreaBy, 10);
            return this;
        }

        public WikiPage fluentPageToLoad()
        {
            browser.WaitElementToBeVisibleFluent(driver, textAreaBy);
            return this;
        }

        public WikiPage implicitPageToLoad()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return this;
        }

        public WikiPage insertText(string text)
        {
            textAreaWikiPage.SendKeys(text);
            return this;
        }
    }
}
