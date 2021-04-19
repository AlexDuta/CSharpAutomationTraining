using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Utils2;

namespace TestClassLibrary.Curs10
{
    class WikiPage
    {
        private IWebDriver driver;
        private Browser browser;
      

        //elemente
        private IWebElement textArea { get { return driver.FindElement(By.Id("htmlVersion")); } }
        private IWebElement PageHeader { get { return driver.FindElement(By.TagName("h1")); } }

        private By selectDropDownBy = By.Id("htmlversions");
        private IWebElement selectDropDown { get { return driver.FindElement(selectDropDownBy); }}
        private IWebElement selectValue1 { get { return driver.FindElement(By.XPath("//*[@id='htmlversions']/option[2]")); } }
        private IWebElement selectValue2 { get { return driver.FindElement(By.XPath("//*[@id='htmlversions']/option[3]")); } }
        private IWebElement selectValue3 { get { return driver.FindElement(By.XPath("//*[@id='htmlversions']/option[4]")); } }
        private IWebElement selectValue4 { get { return driver.FindElement(By.XPath("//*[@id='htmlversions']/option[5]")); } }

        private IWebElement headerHomePage { get { return driver.FindElement(By.XPath("//*[@id='navHeader']/a[1]")); } }
        private IWebElement headerHWikiPage { get { return driver.FindElement(By.XPath("//*[@id='navHeader']/a[2]")); } }
        private IWebElement footerHomePage { get { return driver.FindElement(By.XPath("//*[@id='nav']/li[1]/a")); } }
        private IWebElement footerWikiPage { get { return driver.FindElement(By.XPath("//*[@id='nav']/li[2]/a")); } }
        private IWebElement footerContactPage { get { return driver.FindElement(By.XPath("//*[@id='nav']/li[3]/a")); } }



        //constructor
        public WikiPage(IWebDriver driver)
        {
            this.driver = driver;
            browser = new Browser();
            
        }

        //metode
        public WikiPage VerifyPageHeaderText(string expectedText)
        {
            Assert.AreEqual(expectedText, PageHeader.Text);
            return this;
        }

        public WikiPage VerifyAllDropDownValues()
        {
            browser.ExplicitWaitForElementToBeVisible(driver, selectDropDownBy, 10);
            SelectElement selectElement = new SelectElement(selectDropDown);
            selectElement.SelectByText("HTML 2.0");
            Assert.IsTrue(selectValue1.Text.Equals("HTML 2.0"));
            selectElement.SelectByText("HTML 3.2");
            Assert.IsTrue(selectValue2.Text.Equals("HTML 3.2"));
            selectElement.SelectByText("HTML 4.0");
            Assert.IsTrue(selectValue3.Text.Equals("HTML 4.0"));
            selectElement.SelectByText("HTML 5");
            Assert.IsTrue(selectValue4.Text.Equals("HTML 5"));
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
    }
}
