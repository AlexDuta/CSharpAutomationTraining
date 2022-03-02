using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumProject.Curs7;
using OpenQA.Selenium;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject
{

    [TestFixture]
    public class Class1
    {
        /*Curs 8 - tema */
        [Test]
        public void TestPageTitle()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "C:/CSharp_Automation/CSharpAutomationTraining/homepage.html";
            Assert.True(driver.Title.Equals("Home page"));
            driver.Quit();         
        }
        [Test]
        public void TestPageEmail()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "C:/CSharp_Automation/CSharpAutomationTraining/homepage.html";
            Assert.True(driver.FindElement(By.Id("email")).Displayed);           
            driver.Quit();
        }

        [Test]
        public void TestPagePassword()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "C:/CSharp_Automation/CSharpAutomationTraining/homepage.html";
            Assert.True(driver.FindElement(By.Id("password")).Displayed);
            driver.Quit();
        }

        [Test]
        public void TestPageLogin()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "C:/CSharp_Automation/CSharpAutomationTraining/homepage.html";
            Assert.True(driver.FindElement(By.XPath("//button[@id='Login']")).Displayed);
            driver.Quit();
        }

        [Test]
        public void TestAllLinks()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "C:/CSharp_Automation/CSharpAutomationTraining/homepage.html";
            var elements = driver.FindElements(By.XPath("//a/@href"));
            foreach (var elm in elements)
            {
                Assert.True(elm.Displayed);
            }
            driver.Quit();
        }
        /*Curs 8*/
        [Test]
        public void FirstSeleniumTest()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers"); 
            driver.Url = "C:/CSharp_Automation/CSharpAutomationTraining/homepage.html"; 
            Assert.True(driver.Title.Equals("Home page"));
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("admin@domain.org");
            driver.FindElement(By.Id("password")).SendKeys("111111");
            driver.FindElement(By.Id("Login")).Click(); 
            Assert.True(driver.FindElement(By.Id("email")).Displayed);       
            driver.Quit();       
        }
            /*Curs 7 - tema*/
            [Test]
        public void TestStartBrowser()
        {
            Browser browser= new Browser();
            Assert.IsTrue(browser.StartBrowser());
            Assert.AreEqual("False", browser.StartBrowser());
        }

        [Test]
        public void TestGetPageTitle()
        {
            Browser browser = new Browser();
            Assert.AreEqual("browser is open",browser.GetPageTitle());
            //Assert.Contains("open",browser.GetPageTitle(), "contine stringul");
            Assert.AreNotEqual("browser is closed", browser.GetPageTitle());
        }

        [Test]
        public void TestGetBrowserWidth()
        {
            Browser browser = new Browser();
            Assert.AreEqual(1890 , browser.GetBrowserWidth());
            Assert.Less(1234, browser.GetBrowserWidth());
            Assert.Greater(1999, browser.GetBrowserWidth());
        }
        /* Curs 7*/
        [Test]
        public void TestMethod1()
        {
            Console.WriteLine("test method1");
            Assert.IsTrue(2 == 2);
        }

        [Test]
        public void TestMethod2()
        {
            Console.WriteLine("test method2");
            Assert.AreEqual(true, 2 == 3, "test2");
        }
    }
}
