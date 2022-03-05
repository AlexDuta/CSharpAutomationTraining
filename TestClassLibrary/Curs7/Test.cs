using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestClassLibrary.Curs7
{
    class Test
    {
        Browser b = new Browser(1920);

        [Test]
        public void testStartBrowserTrue()
        {
            Assert.True(b.StartBrowser());
        }

        [Test]
        public void testStartBrowserFalse()
        {
            Assert.False(!b.StartBrowser());
        }

        [Test]
        public void testGetPageTitleEqual()
        {
            Assert.AreEqual(b.GetPageTitle(), "Generic Page Title");
        }

        [Test]
        public void testPageTitleContains()
        {
            StringAssert.Contains(b.GetPageTitle(), "Generic Page Title");
        }

        [Test]
        public void testGetBrowserWidthEqual()
        {
            Assert.AreEqual(b.GetBrowserWidth(), 1920);
        }


        [Test]
        public void testGetBrowserWidthLess()
        {
            Assert.Less(b.GetBrowserWidth(), 2000);
        }

        [Test]
        public void testGetBrowserWidthGreater()
        {
            Assert.Greater(b.GetBrowserWidth(), 1366);
        }

    }
}
