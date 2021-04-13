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

namespace TestClassLibrary.Curs8
{
    [TestFixture]
    class TestCurs8
    { 

        public IWebDriver driver;

        [Test]
        public void CheckPageTitleTest()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = @"C:\Users\atpop\OneDrive - ENDAVA\Desktop\homepage.html";
            driver.Manage().Window.Maximize();
            Assert.IsTrue(driver.Title.Equals("Home page"));
            driver.Close();
        }

        [Test]
        public void EmailInputTest()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = @"C:\Users\atpop\OneDrive - ENDAVA\Desktop\homepage.html";
            driver.Manage().Window.Maximize();
            var emailInput = driver.FindElement(By.Id("email"));
            Assert.IsTrue(emailInput.Displayed);
            driver.Close();
        }

        [Test]
        public void PasswordInputTest()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = @"C:\Users\atpop\OneDrive - ENDAVA\Desktop\homepage.html";
            driver.Manage().Window.Maximize();
            var passwordInput = driver.FindElement(By.Id("password"));
            Assert.IsTrue(passwordInput.Displayed);
            driver.Close();
        }

        [Test]
        public void LoginButtonTest()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = @"C:\Users\atpop\OneDrive - ENDAVA\Desktop\homepage.html";
            driver.Manage().Window.Maximize();
            var loginButton = driver.FindElement(By.Id("Login"));
            Assert.IsTrue(loginButton.Displayed);
            driver.Close();
        }

        [Test]
        public void LinksDisplayedTest()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = @"C:\Users\atpop\OneDrive - ENDAVA\Desktop\homepage.html";
            driver.Manage().Window.Maximize();
            var linksHeader = driver.FindElements(By.XPath("//*[@id='myDivHeader']/header"));
            var linksFooter = driver.FindElements(By.Id("nav"));
            foreach(var element in linksHeader)
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine(element.Text + element.GetAttribute("html"));
            }
            foreach (var element in linksFooter)
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine(element.Text + element.GetAttribute("html"));
            }
            driver.Close();
        }
    }
}
