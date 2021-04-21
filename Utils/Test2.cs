using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClassLibrary1.Curs10;

namespace Utils
{
    class Test2 : TestBaseCurs10
    {
        [Test]
        public void TestWikiPage2()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var wikilink = driver.FindElement(By.XPath("//a[@href='wikipage.html']"));
            var textField = driver.FindElement(By.Id("htmlVersion"));
            wikilink.Click();
            var waitCondition = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("htmlVersion")));
            textField.SendKeys("Test");
        }
    }
}
