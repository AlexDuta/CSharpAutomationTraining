using CoreProject.Curs10_tema;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace CoreProject
{
    class TestClass4 : TestBase
    {
        [Test]

        public void TestWaits()
        {
            // fluent wait 
            BrowserTema10 browser = new BrowserTema10();
            driver.Navigate().GoToUrl("file:///C:/CSharp_Automation/CSharpAutomationTraining/wikipage.html");
            browser.WaitElemetToBeVisibleFluent(driver, By.Id("htmlVersion"), 10);
            driver.FindElement(By.Id("htmlVersion")).SendKeys("test");

        }
    }
}
