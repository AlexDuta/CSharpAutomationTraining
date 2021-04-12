using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary1.Curs7
{
    [TestFixture]
    class TestCurs7 : BrowserCurs7
    {
       // [System.ComponentModel.Category("StartBrowserTestMethods")]
        [Test]
        public void StartBrowserTrue()
        {
            Assert.IsTrue(StartBrowser());
        }
        [Test]
        public void StartBrowserFalse()
        {
            Assert.IsFalse(StartBrowser());
        }
       // [System.ComponentModel.Category("GetPageTitleTestMethods")]
        [Test]
        public void VerifyPageTitle()
        {
            Assert.AreEqual(GetPageTitle(), "Browser is open");
        }
        [Test]
        public void VerifyWordInPageTitle()
        {
            StringAssert.Contains("open",GetPageTitle());
        }
       // [System.ComponentModel.Category("WidowWidthTestMethods")]
        [Test]
        public void VerifyEqualsWindowWidth()
        {
            Assert.AreEqual(GetBrowserWidth(), 1920);
        }
        [Test]
        public void VerifyLessWindowWidth()
        {
            Assert.Less(GetBrowserWidth(), 2000);
        }
        [Test]
        public void VerifyGreaterWindowWidth()
        {
            Assert.Greater(GetBrowserWidth(), 1000);
        }
    }
}
