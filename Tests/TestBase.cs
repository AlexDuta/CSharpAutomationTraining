
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class TestBase
    {
        public IWebDriver driver;
        public Homepage homepage;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "C:/CSharp_Automation/CSharpAutomationTraining/wikipage.html";
        }


        //[TearDown] - method will be called after each test method (e.g. call driver.Quit())
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
