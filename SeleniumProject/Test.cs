using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumProject.Curs7;

namespace SeleniumProject
{
    [TestFixture]
    public class Test
    { 

        [Test]
        public void TestMethod1()
        {
            Browser browser = new Browser();
            Assert.IsTrue(browser.StartBrowser());
         
        }

        [Test]
        public void TestMethod2()
        {
            Browser browser = new Browser();
            Assert.IsFalse(browser.StartBrowser());

        }

        [Test]
        public void TestMethod3()
        {
            Browser browser = new Browser();
            Assert.AreEqual("Browser is open",browser.GetPageTitle());

        }

        [Test]
        public void TestMethod4()
        {
            Browser browser = new Browser();
            Assert.AreEqual("Browser is not open", browser.GetPageTitle());

        }

        [Test]
        public void TestMethod5()
        {
            Browser browser = new Browser();
            Assert.AreEqual(1000, browser.GetBrowserWidth());

        }

        [Test]
        public void TestMethod6()
        {
            Browser browser = new Browser();
            Assert.Greater(1200, browser.GetBrowserWidth());

        }

        [Test]
        public void TestMethod7()
        {
            Browser browser = new Browser();
            Assert.Less(800, browser.GetBrowserWidth());

        }
    }
}
