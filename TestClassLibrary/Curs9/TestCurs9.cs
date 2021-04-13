using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
            driver.Url = @"C:\Users\cnegrea\OneDrive - ENDAVA\Desktop\pages\homepage.html";
            driver.Manage().Window.Maximize();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void CheckPageTitle()
        {
            Assert.IsTrue(driver.Title.Equals("Home page"));
        }
        [Test]
        public void EmailInpusIsDisplayed()
        {
            var emailInput = driver.FindElement(By.Id("email"));
            Assert.IsTrue(emailInput.Displayed);
        }
        [Test]
        public void PasswordInputIsDisplayed()
        {
            var passwordInput = driver.FindElement(By.Id("password"));
            Assert.IsTrue(passwordInput.Displayed);
        }
        [Test]
        public void LogginButtonIsDisplayed()
        {
            var loginButton = driver.FindElement(By.Id("Login"));
            Assert.IsTrue(loginButton.Displayed);
        }
        [Test]
        public void LinksDisplayed()
        {
            var linksOnThePage = driver.FindElements(By.XPath("//a"));
            foreach (var links in linksOnThePage)
            {
                Assert.IsTrue(links.Displayed);
            }
        }
        [Test]
        public void ErrorMessagesDisplayed()
        {
            var loginButton = driver.FindElement(By.Id("Login"));
            loginButton.Click();
            var errorMessageEmail = driver.FindElement(By.Id("emailErrorText"));
            var errormessagePasword = driver.FindElement(By.Id("passwordErrorText"));
            Assert.IsTrue(errorMessageEmail.Displayed);
            Assert.IsTrue(errormessagePasword.Displayed);

            driver.Navigate().Refresh();

            var notErrorMessageEmail=driver.FindElement(By.XPath("//*[@id='emailErrorText']"));
            var notErrorMessagePassword=driver.FindElement(By.XPath("//*[@id='passwordErrorText']"));
            Assert.IsEmpty(notErrorMessageEmail.Text);
            Assert.IsEmpty(notErrorMessagePassword.Text);
            Thread.Sleep(1000);
        }
        [Test]
        public void HeaderLinks()
        {
            var header = driver.FindElement(By.Id("header"));
            var headerHomeLink = header.FindElement(By.XPath(".//*[@href='homepage.html']"));
            var headerWikipageLink = header.FindElement(By.XPath(".//*[@href='wikipage.html']"));
            Assert.IsTrue(headerHomeLink.Displayed);
            Assert.IsTrue(headerWikipageLink.Displayed);
        }
        [Test]
        public void FooterLinks()
        {
            var footer = driver.FindElement(By.Id("nav"));
            var footerHomeLink = footer.FindElement(By.XPath(".//*[@href='homepage.html']"));
            var footerWikipageLink = footer.FindElement(By.XPath(".//*[@href='wikipage.html']"));
            var footerContactLink = footer.FindElement(By.XPath(".//*[@href='#']"));
            Assert.IsTrue(footerHomeLink.Displayed);
            Assert.IsTrue(footerWikipageLink.Displayed);
            Assert.IsTrue(footerContactLink.Displayed);
        }
    }
}
