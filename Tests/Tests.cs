using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProj
{
    public class Tests : TestBase
    {
        [Test]
        public void TestLogin()
        {
            var homePage = new Homepage(driver);
            var dashboardPage = homePage.FillInLoginDetails("admin@domain.org", "111111")
                                        .ClickLoginBtn()
                                        .VerifyPageHeader("Dashboard page");

            var actualPageHeaderText = dashboardPage.GetPageHeader();
            Assert.AreEqual("Dashboard page", actualPageHeaderText);
        }

        [Test]
        public void TestWikiPage()
        {
            var homePage = new Homepage(driver);
            homePage.ClickWikiLink()
                    .ChechTextAreaIsDisplayed();
        }

        [Test]
        public void TestWikiPageFillTextField()
        {
            var homePage = new Homepage(driver);
            homePage.ClickWikiLink()
                    .FillTextArea("Filling Text Area");
        }

        [Test]
        public void TestWikiPageHeader()
        {
            var homePage = new Homepage(driver);
            homePage.ClickWikiLink()
                    .VerifyPageHeader("WikiPage");
        }

        [Test]
        public void TestWikiPageHeaderLinks()
        {
            var homePage = new Homepage(driver);
            homePage.ClickWikiLink()
                    .CheckHeaderLinks();
        }

        [Test]
        public void TestWikiPageFooterLinks()
        {
            var homePage = new Homepage(driver);
            homePage.ClickWikiLink()
                    .CheckFooterLinks();
        }


    }
}
