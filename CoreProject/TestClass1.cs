using NUnit.Framework;
using OpenQA.Selenium;
using CoreProject.Curs10_tema;
using Utils;

namespace CoreProject
{
    [TestFixture]
    class TestClass1 : TestBase
    {
        [Test]
        //explicit wait
        public void TestWaits()
        {
            BrowserTema10 browser = new BrowserTema10();
            driver.Navigate().GoToUrl("file:///C:/CSharp_Automation/CSharpAutomationTraining/wikipage.html");
            browser.WaitElemetToBeVisibleExplicit( driver, By.Id("htmlVersion"), 5);
            driver.FindElement(By.Id("htmlVersion")).SendKeys("test");          
        }
    }
}
