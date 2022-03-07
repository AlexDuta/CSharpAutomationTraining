using NUnit.Framework;
using OpenQA.Selenium;
using PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests
{
 
     class Class1 : TestBase
    {
        [Test]
        public void TestWikiHeader()
        {
            var homePage = new Homepage(driver);
            var wikiPage = new WikiPage(driver);
            wikiPage.H1TextDesplayed();
        }
        [Test]
        public void CheckValuesDropDown()
        {
            var wikipage= new WikiPage(driver);
            wikipage.SelectVersionDropDownByValue("no value");
            var text1 = wikipage.ReturnTextAreaValue();
            Assert.AreEqual("", text1);
            Thread.Sleep(1000);

            wikipage.SelectVersionDropDownByText("HTML 2.0");
            var text2 = wikipage.ReturnTextAreaValue();
            Assert.AreEqual("Current selection: 2", text2);
            Thread.Sleep(1000);

            wikipage.SelectVersionDropDownByText("HTML 3.2");
            var text3 = wikipage.ReturnTextAreaValue();
            Assert.AreEqual("Current selection: 3.2", text3);
            Thread.Sleep(1000);

            wikipage.SelectVersionDropDownByText("HTML 4.0");
            var text4 = wikipage.ReturnTextAreaValue();
            Assert.AreEqual("Current selection: 4.0", text4);
            Thread.Sleep(1000);

            wikipage.SelectVersionDropDownByText("HTML 5");
            var text5 = wikipage.ReturnTextAreaValue();
            Assert.AreEqual("Current selection: 5", text5);
            Thread.Sleep(1000);

            wikipage.SelectVersionDropDownByText("Please select");
            var text6 = wikipage.ReturnTextAreaValue();
            Assert.AreEqual("Current selection: no value", text6);
            Thread.Sleep(1000);
        }

        [Test]
        public void testHeaderLinks()
        {
            var wikipage = new WikiPage(driver);
            wikipage.HeaderLinksDisplayed();

        }
        public void testFooterLinks()
        {
            var wikipage = new WikiPage(driver);
            wikipage.footerLinksDisplayed();

        }


       
    }
}
