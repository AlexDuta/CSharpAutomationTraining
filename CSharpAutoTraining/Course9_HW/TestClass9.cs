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

namespace SeleniumProject.Course9_HW
{
    [TestFixture]
    public class TestClass9
    {
        // Class-level driver and action
        public IWebDriver driver;
        public Actions action;

        [SetUp]
        public void SetUp()
        {
            // Create the driver and maximize the window
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Pages/homepage.html";
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            // Close the Browser
            driver.Quit();
        }

        [Test]
        public void CheckPageTitle()
        {
            // Check if the homepage title is "Home page"
            Assert.IsTrue(driver.Title.Equals("Home page"));
        }

        [Test]
        public void EmailInputDisplayed()
        {
            // Check if the email input is displayed
            Assert.IsTrue(driver.FindElement(By.Id("email")).Displayed);
        }

        [Test]
        public void PasswordInputDisplayed()
        {
            // Check if the password input is displayed
            Assert.IsTrue(driver.FindElement(By.Id("password")).Displayed);
        }

        [Test]
        public void LoginButtonDisplayed()
        {
            // Check if the login button is displayed
            Assert.IsTrue(driver.FindElement(By.Id("Login")).Displayed);
        }

        [Test]
        public void AllElementsDisplayed()
        {
            // Check if the links are displayed one by one
            var elementsList = driver.FindElements(By.XPath("//a[@href]"));
            foreach (var elm in elementsList)
            {
                Assert.IsTrue(elm.Displayed);
            }
        }

        [Test]
        public void CheckNoEmailAndPassSubmit()
        {
            // Locate the login button and click on it
            var loginButton = driver.FindElement(By.Id("Login"));
            loginButton.Click();

            // Locate the error messages afer clicking the login button (no input)
            var passMessage = driver.FindElement(By.Id("passwordErrorText"));
            var emailMessage = driver.FindElement(By.Id("emailErrorText"));

            // Check if the error messages are displayed
            Assert.IsTrue(emailMessage.Displayed);
            Assert.IsTrue(passMessage.Displayed);

            // Check if the actual result equals the expected result
            Assert.IsTrue(emailMessage.Text.Equals("Email address can't be null"));
            Assert.IsTrue(passMessage.Text.Equals("Password can't be null"));
            
            // Refresh the page 
            driver.Navigate().Refresh();

            // Locate the error messages
            passMessage = driver.FindElement(By.Id("passwordErrorText"));
            emailMessage = driver.FindElement(By.Id("emailErrorText"));

            // Check if the error messages are NOT displayed
            Assert.IsFalse(emailMessage.Displayed);
            Assert.IsFalse(passMessage.Displayed);
        }

        [Test]
        public void CheckFooterHeaderLinks()
        {
            // Header Links
            var elems = driver.FindElements(By.Id("navHeader"));
            foreach (var elem in elems)
            {
                Assert.True(elem.Displayed);
            }

            // Footer Links
            elems = driver.FindElements(By.Id("nav"));
            foreach (var elem in elems)
            {
                Assert.True(elem.Displayed);
            }
        }
    }
}
