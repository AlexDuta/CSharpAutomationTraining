using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utils;

namespace TestClassLibrary.Curs10
{
    [TestFixture]
    public class TestCurs10 : TestBase
    {
        BrowserCurs10 br = new BrowserCurs10();
        private IWebElement wikiText { get { return driver.FindElement(By.Id("htmlVersion")); } }
        [Test]
        public void navigateToWikiExplicitWait()
        {
            driver.FindElement(By.XPath("//*[@id='navHeader']/a[2]")).Click();
            var wikiTextArea = driver.FindElement(By.Id("htmlVersion"));
            br.explicitWait(driver, By.Id("htmlVersion"), 5);
            wikiTextArea.SendKeys("Text de test with explicit. ");
        }

        [Test]
        public void navigateToWikiImplicitWait()
        {
            driver.FindElement(By.XPath("//*[@id='navHeader']/a[2]")).Click();
            var wikiTextArea = driver.FindElement(By.Id("htmlVersion"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            wikiTextArea.SendKeys("Text de test with implicit.");
        }


        [Test]
        public void navigateToWikiFluentWait()
        {
            driver.FindElement(By.XPath("//*[@id='navHeader']/a[2]")).Click();
            var wikiTextArea = driver.FindElement(By.Id("htmlVersion"));
            br.fluentWait(driver, By.Id("htmlVersion"));
            wikiTextArea.SendKeys("Text de test with fluent.");
        }

        [Test]
        public void checkWikiPageH1Text()
        {
            driver.FindElement(By.XPath("//*[@id='navHeader']/a[2]")).Click();
            var wikiH1Text = driver.FindElement(By.TagName("h1"));
            Assert.IsTrue(wikiH1Text.Displayed);
            Assert.IsTrue(wikiH1Text.Text.Equals("WikiPage"));
        }

        [Test]
        public void checkHtmlVersionValues()
        {
            driver.FindElement(By.XPath("//*[@id='navHeader']/a[2]")).Click();
            var dropDown = driver.FindElement(By.Id("htmlversions"));
            br.explicitWait(driver, By.Id("htmlversions"), 5);
            SelectElement selectElement = new SelectElement(dropDown);
            
            selectElement.SelectByValue("2");
            Assert.IsTrue(wikiText.Text.Equals("Current selection: 2"));
            
            selectElement.SelectByValue("3.2");
            Assert.IsTrue(wikiText.Text.Equals("Current selection: 3.2"));

            selectElement.SelectByValue("4.0");
            Assert.IsTrue(wikiText.Text.Equals("Current selection: 4.0"));

            selectElement.SelectByValue("5");
            Assert.IsTrue(wikiText.Text.Equals("Current selection: 5"));
        }

        [Test]
        public void checkHeaderLinks()
        {
            driver.FindElement(By.XPath("//*[@id='navHeader']/a[2]")).Click();
            var header = driver.FindElement(By.Id("navHeader"));
            var links = header.FindElements(By.TagName("a"));

            foreach(var e in links)
            {
                Assert.IsTrue(e.Displayed);
            }
        }

        [Test]
        public void checkFooterLinks()
        {
            driver.FindElement(By.XPath("//*[@id='navHeader']/a[2]")).Click();
            var header = driver.FindElement(By.Id("nav"));
            var links = header.FindElements(By.TagName("a"));

            foreach (var e in links)
            {
                Assert.IsTrue(e.Displayed);
            }
        }
    }
}
