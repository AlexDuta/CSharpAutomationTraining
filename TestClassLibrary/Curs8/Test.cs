using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace TestClassLibrary.Curs8
{
    [TestFixture]
    public class Test
    {

        [Test]
        public void TestPageTitle()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///c:/Workspace/homepage.html";
            driver.Manage().Window.Maximize();
            Assert.IsTrue(driver.Title.Equals("Home page"));
            driver.Quit();
        }

        [Test]
        public void TestEmailInputDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///c:/Workspace/homepage.html";
            driver.Manage().Window.Maximize();
            var emailInput = driver.FindElement(By.XPath("//input[@id='email']"));
            Assert.IsTrue(emailInput.Displayed);
            driver.Quit();
        }

        [Test]
        public void TestPasswordInputDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///c:/Workspace/homepage.html";
            driver.Manage().Window.Maximize();
            var passwordInput = driver.FindElement(By.Id("password"));
            Assert.IsTrue(passwordInput.Displayed);
            driver.Quit();
        }

        [Test]
        public void TestLoginBtnDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///c:/Workspace/homepage.html";
            driver.Manage().Window.Maximize();
            var loginBtn = driver.FindElement(By.Id("Login"));
            Assert.IsTrue(loginBtn.Displayed);
            driver.Quit();
        }
        [Test]
        public void FirstSeleniumTest()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///c:/Workspace/homepage.html";
            var elementsList = driver.FindElements(By.XPath("//a"));

            foreach (var elm in elementsList)
            {
                Assert.IsTrue(elm.Displayed);
            }
            driver.Quit();
        }
    }
}
