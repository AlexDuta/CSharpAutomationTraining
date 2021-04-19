using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestClassLibrary.Curs7;

namespace TestClassLibrary
{
    [TestFixture]
    public class Test : TestBase
    {
        Browser br = new Browser();
        [Test]
        public void TestBrowserTrue()
        {
            Assert.IsTrue(br.StartBrowser());
        }
        
        [Test]
        public void TestBrowserFalse()
        {
            Assert.IsFalse(br.StartBrowser());
        }
        [Test]
        public void GetPageTitleEqual()
        {
            Assert.AreEqual("Browser is open!", br.GetPageTitle());
        }

        [Test]
        public void GetPageTitleContains()
        {
            string temp = br.GetPageTitle();
            Assert.IsTrue(temp.Contains("open"));
        }

        //[Test]
        //public void GetPageTitleContains()
        //{
        //    Assert.Contains("open", br.GetPageTitle());
        //}

        [Test]
        public void GetBrowserWidthEqual()
        {
            Assert.AreEqual(50, br.GetBrowserWidth());
        }

        [Test]
        public void GetBrowserWidthLess()
        {
            Assert.Less(40, br.GetBrowserWidth());
        }

        [Test]
        public void GetBrowserWidthGreater()
        {
            Assert.Greater(60, br.GetBrowserWidth());
        }

                            //Curs 8


        [Test]
        public void checkPageTitle()
        {
            Assert.IsTrue(driver.Title.Equals("Home page"));
        }

        [Test]
        public void checkEmailInputDisplayed()
        {
            Assert.IsTrue(driver.FindElement(By.Id("email")).Displayed);
        }

        [Test]
        public void checkPasswordInputDisplayed()
        {
            Assert.IsTrue(driver.FindElement(By.Id("password")).Displayed);
        }

        [Test]
        public void loginButtonDisplayed()
        {
            Assert.IsTrue(driver.FindElement(By.Id("Login")).Displayed);
        }

        [Test]
        public void findLinks()
        {
            var elements = driver.FindElements(By.TagName("a"));
            
            foreach(var e in elements)
            {
                Assert.IsTrue(e.Displayed);
            }
        }


                                //Curs9
        
        [Test]
        public void checkEmailAndPasswordErrorMessage()
        {

            driver.FindElement(By.Id("Login")).Click();
            Assert.IsTrue(driver.FindElement(By.Id("emailErrorText")).Displayed);
            Assert.IsTrue(driver.FindElement(By.Id("passwordErrorText")).Displayed);

            driver.Navigate().Refresh();

            Assert.IsFalse(driver.FindElement(By.Id("emailErrorText")).Displayed);
            Assert.IsFalse(driver.FindElement(By.Id("passwordErrorText")).Displayed);
        }

        [Test]
        public void checkHeaderLinks()
        {
            var element = driver.FindElement(By.Id("navHeader"));
            var links = element.FindElements(By.XPath(".//a[contains(@href, 'long')]"));
            foreach (var e in links)
            {
                Assert.IsTrue(e.Displayed);
            }
        }

        [Test]
        public void checkFooterLinks()
        {
            var element = driver.FindElement(By.Id("nav"));
            var links = element.FindElements(By.XPath(".//a[contains(@href, 'long')]"));
            foreach (var e in links)
            {
                Assert.IsTrue(e.Displayed);
            }
        }
    }
}
