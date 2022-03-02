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
    public class Class1
    {
        [Test]
        public void TestStartBrowser()
        {
            Browser browser= new Browser();
            Assert.IsTrue(browser.StartBrowser());
            Assert.AreEqual("False", browser.StartBrowser());
        }

        [Test]
        public void TestGetPageTitle()
        {
            Browser browser = new Browser();
            Assert.AreEqual("browser is open",browser.GetPageTitle());
            //Assert.Contains("open",browser.GetPageTitle(), "contine stringul");
            Assert.AreNotEqual("browser is closed", browser.GetPageTitle());
        }

        [Test]
        public void TestGetBrowserWidth()
        {
            Browser browser = new Browser();
            Assert.AreEqual(1890 , browser.GetBrowserWidth());
            Assert.Less(1234, browser.GetBrowserWidth());
            Assert.Greater(1999, browser.GetBrowserWidth());
        }
        [Test]
        public void TestMethod1()
        {
            Console.WriteLine("test method1");
            Assert.IsTrue(2 == 2);
        }

        [Test]
        public void TestMethod2()
        {
            Console.WriteLine("test method2");
            Assert.AreEqual(true, 2 == 3, "test2");
        }
    }
}
