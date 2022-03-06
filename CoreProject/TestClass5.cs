using CoreProject.Curs10_tema;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utils;

namespace CoreProject
{
    //H1 text is displayed and value equals “WikiPage”

    class TestClass5 : TestBase
    {

        [Test]
        public void H1Text()
        {
            driver.Navigate().GoToUrl("file:///C:/CSharp_Automation/CSharpAutomationTraining/wikipage.html");
            BrowserTema10 browser = new BrowserTema10();
            browser.WaitElemetToBeVisibleExplicit(driver, By.XPath("//body//h1"), 15);
            var elements = driver.FindElement(By.XPath("//body//h1"));
            //Assert.IsTrue(elements.Equals("WikiPage"));
            Assert.AreEqual("WikiPage", elements.Text);
        }

        [Test]
        public void HTMLversions()
        {
            driver.Navigate().GoToUrl("file:///C:/CSharp_Automation/CSharpAutomationTraining/wikipage.html");
            BrowserTema10 browser = new BrowserTema10();
            browser.WaitElemetToBeVisibleExplicit(driver, By.Id("htmlversions"), 15);
            SelectElement a = new SelectElement(driver.FindElement(By.Id("htmlversions")));
            var textField = driver.FindElement(By.Id("htmlVersion"));
            a.SelectByValue("no value");
            Assert.AreEqual("", textField.Text);
            Thread.Sleep(1000);
            a.SelectByText("HTML 2.0");
            Assert.AreEqual("Current selection: 2", textField.Text);
            Thread.Sleep(1000);
            a.SelectByText("HTML 3.2");
            Assert.AreEqual("Current selection: 3.2", textField.Text);
            Thread.Sleep(1000);
            a.SelectByText("HTML 4.0");
            Assert.AreEqual("Current selection: 4.0", textField.Text);
            Thread.Sleep(1000);
            a.SelectByText("HTML 5");
            Assert.AreEqual("Current selection: 5", textField.Text);
            Thread.Sleep(1000);
            a.SelectByText("Please select");
            Assert.AreEqual("Current selection: no value", textField.Text);
            Thread.Sleep(1000);
        }

        [Test]
        public void HeaderFooter()
        {
            driver.Navigate().GoToUrl("file:///C:/CSharp_Automation/CSharpAutomationTraining/wikipage.html");
            BrowserTema10 browser = new BrowserTema10();
            browser.WaitElemetToBeVisibleExplicit(driver, By.Id("navHeader"), 15);
            var elements = driver.FindElements(By.XPath("//div//header//*[@id='navHeader']//a"));
            foreach (var elm in elements)
            {     
                Assert.True(elm.Displayed);
            }
            var elements1 = driver.FindElements(By.XPath("//footer//*[@id='nav']//li//a"));
            foreach (var elm in elements1)
            {
                Assert.True(elm.Displayed);
            }
        }
    }
}
