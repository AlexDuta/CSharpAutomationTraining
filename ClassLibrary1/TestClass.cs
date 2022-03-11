using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Curs10;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using System.IO;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace ClassLibrary1
{
    [TestFixture]
    class TestClass : TestBase 
    {
        BrowserC7 browser = new BrowserC7();

        [Test]
        public void StartBrowserTrue()
        {
            Assert.IsTrue(browser.StartBrowser());
        }
        [Test]
        public void StartBrowserFalse()
        {
            Assert.IsFalse(!browser.StartBrowser());
        }
        [Test]
        public void GetPageTitleEquals()
        {
            Assert.AreEqual(browser.GetPageTitle(),"Browser is open");
        }
        [Test]
        public void GetPageTitleContains()
        {
            Console.WriteLine("TODO");
        }
        [Test]
        public void GetBrowserWidthEqual()
        {
            Assert.AreEqual(1920, browser.GetBrowserWidth());
        }
        [Test]
        public void GetBrowserWidthLess()
        {
            Assert.Less(1000, browser.GetBrowserWidth());
        }
        [Test]
        public void GetBrowserWidthGreater()
        {
            Assert.Greater(2000, browser.GetBrowserWidth());
        }

        //Curs 10 --Practice--
        [Test]
        public void SleepWait()
        {
            SetUp();
            var wikiLink = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[2]/a"));
            wikiLink.Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("htmlVersion")).SendKeys("Test curs 10");
            TearDown();
        }

        public void WaitElementToBeVisible(IWebDriver driver,By elementBy, int timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(ExpectedConditions.ElementIsVisible(elementBy));
        }
        [Test]
        public void DynamicWait()
        {
            SetUp();
            var wikiLink = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[2]/a"));
            wikiLink.Click();
            WaitElementToBeVisible(driver, By.Id("htmlVersion"), 5);
            driver.FindElement(By.Id("htmlVersion")).SendKeys("Test curs 10");
            TearDown();
        }
        [Test]
        public void ImplicitWait()
        {
            SetUp();
            var wikiLink = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[2]/a"));
            wikiLink.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("htmlVersion")).SendKeys("Test curs 10");
            TearDown();

        }

        [Test]
        public void ValidateH1Text()
        {
            SetUp();
            var wikiLink = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[2]/a"));
            wikiLink.Click();
            IWebElement h1Text = driver.FindElement(By.XPath("/html/body/h1"));
            Assert.IsTrue(h1Text.Displayed && h1Text.Text.Equals("WikiPage"));
            
            TearDown();
        }

        [Test]
        public void ValidateHTMLVersions()
        {
            SetUp();
            var wikiLink = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[2]/a"));
            wikiLink.Click();
            WaitElementToBeVisible(driver, By.Id("htmlversions"), 5);
            SelectElement dropdownList = new SelectElement(driver.FindElement(By.Id("htmlversions")));
            dropdownList.SelectByText("HTML 2.0");
            IWebElement textarea = driver.FindElement(By.Id("htmlVersion"));
            Assert.AreEqual("Current selection: 2", textarea.Text);
        }

        [Test]
        public void ValidateHeaderLinks()
        {
            SetUp();
            var wikiLink = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[2]/a"));
            wikiLink.Click();

            var headerLinks = driver.FindElements(By.XPath("//header//a"));
            foreach (var link in headerLinks)
            {
                 Assert.IsTrue(link.Displayed);
            }

            TearDown();
        }

        [Test]
        public void ValidateFooterLinks()
        {
            SetUp();
            var wikiLink = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[2]/a"));
            wikiLink.Click();

            var footerLinks = driver.FindElements(By.XPath("//footer//a"));
            foreach (var link in footerLinks)
            {
                Assert.IsTrue(link.Displayed);
            }

            TearDown();
        }
    }
}
