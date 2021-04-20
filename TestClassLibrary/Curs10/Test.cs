using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Utils;

namespace TestClassLibrary.Curs10
{
    [TestFixture]
    class Test : TestBase
    {
        Browser browser = new Browser();

        [Test]
        public void explicitNavigateOnWikiPageAndInsertText()
        {
            HomePage homepage = new HomePage(driver);
            homepage.NavigateOnWikiPage().explicitPageToLoadt().insertText("explicit wait");
        }
           
        [Test]
        public void implicitNavigateOnWikiPageAndInsertText()
        {
            HomePage homepage = new HomePage(driver);
            homepage.NavigateOnWikiPage().implicitPageToLoad().insertText("implicit wait");
        }
        [Test]
        public void fluentNavigateOnWikiPageAndInsertText()
        {
            HomePage homepage = new HomePage(driver);
            homepage.NavigateOnWikiPage().fluentPageToLoad().insertText("fluent wait");
        }

        [Test]
        public void TestWikiLink()
        {
            HomePage homepage = new HomePage(driver);
            homepage.NavigateOnWikiPage().VerifyPageHeaderText("WikiPage");
        }

        [Test]
        public void TestDropDownSelection()
        {
            HomePage homepage = new HomePage(driver);
            homepage.NavigateOnWikiPage().CheckDropDownValues();
        }

        [Test]
        public void verifyHeaderLink()
        {
            HomePage homepage = new HomePage(driver);
            homepage.NavigateOnWikiPage().checkHeaderLinks();
        }

        [Test]
        public void verifyFooterLink()
        {
            HomePage homepage = new HomePage(driver);
            homepage.NavigateOnWikiPage().checkFooterLinks();
        }
    }
}
