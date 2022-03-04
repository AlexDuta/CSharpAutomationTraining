using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
namespace TestClassLibrary.Curs10
{
    [TestFixture]
    class TestCurs10_5 : TestBase
    {
        [Test]
        public void h1Test()
        {
            driver.Navigate().GoToUrl("file://C:/trainingpage/wikipage.html");
            Browser10_1 browser = new Browser10_1();
            browser.WaitElementToBeVisible(driver, By.XPath("//h1"), 10);
            var elem = driver.FindElement(By.XPath("//h1"));
            Assert.IsTrue(elem.Text.Equals("WikiPage"));
        }
        [Test]
        public void DropdownTest()
        {
            driver.Navigate().GoToUrl("file://C:/trainingpage/wikipage.html");
            Browser10_1 browser = new Browser10_1();
            browser.WaitElementToBeVisible(driver, By.Id("htmlversions"), 10);
            var elem = driver.FindElement(By.Id("htmlversions"));
            var selectElem = new SelectElement(elem); 
            var options = elem.FindElements(By.TagName("option"));
            IWebElement textArea;
            foreach(var option in options)
            {
                selectElem.SelectByText(option.Text);
                textArea = driver.FindElement(By.Id("htmlVersion"));
                switch (option.Text)
                {
                    case "Please select":
                        Assert.IsTrue(textArea.Text.Equals(""));
                        break;
                    case "HTML 2.0":
                        Assert.IsTrue(textArea.Text.Equals("Current selection: 2"));
                        break;
                    case "HTML 3.2":
                        Assert.IsTrue(textArea.Text.Equals("Current selection: 3.2"));
                        break;
                    case "HTML 4.0":
                        Assert.IsTrue(textArea.Text.Equals("Current selection: 4.0"));
                        break;
                    case "HTML 5":
                        Assert.IsTrue(textArea.Text.Equals("Current selection: 5"));
                        break;
                    default:
                        throw new Exception("Unexpected Text");
                }
            }
            selectElem.SelectByText("Please select");
            textArea = driver.FindElement(By.Id("htmlVersion"));
            Assert.IsTrue(textArea.Text.Equals("Current selection: no value"));
        }
        [Test]
        public void CheckFooterHeaderLinks()
        {
            driver.Navigate().GoToUrl("file://C:/trainingpage/wikipage.html");
            var elems = driver.FindElements(By.Id("navHeader"));
            foreach (var elem in elems)
            {
                Assert.True(elem.Displayed);
            }
            elems = driver.FindElements(By.Id("nav"));
            foreach (var elem in elems)
            {
                Assert.True(elem.Displayed);
            }
        }
    }
}
