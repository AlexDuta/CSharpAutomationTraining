using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Tests
{
    class Tests:TestBase
    {
        [Test]
        public void TestNavigateWikipage()
        {
            var homepage = new Homepage(driver);
            homepage.ClickWikiLink().
                     CheckAndFill("test");
        }
        [Test]
        public void TestWikiPageHeader()
        {
            var homepage = new Homepage(driver);
            homepage.ClickWikiLink().
                     CheckHeader();

        }
        [Test]
        public void TestWikiDropdown()
        {
            var homepage = new Homepage(driver);
            homepage.ClickWikiLink().
                     CheckDropdownDisplayed("HTML 2.0", "Current selection: 2");
        }
        [Test]
        public void TestWikiHeaderLinks()
        {
            var homepage = new Homepage(driver);
            homepage.ClickWikiLink().
                     CheckHeaderLinks();
        }
        [Test]
        public void TestWikiFooterLinks()
        {
            var homepage = new Homepage(driver);
            homepage.ClickWikiLink().
                     CheckFooterLinks();
        }
    }
}
