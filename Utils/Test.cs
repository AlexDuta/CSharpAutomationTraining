using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClassLibrary1.Curs10;

namespace Utils
{
    class Test : TestBaseCurs10
    {
        [Test]
        public void verifyWikiPageTitle()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var wikilink = driver.FindElement(By.XPath("//a[@href='wikipage.html']"));
            By bywikititle = By.TagName("h1");
            var wikititle = driver.FindElement(bywikititle);
            wikilink.Click();
            var waitCondition = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(bywikititle));
            Assert.AreEqual("WikiPage", wikititle.Text);
        }
        [Test]
        public void verifyHtmlVersion()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var wikilink = driver.FindElement(By.XPath("//a[@href='wikipage.html']"));
            wikilink.Click();
            var textField = driver.FindElement(By.Id("htmlVersion"));
            By byHtmlSelector = By.Id("htmlversions");
            var waitCondition = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(byHtmlSelector));
            SelectElement HtmlSelector = new SelectElement(driver.FindElement(byHtmlSelector));
            HtmlSelector.SelectByValue("2");
            Assert.AreEqual("Current selection: 2", textField.Text);
        }

        [Test]
        public void verifyHeaderLink()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var wikilink = driver.FindElement(By.XPath("//a[@href='wikipage.html']"));
            wikilink.Click();
            var waitCondition = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//ul/a[@href = 'homepage.html']")));
            var link1 = driver.FindElement(By.XPath("//ul/a[@href = 'homepage.html']"));
            var link2 = driver.FindElement(By.XPath("//ul/a[@href = 'wikipage.html']"));
            Assert.IsTrue(link1.Displayed);
            Assert.IsTrue(link2.Displayed);
        }
        [Test]
        public void verifyFooterLinks()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var wikilink = driver.FindElement(By.XPath("//a[@href='wikipage.html']"));
            wikilink.Click();
            var waitCondition = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='nav']/li[1]/a")));
            var link1 = driver.FindElement(By.XPath("//*[@id='nav']/li[1]/a"));
            var link2 = driver.FindElement(By.XPath("//*[@id='nav']/li[2]/a"));
            var link3 = driver.FindElement(By.XPath("//*[@id='nav']/li[3]/a"));
            Assert.IsTrue(link1.Displayed);
            Assert.IsTrue(link2.Displayed);
            Assert.IsTrue(link3.Displayed);
        }
    }
}
