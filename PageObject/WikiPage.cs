using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClassLibrary1.Curs10;

namespace PageObject
{
    public class WikiPage
    {
        private IWebDriver driver;
        private IWebElement wikilink { get { return driver.FindElement(By.XPath("//a[@href='wikipage.html']")); } }
        private By bywikititle { get { return By.TagName("h1"); } }
        private IWebElement wikititle { get { return driver.FindElement(bywikititle); } }
        private IWebElement textField { get { return driver.FindElement(By.Id("htmlVersion")); } }
        private By byHtmlSelector { get { return By.Id("htmlversions"); } }
        private IWebElement link1 { get { return driver.FindElement(By.XPath("//ul/a[@href = 'homepage.html']")); } }
        private IWebElement link2 { get { return driver.FindElement(By.XPath("//ul/a[@href = 'wikipage.html']")); } }
        private IWebElement footerLink1 {get {return driver.FindElement(By.XPath("//*[@id='nav']/li[1]/a"));} }
        private IWebElement footerLink2 { get { return driver.FindElement(By.XPath("//*[@id='nav']/li[2]/a")); } }
        private IWebElement footerLink3 { get { return driver.FindElement(By.XPath("//*[@id='nav']/li[3]/a")); } }
        public WikiPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public WikiPage clickOnWikiLink()
        {
            wikilink.Click();
            return this;
        }
        public WikiPage verifyWikiPageTitle(String title)
        {
            Assert.AreEqual(title, wikilink.Text);
            return this;
        }
        public WikiPage verifyHtmlVersion()
        {
            SelectElement HtmlSelector = new SelectElement(driver.FindElement(byHtmlSelector));
            HtmlSelector.SelectByValue("2");
            Assert.AreEqual("Current selection: 2", textField.Text);
            return this;
        }
        public WikiPage verifyPageHeader()
        {
            Assert.IsTrue(link1.Displayed);
            Assert.IsTrue(link2.Displayed);
            return this;
        }
        public WikiPage verifyPageFooter()
        {
            Assert.IsTrue(footerLink1.Displayed);
            Assert.IsTrue(footerLink2.Displayed);
            Assert.IsTrue(footerLink3.Displayed);
            return this;
        }
    
    }
}
