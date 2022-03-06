using CoreProject.Curs10_tema;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject
{
     class TestClass3: TestBase
    {
        [Test]
        
        public void TestWaits()
        {
            // implicit wait 
            driver.Navigate().GoToUrl("file:///C:/CSharp_Automation/CSharpAutomationTraining/wikipage.html");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("htmlVersion")).SendKeys("test");
           
        }
    }
}
