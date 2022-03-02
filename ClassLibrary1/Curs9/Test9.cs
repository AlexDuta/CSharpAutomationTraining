using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using System.IO;

namespace ClassLibrary1.Curs9
{
    [TestFixture]
    class Test9
    {
        public IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file://c:/AutomationTraining/TestPages/homepage.html";
            driver.Manage().Window.Maximize();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void CheckPageTitleC9()
        {
            SetUp();
            Assert.IsTrue(driver.Title.Equals("Home page"));
            TearDown();

        }

        [Test]
        public void EmailInputDisplayedC9()
        {
            SetUp();

            var emailInput = driver.FindElement(By.Id("email"));
            Assert.IsTrue(emailInput.Displayed);

            TearDown();
        }
        [Test]
        public void PasswordInputDisplayedC9()
        {
            SetUp();

            var passwordInput = driver.FindElement(By.Id("password"));
            Assert.IsTrue(passwordInput.Displayed);

            TearDown();
        }
        [Test]
        public void LoginButtonDisplayedC9()
        {
            SetUp();

            var loginButtonInput = driver.FindElement(By.Id("Login"));
            Assert.IsTrue(loginButtonInput.Displayed);

            TearDown();
        }

        [Test]
        public void CheckLinksDisplayedC9()
        {
            SetUp();

            var links = driver.FindElements(By.XPath("//a"));
            foreach (var link in links)
            {
                Assert.IsTrue(link.Displayed);
            }

            TearDown();
        }

        [Test]
        public void CheckErrorMessages()
        {
            SetUp();

            var loginButton = driver.FindElement(By.Id("Login"));
            loginButton.Click();

            var emailErrorMsg = driver.FindElement(By.Id("emailErrorText"));
            var passwordErrorMsg = driver.FindElement(By.Id("passwordErrorText"));

            Assert.IsTrue(emailErrorMsg.Displayed);
            Assert.IsTrue(passwordErrorMsg.Displayed);

            driver.Navigate().Refresh();

            var emailErrorMsg2 = driver.FindElement(By.Id("emailErrorText"));
            var passwordErrorMsg2 = driver.FindElement(By.Id("passwordErrorText"));

            Assert.IsFalse(emailErrorMsg2.Displayed);
            Assert.IsFalse(passwordErrorMsg2.Displayed);

            TearDown();
        }

        [Test]
        public void CheckHeaderLinks()
        {
            SetUp();

            var header = driver.FindElement(By.Id("header"));
            var links = header.FindElement(By.XPath(".//div//a"));

            Assert.IsTrue(links.Displayed);

            TearDown();
        }
        [Test]
        public void CheckFooterLinks()
        {
            SetUp();

            var links = driver.FindElements(By.XPath("//footer//a"));
            foreach(var link in links)
            {
                
                Assert.IsTrue(link.Displayed);
            }

            TearDown();

        }
    }
}
