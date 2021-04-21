using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestClassLibrary1.Curs10;

namespace Utils
{
    class Test1 : TestBaseCurs10
    {
        [Test]
        public void TestWikiPage1()
        {
            var wikilink = driver.FindElement(By.XPath("//a[@href='wikipage.html']"));
            var textField = driver.FindElement(By.Id("htmlVersion"));
            wikilink.Click();
            Thread.Sleep(5000);
            textField.SendKeys("Test");
        }
    }
}
