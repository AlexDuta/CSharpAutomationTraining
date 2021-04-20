using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace TestClassLibrary.Curs10
{
    [TestFixture]
    class TestCurs10: TestBase
    {
        // public IWebDriver driver;
        HomePage homePage;
        BrowserCurs10 browser;

        [Test]
        public void FillTextIntoTextAreaExplicitWait()
        {
            homePage = new HomePage(driver);
            homePage.NavigateToWikiPage().WaitToLoadExplicit().FillTextAreaField("test wiki");
        }        
        
        [Test]
        public void FillTextIntoTextAreaFluentWait()
        {
            homePage = new HomePage(driver);
            homePage.NavigateToWikiPage().WaitToLoadFluent().FillTextAreaField("test wiki");
        }        
        
        [Test]
        public void FillTextIntoTextAreaImplicitWait()
        {
            homePage = new HomePage(driver);
            homePage.NavigateToWikiPage().WaitToLoadImplicit().FillTextAreaField("test wiki");
  
        }

        [Test]
        public void H1WikiPageIsDisplayed()
        {
            homePage = new HomePage(driver);
            homePage.NavigateToWikiPage().WikiPageH1IsDisplayed();
        }

        [Test]
        public void WikiPageDropDownListVersions()
        {
            homePage = new HomePage(driver);
            browser = new BrowserCurs10(driver);
            homePage.NavigateToWikiPage().HtmlVersionDropDownList();
            browser.ExplicitWaitForElementToBeDisplayed(driver, By.Id("htmlversions"), 5);
        }

        [Test]
        public void HeaderAndFooterDisplayedLinkSTest()
        {
            homePage = new HomePage(driver);
            homePage.NavigateToWikiPage().CheckHeaderAndFooterLinks();
        }

    }
}
