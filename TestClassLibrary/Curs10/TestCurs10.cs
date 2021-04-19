using NUnit.Framework;
using OpenQA.Selenium;
using System;

using Utils;

namespace TestClassLibrary.Curs10
{
    [TestFixture]
    public class TestCurs10 : TestBase
    {
        BrowserCurs10 br = new BrowserCurs10();

        [Test]
        public void navigateToWikiExplicitWait()
        {
            WikiPage wikiPage = new WikiPage(driver);
            wikiPage.clickOnWikiButton();
            br.explicitWait(driver, By.Id("htmlVersion"), 5);
            wikiPage.writeTextInTextArea("Test text explicit wait! ");
        }

        [Test]
        public void navigateToWikiImplicitWait()
        {
            WikiPage wikiPage = new WikiPage(driver);
            wikiPage.clickOnWikiButton();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            wikiPage.writeTextInTextArea("Test text implicit wait! ");
        }


        [Test]
        public void navigateToWikiFluentWait()
        {
            WikiPage wikiPage = new WikiPage(driver);
            wikiPage.clickOnWikiButton();
            br.fluentWait(driver, By.Id("htmlVersion"));
            wikiPage.writeTextInTextArea("Test text fluent wait! ");
        }

        [Test]
        public void checkWikiPageH1Text()
        {
            WikiPage wikiPage = new WikiPage(driver);
            wikiPage.clickOnWikiButton();
            wikiPage.checkWikiPageHeaderText("WikiPage");
        }

        [Test]
        public void checkHtmlVersionValues()
        {
            WikiPage wikiPage = new WikiPage(driver);
            wikiPage.clickOnWikiButton();
            br.explicitWait(driver, By.Id("htmlversions"), 5);
            wikiPage.checkHtmlDropDownValues("3");
        }

        [Test]
        public void checkHeaderLinks()
        {
            WikiPage wikiPage = new WikiPage(driver);
            wikiPage.clickOnWikiButton();
            wikiPage.checkWikiPageHeaderLinks();
        }

        [Test]
        public void checkFooterLinks()
        {
            WikiPage wikiPage = new WikiPage(driver);
            wikiPage.clickOnWikiButton();
            wikiPage.checkWikiPageFooterLinks();
        }
    }
}
