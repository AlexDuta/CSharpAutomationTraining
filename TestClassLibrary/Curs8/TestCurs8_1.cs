using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace TestClassLibrary.Curs8
{
    [TestFixture]
    class TestCurs8_1
    {
        [Test]
        public void CheckPageTitle()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file://C:/trainingpage/homepage.html";
            Assert.IsTrue(driver.Title.Equals("Home page"));
            driver.Quit();
        }
        [Test]
        public void CheckEmailInputIsDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file://C:/trainingpage/homepage.html";
            Assert.IsTrue(driver.FindElement(By.Id("email")).Displayed);
            driver.Quit();
        }
        [Test]
        public void CheckPasswordInputIsDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file://C:/trainingpage/homepage.html";
            Assert.IsTrue(driver.FindElement(By.Id("password")).Displayed);
            driver.Quit();
        }
        [Test]
        public void CheckLoginButtonIsDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file://C:/trainingpage/homepage.html";
            Assert.IsTrue(driver.FindElement(By.Id("Login")).Displayed);
            driver.Quit();
        }
        [Test]
        public void CheckAllElemsAreDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file://C:/trainingpage/homepage.html";
            driver.Manage().Window.Maximize();
            var elems = driver.FindElements(By.XPath("//a[@href]"));
            foreach(var elem in elems)
            {
                Assert.IsTrue(elem.Displayed);
            }
            driver.Quit();
        }
    }
}
