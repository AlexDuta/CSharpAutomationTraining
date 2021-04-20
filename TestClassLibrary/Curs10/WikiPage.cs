using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        IWebDriver driver;
        BrowserCurs10 browser;


        private By WikiFillBy = By.Id("htmlVersion");
        private By WikiHtmlVersionsBy = By.Id("htmlversions");
        private IWebElement WikiFill { get { return driver.FindElement(By.Id("htmlVersion")); } }

        private IWebElement WikiPageH1 { get { return driver.FindElement(By.XPath("/html/body/h1")); } }

        private IWebElement WikiHtmlVersions { get { return driver.FindElement(WikiHtmlVersionsBy); } }

        private IWebElement HtmlVersion1 { get { return driver.FindElement(By.XPath("//*[@id='htmlversions']/option[1]")); } }
        private IWebElement HtmlVersion2 { get { return driver.FindElement(By.XPath("//*[@id='htmlversions']/option[2]]")); } }
        private IWebElement HtmlVersion3 { get { return driver.FindElement(By.XPath("//*[@id='htmlversions']/option[3]")); } }
        private IWebElement HtmlVersion4 { get { return driver.FindElement(By.XPath("//*[@id='htmlversions']/option[4]")); } }
        private IWebElement HtmlVersion5 { get { return driver.FindElement(By.XPath("//*[@id='htmlversions']/option[5]")); } }
        private IWebElement Header {  get { return driver.FindElement(By.Id("navHeader")); } }
        private IWebElement Footer {  get { return driver.FindElement(By.Id("nav")); } }
        

        public WikiPage(IWebDriver driver)
        {
            this.driver = driver;
            browser = new BrowserCurs10(driver);
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

        public WikiPage WikiPageH1IsDisplayed()
        {
            Assert.IsTrue(WikiPageH1.Displayed);
            Assert.IsTrue(WikiPageH1.Text.Equals("WikiPage"));
            return this;
        }

        public WikiPage HtmlVersionDropDownList()
        {
            browser.ExplicitWaitForElementToBeDisplayed(driver, WikiHtmlVersionsBy, 10);
            var selectElement = new SelectElement(WikiHtmlVersions);
            selectElement.SelectByValue("no value");
            Console.WriteLine(HtmlVersion1.Text);
            Assert.IsTrue(HtmlVersion1.Text.Equals("Please select"));
            selectElement.SelectByValue("2");
            Assert.IsTrue(HtmlVersion2.Text.Equals("HTML 2.0"));
            selectElement.SelectByValue("3.2");
            Assert.IsTrue(HtmlVersion3.Text.Equals("HTML 3.2"));
            selectElement.SelectByValue("4.0");
            Assert.IsTrue(HtmlVersion4.Text.Equals("HTML 4.0"));
            selectElement.SelectByValue("5");
            Assert.IsTrue(HtmlVersion5.Text.Equals("HTML 5"));
            return this;
        }

        public WikiPage CheckHeaderAndFooterLinks()
        {
            var linksHeader = Header.FindElements(By.XPath(".//*[contains(@href, 'html')]"));
            var linksFooter = Footer.FindElements(By.XPath(".//*[contains(@href, 'html') or contains(@href,'#')]"));
            foreach (var element in linksHeader)
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine(element.Text + element.GetAttribute("html"));
            }
            foreach (var element in linksFooter)
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine(element.Text + element.GetAttribute("html"));
            }
            return this;
        }
    }
}
