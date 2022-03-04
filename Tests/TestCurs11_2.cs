using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjects;
using Utils;
namespace TestClassLibrary.Curs10
{
    [TestFixture]
    class TestCurs11_2 : TestBase11_1
    {
        [Test]
        public void h1Test()
        {
            string h1Text = homePage.WikiPageClick().FetchH1Text();
            Assert.IsTrue(h1Text.Equals("WikiPage"));
        }
        [Test]
        public void DropdownTest()
        {
            WikiPage wikipage = homePage.WikiPageClick();
            List<string> options = wikipage.GetSelectOptions();
            string textArea;
            foreach(var option in options)
            {
                wikipage = wikipage.SelectElementByText(option);
                textArea = wikipage.FetchAreaText();
                switch (option)
                {
                    case "Please select":
                        Assert.IsTrue(textArea.Equals(""));
                        break;
                    case "HTML 2.0":
                        Assert.IsTrue(textArea.Equals("Current selection: 2"));
                        break;
                    case "HTML 3.2":
                        Assert.IsTrue(textArea.Equals("Current selection: 3.2"));
                        break;
                    case "HTML 4.0":
                        Assert.IsTrue(textArea.Equals("Current selection: 4.0"));
                        break;
                    case "HTML 5":
                        Assert.IsTrue(textArea.Equals("Current selection: 5"));
                        break;
                    default:
                        throw new Exception("Unexpected Text");
                }
            }
            wikipage = wikipage.SelectElementByText("Please select");
            textArea = wikipage.FetchAreaText();
            Assert.IsTrue(textArea.Equals("Current selection: no value"));
        }
        [Test]
        public void CheckFooterHeaderLinks()
        {
            WikiPage wiki = homePage.WikiPageClick();
            Assert.IsTrue(wiki.isFooterVisible());
            Assert.IsTrue(wiki.isHeaderVisible());
        }
    }
}
