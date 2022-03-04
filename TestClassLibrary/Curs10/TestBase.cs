using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary.Curs10
{
    [TestFixture]
    class TestBase
    {
        public IWebDriver driver;
        public Actions action;
        [SetUp]
        public void InitDriver()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file://C:/trainingpage/homepage.html";
            driver.Manage().Window.Maximize();
            action = new Actions(driver);
        }
        [TearDown]
        public void DestroyDriver()
        {
            driver.Quit();
        }

    }
}
