using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestClassLibrary.Curs7;

namespace TestClassLibrary
{
    [TestFixture]
    public class Test
    {
        BrowserCurs7 browserCurs7 = new BrowserCurs7();

        [Test]
        public void StartBrowserTrue()
        {
            Assert.IsTrue(browserCurs7.StartBrowser());
        }
        [Test]
        public void StartBrowserFalse()
        {
            Assert.IsFalse(browserCurs7.StartBrowser());
        }
        [Test]
        public void GetPagetitleEquals()
        {
            Assert.AreEqual("returns a generic string saying browser is open", browserCurs7.GetPageTitle());
        }
        [Test]
        public void GetPagetitleContains()
        {
            string value = browserCurs7.GetPageTitle();
            Assert.IsTrue(value.Contains("generic"));
        }
        //[Test]
        //public void GetPagetitleContains2()
        //{
        //    Assert.Contains("generic", browserCurs7.GetPageTitle());
        //}
        [Test]
        public void GetBrowserWidthEquals()
        {
            Assert.AreEqual(15, browserCurs7.GetBrowserWidth());
        }
        [Test]
        public void GetBrowserWidthLess()
        {
            Assert.Less(14, browserCurs7.GetBrowserWidth());
        }
        [Test]
        public void GetBrowserWidthGreater()
        {
            Assert.Greater(16, browserCurs7.GetBrowserWidth());
        }
    }
}
