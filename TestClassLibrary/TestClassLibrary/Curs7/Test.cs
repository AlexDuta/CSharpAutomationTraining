using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestClassLibrary.Curs7
{
    [TestFixture]
    class Test
    {
        BrowserCurs7 browser = new BrowserCurs7();
       [Test]
        public void StartBrowserTrue()
        {
            Assert.IsTrue(browser.StartBrowser());
        }

        [Test]
        public void StartBrowserFalse()
        {
            Assert.IsFalse(browser.StartBrowser());
        }

        [Test]
        public void GetPageTitleEquals()
        {
            Assert.AreEqual("Browser is open!", browser.GetPageTitle());
        }

        //[Test]
        //public void GetPageTitleContains()
        //{
        //    Assert.Contains("Browser is open!", browser.GetPageTitle());
        //}

        [Test]
        public void GetPageTitleContains()
        {
            String valoare = browser.GetPageTitle();
            Assert.IsTrue(valoare.Contains("Browser is open!"));
        }
        [Test]  
        public void GetBrowserWidthEqual()
        {
            Assert.AreEqual(10, browser.GetBrowserWidth());
        }

        [Test]
        public void GetBrowserWidthLess()
        {
            Assert.Less(8, browser.GetBrowserWidth());
        }

        [Test]
        public void GetBrowserWidthGreater()
        {
            Assert.Greater(12, browser.GetBrowserWidth());
        }

    }
}
