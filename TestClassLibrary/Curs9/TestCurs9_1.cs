using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace TestClassLibrary.Curs8
{
    [TestFixture]
    class TestCurs9_1
    {
        IWebDriver driver;
        Actions action;
        [SetUp]
        public void InitDriver()
        {
           driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
           driver.Url = "file://C:/trainingpage/homepage.html";
            driver.Manage().Window.Maximize();
            action = new Actions(driver);
        }
        [TearDown]
        public void DestroyDriver()
        {
            driver.Quit();
        }

        [Test]
        public void CheckPageTitle()
        {
            Assert.IsTrue(driver.Title.Equals("Home page"));
        }
        [Test]
        public void CheckEmailInputIsDisplayed()
        {
            Assert.IsTrue(driver.FindElement(By.Id("email")).Displayed);
        }
        [Test]
        public void CheckPasswordInputIsDisplayed()
        {
            Assert.IsTrue(driver.FindElement(By.Id("password")).Displayed);
        }
        [Test]
        public void CheckLoginButtonIsDisplayed()
        {
            Assert.IsTrue(driver.FindElement(By.Id("Login")).Displayed);
        }
        [Test]
        public void CheckAllElemsAreDisplayed()
        {
            var elems = driver.FindElements(By.XPath("//a[@href]"));
            foreach(var elem in elems)
            {
                Assert.IsTrue(elem.Displayed);
            }
        }
        [Test]
        public void CheckNoEmailAndPassSubmit()
        {
            var loginButton = driver.FindElement(By.Id("Login"));
            loginButton.Click();
            var passMessage = driver.FindElement(By.Id("passwordErrorText"));
            var emailMessage = driver.FindElement(By.Id("emailErrorText"));
            Assert.IsTrue(emailMessage.Displayed);
            Assert.IsTrue(passMessage.Displayed);
            Assert.IsTrue(emailMessage.Text.Equals("Email address can't be null"));
            Assert.IsTrue(passMessage.Text.Equals("Password can't be null"));
            //action.SendKeys(Keys.F5).perform() doesn't work
            driver.Navigate().Refresh();
            passMessage = driver.FindElement(By.Id("passwordErrorText"));
            emailMessage = driver.FindElement(By.Id("emailErrorText"));
            Assert.IsFalse(emailMessage.Displayed);
            Assert.IsFalse(passMessage.Displayed);
        }
        [Test]
        public void CheckFooterHeaderLinks()
        {
            var elems = driver.FindElements(By.Id("navHeader"));
            foreach(var elem in elems)
            {
                Assert.True(elem.Displayed);
            }
            elems = driver.FindElements(By.Id("nav"));
            foreach (var elem in elems)
            {
                Assert.True(elem.Displayed);
            }
        }
    }
}
