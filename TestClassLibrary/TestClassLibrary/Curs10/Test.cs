using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using Utils2;

namespace TestClassLibrary.Curs10
{
    [TestFixture]
    class Test:TestBase
    {
        Browser br = new Browser();

        [Test]
        public void navigateToWikiPageAndFillTextAreExplicit()
        {
            Homepage homepage = new Homepage(driver);
            homepage.NavigateToWikiPage();
            br.ExplicitWaitForElementToBeVisible(driver, By.Id("htmlVersion"), 10);
            driver.FindElement(By.Id("htmlVersion")).SendKeys("test wiki");
            br.ExplicitWaitForElementToBeVisible(driver, By.Id("htmlVersion"), 5);
        }

        [Test]
        public void navigateToWikiPageAndFillTextAreaFluent()
        {
            Homepage homepage = new Homepage(driver);
            homepage.NavigateToWikiPage();
            br.FluentWaitForElement(driver, By.Id("htmlVersion"));
            driver.FindElement(By.Id("htmlVersion")).SendKeys("test wiki");
        }

        [Test]
        public void navigateToWikiPageAndFillTextAreaImplicit()
        {
            Homepage homepage = new Homepage(driver);
            homepage.NavigateToWikiPage();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7); ;
            driver.FindElement(By.Id("htmlVersion")).SendKeys("test wiki");
        
        }

        [Test]
        public void TestWikiLink()
        {
            Homepage homepage = new Homepage(driver);
            homepage.NavigateToWikiPage().VerifyPageHeaderText("WikiPage");
        }

        [Test]
        public void TestDropDownSelection()
        {
            Homepage homepage = new Homepage(driver);
            homepage.NavigateToWikiPage().VerifyAllDropDownValues();
        }

        [Test]
        public void checkHeaderLink()
        {
            Homepage homepage = new Homepage(driver);
            homepage.NavigateToWikiPage().checkHeaderLinks();
        }

        [Test]
        public void checkFooterLink()
        {
            Homepage homepage = new Homepage(driver);
            homepage.NavigateToWikiPage().checkFooterLinks();
        }
    }
}
