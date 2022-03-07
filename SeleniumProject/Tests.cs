using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
     class Tests : TestBase
    {
        [Test]
        public void TestLogin()
        {
            var homePage = new Homepage(driver);
            var dashboardPage = homePage.FillInLoginDetails("admin@domain.org", "111111")
                    .ClickLoginBtn();
                    //.VerifyPageHeader("Dashboard page");

            // cu assertul in clasa de test
            var actualPageHeaderText = dashboardPage.GetPageHeader();
            Assert.AreEqual("Dashboard page", actualPageHeaderText);
        }

        [Test]
        public void TestWikiPage()
        {
            var homePage= new Homepage(driver);
            homePage.clickWikiLink()
                    .CheckTextAreaIsDisplayed();
        }

    }
}
