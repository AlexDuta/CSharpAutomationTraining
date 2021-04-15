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

namespace TestClassLibrary1.Curs8
{
    class TestCurs8
    {
        [Test]
        public void VerifyPageTitle()
        {
            OpenQA.Selenium.IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aniordache/Downloads/homepage.html";
            Assert.True(driver.Title.Equals("Home page"));
            driver.Quit();
        }
        [Test]
        public void EmailInputIsDisplayed()
        {
            OpenQA.Selenium.IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aniordache/Downloads/homepage.html";
            var emailInput = driver.FindElement(By.Id("email"));
            bool visibility = emailInput.Displayed&&emailInput.Enabled;
            Assert.IsTrue(visibility);
            driver.Quit();

        }
        [Test]
        public void PasswordInputIsDisplayed()
        {
            OpenQA.Selenium.IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aniordache/Downloads/homepage.html";
            var passwordInput = driver.FindElement(By.Id("password"));
            bool visibility = passwordInput.Displayed && passwordInput.Enabled;
            Assert.IsTrue(visibility);
            driver.Quit();
        }
        [Test]
        public void LogInButtonIsDisplayed()
        {
            OpenQA.Selenium.IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aniordache/Downloads/homepage.html";
            var logInButton = driver.FindElement(By.Id("Login"));
            bool visibility = logInButton.Enabled && logInButton.Displayed;
            Assert.IsTrue(visibility);
            driver.Quit();
        }

    }
}
