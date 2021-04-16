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

namespace ClassLibraryProj
{
    public class BaseTest
    {

        public IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = @"C:\Users\lgrecu\OneDrive - ENDAVA\Desktop\pages\homepage.html";
            driver.Manage().Window.Maximize();
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
