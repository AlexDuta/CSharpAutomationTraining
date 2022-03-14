using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using PageObjects;

namespace Tests
{
    public class TestsClass : TestBase
    {
        [Test]
        public void TestH1Displayed()
        {
            var wikiPage = new WikiPage(driver);
            wikiPage.H1Displayed();
        }

        [Test]
        public void TestHeader()
        {
            var wikipage = new WikiPage(driver);
            wikipage.HeaderDisplayed();

        }

        [Test]
        public void TestFooter()
        {
            var wikipage = new WikiPage(driver);
            wikipage.FooterDisplayed();

        }

        [Test]
        public void TestDropDown()
        {
            var wikipage = new WikiPage(driver);
            var browser = new Browser(driver);

            wikipage.SelectVersionDropDownByValue("HTML 2.0");
            Assert.AreEqual("Current selection: 2", wikipage.TextAreaValue());
            Thread.Sleep(1000);

            wikipage.SelectVersionDropDownByValue("HTML 3.2");
            Assert.AreEqual("Current selection: 3.2", wikipage.TextAreaValue());
            Thread.Sleep(1000);

            wikipage.SelectVersionDropDownByValue("HTML 4.0");
            Assert.AreEqual("Current selection: 4.0", wikipage.TextAreaValue());
            Thread.Sleep(1000);

            wikipage.SelectVersionDropDownByValue("HTML 5");
            Assert.AreEqual("Current selection: 5", wikipage.TextAreaValue());
            Thread.Sleep(1000);

        }


    }
}
