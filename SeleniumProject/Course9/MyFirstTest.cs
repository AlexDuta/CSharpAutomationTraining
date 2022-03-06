using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.Course9
{
    [TestFixture]
    public class MyFirstTest
    {
        public IWebDriver driver;
        public Actions action;

        [SetUp]
        public void SetUp()
        {
            // Import the driver and the Chrome page
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            action = new Actions(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            // driver.Close();
        }


        [Test]
        public void FirstSeleniumTest()
        {
            // Setting up
            SetUp();

            // Check if the page's title is "Home page"
            Assert.IsTrue(driver.Title.Equals("Home page"), "Verify the Window's Title");
            Assert.IsFalse(!driver.Title.Equals("Home page"));

            /*
            var header = driver.FindElement(By.Id("header"));
            header.FindElement(By.XPath(".//a/img")).Click;
            */

            // Enter the admin email without the password
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("admin@domain.org");
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("111111");
            driver.FindElement(By.Id("Login")).Click();

            // Check if it arrives in the Dshboard page
            Assert.IsTrue(driver.Title.Equals("Dashboard page"), "Verify Dashboard Page");

            // Complete the first name and last name fields
            var firstName = driver.FindElement(By.Id("firstname"));
            var getAttribute = firstName.GetAttribute("value");

            //
            Assert.AreEqual("Dave", getAttribute, "info");

            var bikeCheckbox = driver.FindElement(By.XPath("//input[@value='Bike']"));
            bikeCheckbox.Click();
            Assert.AreEqual(true, bikeCheckbox.Selected);

            SelectElement dropDownList = new SelectElement(driver.FindElement(By.Id("htmlversions")));
            dropDownList.SelectByText("HTML 3.2");
            dropDownList.SelectByValue("5");

            var fileInput = driver.FindElement(By.Name("picture"));
            // fileInput.SendKeys("C:\\Users\\ADragu\\Downloads\\C# Automation Courses\\Curs1.pdf");

            Actions action = new Actions(driver);
            action.SendKeys(Keys.F5).Perform(); // driver.Navigate().Refresh()

            var textArea = driver.FindElement(By.Id("textArea"));
            textArea.Click();
            textArea.SendKeys("Test Automation");
            action.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).Perform();
            action.KeyDown(Keys.Control).SendKeys("c").KeyUp(Keys.Control).Perform();
            action.KeyDown(Keys.Control).SendKeys("v").KeyUp(Keys.Control).Perform();
            action.KeyDown(Keys.Control).SendKeys("v").KeyUp(Keys.Control).Perform();
            action.KeyDown(Keys.Control).SendKeys("v").KeyUp(Keys.Control).Perform();

            /*
            var elementsList = driver.FindElements(By.XPath("//a"));
            foreach(var elm in elementsList)
            {
                Assert.IsTrue(elm.Displayed);
            }
            */

            // Check if the password error message is displayed
            // IWebElement passwordErrorText = driver.FindElement(By.Id("passwordErrorText"));
            // Assert.IsTrue(passwordErrorText.Displayed);

            // Quit - close all the instances
            // Close - close the current instance
            TearDown();
        }
    }
}
