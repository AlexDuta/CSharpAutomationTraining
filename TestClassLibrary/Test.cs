using NUnit.Framework;
using System;
using TestClassLibrary.Curs7;

namespace TestClassLibrary
{
    [TestFixture]
    public class Test
    {
        Browser browser = new Browser();

        [Test]
        public void StartBrowserTrueTest()
        {
            Assert.IsTrue(browser.StartBrowser());
        }     

        [Test]
        public void StartBrowserFalseTest()
        {
            Assert.IsFalse(browser.StartBrowser());
        }

        [Test]
        public void GetPageTitleEqualTest()
        {
            Assert.Equals(browser.GetPageTitle(), "Browser is open.");
        }

        [Test]
        public void GetPageTitleContainsTest()
        {
            string contain = "Browser";
            Assert.That(browser.GetPageTitle(), Does.Contain(contain));
        }

        [Test]
        public void GetBrowserWidthLessTest()
        {
            Assert.Less(browser.GetBrowserWidth(), 2000);
        }        
        
        [Test]
        public void GetBrowserWidthGreaterTest()
        {
            Assert.Greater(browser.GetBrowserWidth(), 1900);
        }

        [Test]
        public void GetBrowserWidthEqualTest()
        {
            Assert.Equals(browser.GetBrowserWidth(), 1920);
        }
        
    }
}
