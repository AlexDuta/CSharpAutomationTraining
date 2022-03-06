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

namespace SeleniumProject.Course8_HW
{
    [TestFixture]
    public class TestClass8
    {
        [Test]
        public void CheckPageTitle()
        {
            // Create the driver and check if the homepage name is "Home page"
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            Assert.IsTrue(driver.Title.Equals("Home page"));
            driver.Quit();
        }

        [Test]
        public void EmailInputDisplayed()
        {
            // Create the driver and check if the email input is displayed
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Pages/homepage.html";
            Assert.IsTrue(driver.FindElement(By.Id("email")).Displayed);
            driver.Quit();
        }

        [Test]
        public void PasswordInputDisplayed()
        {
            // Create the driver and check if the password input is displayed
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Pages/homepage.html";
            Assert.IsTrue(driver.FindElement(By.Id("password")).Displayed);
            driver.Quit();
        }

        [Test]
        public void LoginButtonDisplayed()
        {
            // Create the driver and check if the login button is displayed
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Pages/homepage.html";
            Assert.IsTrue(driver.FindElement(By.Id("Login")).Displayed);
            driver.Quit();
        }

        [Test]
        public void AllElementsDisplayed()
        {
            // Create the driver and check if the links are displayed one by one
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Pages/homepage.html";
            var elementsList = driver.FindElements(By.XPath("//a[@href]"));
            foreach (var elm in elementsList)
            {
                Assert.IsTrue(elm.Displayed);
            }
        }
    }
}
