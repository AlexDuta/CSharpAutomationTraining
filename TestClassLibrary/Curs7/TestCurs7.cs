using NUnit.Framework;
using System;
using TestClassLibrary.Curs7;

namespace TestClassLibrary
{
    [TestFixture]
    public class TestCurs7
    {
        BrowserCurs7 browser = new BrowserCurs7();

        [Test]
        public void StartBrowserTrueTest()
        {
            Assert.IsTrue(browser.StartBrowserTrue());
        }

        [Test]
        public void StartBrowserFalseTest()
        {
            Assert.IsFalse(browser.StartBrowserFalse());
        }

        [Test]
        public void GetPageTitleEqualTest()
        {
            Assert.AreEqual(browser.GetPageTitle(), "Browser is open.");
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
            Assert.AreEqual(browser.GetBrowserWidth(), 1920);
        }

    }
}