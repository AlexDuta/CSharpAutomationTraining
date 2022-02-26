using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]
    class TestClass
    {
        BrowserC7 browser = new BrowserC7();

        [Test]
        public void StartBrowserTrue()
        {
            Assert.IsTrue(browser.StartBrowser());
        }
        [Test]
        public void StartBrowserFalse()
        {
            Assert.IsFalse(!browser.StartBrowser());
        }
        [Test]
        public void GetPageTitleEquals()
        {
            Assert.AreEqual(browser.GetPageTitle(),"Browser is open");
        }
        [Test]
        public void GetPageTitleContains()
        {
            Console.WriteLine("TODO");
        }
        [Test]
        public void GetBrowserWidthEqual()
        {
            Assert.AreEqual(1920, browser.GetBrowserWidth());
        }
        [Test]
        public void GetBrowserWidthLess()
        {
            Assert.Less(1000, browser.GetBrowserWidth());
        }
        [Test]
        public void GetBrowserWidthGreater()
        {
            Assert.Greater(2000, browser.GetBrowserWidth());
        }
    }
}
