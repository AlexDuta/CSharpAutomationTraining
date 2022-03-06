using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.Curs10_tema
{
    [TestFixture]
    class TestBase
    {
        //[SetUp] - method will be called before each test method (e.g. create a new driver instance)
        public IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "C:/CSharp_Automation/CSharpAutomationTraining/homepage.html";
        }


        //[TearDown] - method will be called after each test method (e.g. call driver.Quit())
        [TearDown]
        public void TearDown()
        {
         //   driver.Quit();
        }
        

    }
}
