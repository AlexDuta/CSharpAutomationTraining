using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CSharpAutoTraining.Curs7;

namespace TestClassLibrary
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestStartBrowser()
        {
            BrowserCurs7_1 browser = new BrowserCurs7_1();
            Assert.IsTrue(browser.StartBrowser());
            Assert.IsFalse(browser.StartBrowser());
        }
        [Test]
        public void TestGetPage()
        {
            BrowserCurs7_1 browser = new BrowserCurs7_1();
            Assert.AreEqual("No page", browser.GetPageTitle());
            Assert.IsTrue(browser.StartBrowser());
            Assert.AreEqual("Browser is open", browser.GetPageTitle());

        }
        [Test]
        public void TestGetBrowserWidth()
        {
            BrowserCurs7_1 browser = new BrowserCurs7_1();
            Assert.Less(1000, browser.GetBrowserWidth());
            Assert.AreEqual(1920, browser.GetBrowserWidth());
            Assert.Greater(2000, browser.GetBrowserWidth());

        }
    }
}
