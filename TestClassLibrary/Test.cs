using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClassLibrary.Curs7;

namespace TestClassLibrary
{
    [TestFixture]
    public class Test
    {
        Browser br = new Browser();
        [Test]
        public void TestBrowserTrue()
        {
            Assert.IsTrue(br.StartBrowser());
        }
        
        [Test]
        public void TestBrowserFalse()
        {
            Assert.IsFalse(br.StartBrowser());
        }
        [Test]
        public void GetPageTitleEqual()
        {
            Assert.AreEqual("Browser is open!", br.GetPageTitle());
        }

        [Test]
        public void GetPageTitleContains()
        {
            string temp = br.GetPageTitle();
            Assert.IsTrue(temp.Contains("open"));
        }

        //[Test]
        //public void GetPageTitleContains()
        //{
        //    Assert.Contains("open", br.GetPageTitle());
        //}

        [Test]
        public void GetBrowserWidthEqual()
        {
            Assert.AreEqual(50, br.GetBrowserWidth());
        }

        [Test]
        public void GetBrowserWidthLess()
        {
            Assert.Less(40, br.GetBrowserWidth());
        }

        [Test]
        public void GetBrowserWidthGreater()
        {
            Assert.Greater(60, br.GetBrowserWidth());
        }
    }
}
