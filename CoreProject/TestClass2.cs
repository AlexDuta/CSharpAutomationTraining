using NUnit.Framework;
using OpenQA.Selenium;
using CoreProject.Curs10_tema;
using System.Threading;

namespace CoreProject
{
    [TestFixture]
    class TestClass2 : TestBase
    {
        [Test]
        public void TestWaits()
        {
         // explicit wait with sleep
            driver.Navigate().GoToUrl("file:///C:/CSharp_Automation/CSharpAutomationTraining/wikipage.html");
            Thread.Sleep(5000);
            driver.FindElement(By.Id("htmlVersion")).SendKeys("test");
        }
    }
}
