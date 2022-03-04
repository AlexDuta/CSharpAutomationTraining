using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using PageObjects;
using System.IO;
using System.Reflection;
using Utils;

namespace TestClassLibrary.Curs10
{
    [TestFixture]
    class TestBase11_1
    {
        public IWebDriver driver;
        public Actions action;
        public Browser10_1 browser;
        public HomePage homePage;
        [SetUp]
        public void InitDriver()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file://C:/trainingpage/homepage.html";
            driver.Manage().Window.Maximize();
            action = new Actions(driver);
            browser = new Browser10_1();
            homePage = new HomePage(driver);
        }
        [TearDown]
        public void DestroyDriver()
        {
            driver.Quit();
        }

    }
}
