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

namespace SeleniumProject
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void FirstSeleniumTest()
        {
            // Import the driver and the Chrome page
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Pages/homepage.html";
            driver.Manage().Window.Maximize();

            // Check if the page's title is "Home page"
            Assert.IsTrue(driver.Title.Equals("Home page"));
            Assert.IsFalse(!driver.Title.Equals("Home page"));

            // Enter the admin email without the password
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("admin@domain.org");
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("111111");
            // driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("Login")).Click();

            // Check if it arrives in the Dshboard page
            Assert.IsTrue(driver.Title.Equals("Dashboard page"));

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
            // driver.Quit();
            // driver.Close();
        }
    }
}
