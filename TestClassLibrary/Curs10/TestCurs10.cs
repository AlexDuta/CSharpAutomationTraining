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
        private IWebElement wikiTextArea { get { return driver.FindElement(By.Id("htmlVersion")); } }
        private IWebElement wikiButton { get { return driver.FindElement(By.XPath("//*[@id='navHeader']/a[2]")); } }
        private IWebElement wikiH1Text { get { return driver.FindElement(By.TagName("h1")); } }
        private IWebElement wikiHtmlVersions { get { return driver.FindElement(By.Id("htmlversions")); } }


        [Test]
        public void navigateToWikiExplicitWait()
        {
            wikiButton.Click();
            br.explicitWait(driver, By.Id("htmlVersion"), 5);
            wikiTextArea.SendKeys("Text de test with explicit. ");
        }

        [Test]
        public void navigateToWikiImplicitWait()
        {
            wikiButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            wikiTextArea.SendKeys("Text de test with implicit.");
        }


        [Test]
        public void navigateToWikiFluentWait()
        {
            wikiButton.Click();
            br.fluentWait(driver, By.Id("htmlVersion"));
            wikiTextArea.SendKeys("Text de test with fluent.");
        }

        [Test]
        public void checkWikiPageH1Text()
        {
            wikiButton.Click();
            Assert.IsTrue(wikiH1Text.Displayed);
            Assert.IsTrue(wikiH1Text.Text.Equals("WikiPage"));
        }

        [Test]
        public void checkHtmlVersionValues()
        {
            wikiButton.Click();
            br.explicitWait(driver, By.Id("htmlversions"), 5);
            SelectElement selectElement = new SelectElement(wikiHtmlVersions);
            
            selectElement.SelectByValue("2");
            Assert.IsTrue(wikiTextArea.Text.Equals("Current selection: 2"));
            
            selectElement.SelectByValue("3.2");
            Assert.IsTrue(wikiTextArea.Text.Equals("Current selection: 3.2"));

            selectElement.SelectByValue("4.0");
            Assert.IsTrue(wikiTextArea.Text.Equals("Current selection: 4.0"));

            selectElement.SelectByValue("5");
            Assert.IsTrue(wikiTextArea.Text.Equals("Current selection: 5"));
        }

        [Test]
        public void checkHeaderLinks()
        {
            wikiButton.Click();

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
            wikiButton.Click(); 

            var header = driver.FindElement(By.Id("nav"));
            var links = header.FindElements(By.TagName("a"));

            foreach (var e in links)
            {
                Assert.IsTrue(e.Displayed);
            }
        }
    }
}
