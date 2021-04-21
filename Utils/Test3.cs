using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClassLibrary1.Curs10;

namespace Utils
{
    class Test3 : TestBaseCurs10
    {
        [Test]
        public void TestWikiPage3()
        {
            var wikilink = driver.FindElement(By.XPath("//a[@href='wikipage.html']"));
            var textField = driver.FindElement(By.Id("htmlVersion"));
            wikilink.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            textField.SendKeys("Test");
        }
    }
}
