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
using System.Threading;
using System.Threading.Tasks;

namespace TestClassLibrary.Curs9
{
    [TestFixture]
    class TestCurs9
    { 
        public IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = @"C:\Users\atpop\OneDrive - ENDAVA\Desktop\homepage.html";
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void CheckPageTitleTest()
        {
            Assert.IsTrue(driver.Title.Equals("Home page"));
        }

        [Test]
        public void EmailInputTest()
        {
            var emailInput = driver.FindElement(By.Id("email"));
            Assert.IsTrue(emailInput.Displayed);
        }

        [Test]
        public void PasswordInputTest()
        {
            var passwordInput = driver.FindElement(By.Id("password"));
            Assert.IsTrue(passwordInput.Displayed);
        }

        [Test]
        public void LoginButtonTest()
        {
            var loginButton = driver.FindElement(By.Id("Login"));
            Assert.IsTrue(loginButton.Displayed);
        }

        [Test]
        public void LinksDisplayedTest()
        {
            var header = driver.FindElement(By.Id("navHeader"));
            var linksHeader = header.FindElements(By.XPath(".//*[contains(@href, 'html')]"));
            var footer = driver.FindElement(By.Id("nav"));
            var linksFooter = footer.FindElements(By.XPath(".//*[contains(@href, 'html') or contains(@href,'#')]"));
            foreach (var element in linksHeader)
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine(element.Text + element.GetAttribute("html"));
            }
            foreach (var element in linksFooter)
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine(element.Text + element.GetAttribute("html"));
            }
        }

        [Test]
        public void ErrorMessageDisplayedTest()
        {
            var emailInput = driver.FindElement(By.Id("email"));
            //emailInput.SendKeys("");
            var emailErrorText = driver.FindElement(By.Id("emailErrorText"));

            var passwordInput = driver.FindElement(By.Id("password"));
            //passwordInput.SendKeys("");
            var passwordErrorText = driver.FindElement(By.Id("passwordErrorText"));

            var loginButton = driver.FindElement(By.XPath("//*[@id='Login']"));
            loginButton.Click();

            Assert.IsTrue(emailErrorText.Displayed);
            Assert.IsTrue(passwordErrorText.Displayed);

            // Actions actions = new Actions(driver);
            // actions.SendKeys(Keys.F5).Perform();
            driver.Navigate().Refresh();

            Thread.Sleep(3000);
        }        
    }
}
