using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary.Course7_HW
{
    [TestFixture]
    class TestClass
    {

        // Create Browser object
        Browser browser = new Browser();

        [Test]
        public void TestStartBrowserIsTrue()
        {
            Assert.IsTrue(browser.StartBrowser());
            // Assert.IsTrue(!browser.StartBrowser()); - will fail!
        }

        [Test]
        public void TestStartBrowserIsFalse()
        {
            Assert.IsFalse(!browser.StartBrowser()); 
            // Assert.IsFalse(browser.StartBrowser()); - will fail!
        }

        [Test]
        public void TestGetPageTitleEqualsTrue()
        {  
            Assert.AreEqual("Browser is now opened.", browser.GetPageTitle());
            // Assert.AreEqual("No Browser opened.", browser.GetPageTitle()); - will fail!         
        }

        [Test]
        public void TestGetPageTitleEqualsFalse()
        {
            Assert.AreNotEqual("No Browser opened.", browser.GetPageTitle());
            // Assert.AreNotEqual("Browser is now opened.", browser.getPageTitle()); - will fail!
        }

        [Test]
        public void TestGetBrowserWidthLess()
        {
            Assert.Less(1080, browser.GetBrowserWidth());
            // Assert.Less(2048, browser.GetBrowserWidth()); - will fail!
            // Assert.Less(1920, browser.GetBrowserWidth()); - will fail!
        }

        [Test]
        public void TestGetBrowserWidthAreEqual()
        {
            Assert.AreEqual(1920, browser.GetBrowserWidth());
            // Assert.Equal(1080, browser.GetBrowserWidth()); - will fail!
            // Assert.Equal(2048, browser.GetBrowserWidth()); - will fail!
        }

        [Test]
        public void TestGetBrowserWidthGreater()
        {
            Assert.Greater(2048, browser.GetBrowserWidth());
            // Assert.Greater(1920, browser.GetBrowserWidth());
            // Assert.Greater(1080, browser.GetBrowserWidth()); - will fail!
        }
    }
}
