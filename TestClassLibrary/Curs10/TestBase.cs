using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace TestClassLibrary.Curs10
{
    class TestBase
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
          
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/ebizau/Downloads/pages/homepage.html";
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
