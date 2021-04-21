using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using TestClassLibrary1.Curs10;
using NUnit.Framework;
using PageObject;
using OpenQA.Selenium;

namespace Tests
{
    public class WikiPageTests:TestBaseCurs10
    {
        BrowserCurs10 browser = new BrowserCurs10();

        [Test]
        public void verifyWikiPageTitle()
        {
            WikiPage wikiPage = new WikiPage(driver);
            wikiPage.clickOnWikiLink();
            browser.ExplicitWaitForElementToBeVisible(driver, By.TagName("h1"));
            wikiPage.verifyWikiPageTitle("WikiPage");
        }

        [Test]
        public void verifyWikiHeader()
        {
            WikiPage wikiPage = new WikiPage(driver);
            wikiPage.clickOnWikiLink();
            browser.ExplicitWaitForElementToBeVisible(driver, By.XPath("//ul/a[@href = 'homepage.html']"));
            wikiPage.verifyPageHeader();
        }
        [Test]
        public void verifyWikiFooter()
        {
            WikiPage wikiPage = new WikiPage(driver);
            wikiPage.clickOnWikiLink();
            browser.ExplicitWaitForElementToBeVisible(driver, By.XPath("//*[@id='nav']/li[1]/a"));
            wikiPage.verifyPageFooter();    
        }
        [Test]
        public void verifyHtmlVersion()
        {
            WikiPage wikiPage = new WikiPage(driver);
            wikiPage.clickOnWikiLink();
            browser.ExplicitWaitForElementToBeVisible(driver, By.Id("htmlversions"));
            wikiPage.verifyHtmlVersion();
        }
    }
}
