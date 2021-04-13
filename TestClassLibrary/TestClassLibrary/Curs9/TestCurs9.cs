using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public void Open()
        {
           driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
           driver.Manage().Window.Maximize();
           driver.Url = @"C:\Users\dbardasan\OneDrive - ENDAVA\Desktop\Pages\homepage.html";
        }

        [Test]
        public void CheckPageTitle()
        {
            Assert.IsTrue(driver.Title.Equals("Home page"));
        }

        [Test]
        public void EmailInputIsDisplayed()
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
        public void LoginButtonIsDisplayed()
        {
            var loginButton = driver.FindElement(By.Id("Login"));
            Assert.IsTrue(loginButton.Displayed);
        }

        [Test]
        public void VerifyDisplayedLinks()
        {
            var elements = driver.FindElements(By.XPath("//a[contains(@href,'html') or contains(@href,'#')]"));
            foreach (var elm in elements)
            {
                Assert.IsTrue(elm.Displayed);
            }
        }

        [Test]
        public void CorrectErrorMessage()
        {
            var emailInput = driver.FindElement(By.Id("email"));
            var passwordInput = driver.FindElement(By.Id("password"));
            var login = driver.FindElement(By.Id("Login"));
            var emailErrorAppears = driver.FindElement(By.Id("emailErrorText"));
            var passwordErrorAppears = driver.FindElement(By.Id("passwordErrorText"));
            emailInput.SendKeys("");
            passwordInput.SendKeys("");
            login.Click();
            Assert.IsTrue(emailErrorAppears.Text.Contains("Email address can't be null"));
            Assert.IsTrue(passwordErrorAppears.Text.Contains("Password can't be null"));
            driver.Navigate().Refresh();
            var emailErrorsNotAppears = driver.FindElement(By.Id("emailErrorText"));
            var passwordErrorNotAppears = driver.FindElement(By.Id("passwordErrorText"));
            Assert.IsTrue(emailErrorsNotAppears.Text == "");
            Assert.IsTrue(passwordErrorNotAppears.Text == "");
        }

        [Test]
        public void VerifyHeaderLinks()
        { 
            var pageHeader = driver.FindElement(By.Id("header"));
            var homePageLink = pageHeader.FindElement(By.XPath(".//*[@href='homepage.html']"));
            var wikiPageLink = pageHeader.FindElement(By.XPath(".//*[@href='wikipage.html']"));
            Assert.IsTrue(homePageLink.Displayed);
            Assert.IsTrue(wikiPageLink.Displayed);
        }

        [Test]
        public void VerifyFooterLinks()
        {
            var pageFooter = driver.FindElement(By.Id("nav"));
            var homePageLink = pageFooter.FindElement(By.XPath(".//*[@href='homepage.html']"));
            var wikiPageLink = pageFooter.FindElement(By.XPath(".//*[@href='wikipage.html']"));
            var contactPageLink = pageFooter.FindElement(By.XPath(".//*[@href='#']"));
            Assert.IsTrue(homePageLink.Displayed);
            Assert.IsTrue(wikiPageLink.Displayed);
            Assert.IsTrue(contactPageLink.Displayed);
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
