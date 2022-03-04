using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
namespace TestClassLibrary.Curs10
{
    [TestFixture]
    class TestCurs10_2 : TestBase
    {
        [Test]
        public void navigateTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var elem = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[2]/a"));
            elem.Click();
            var textFill = driver.FindElement(By.Id("htmlVersion"));
            textFill.SendKeys("Hello World");
        }
    }
}
