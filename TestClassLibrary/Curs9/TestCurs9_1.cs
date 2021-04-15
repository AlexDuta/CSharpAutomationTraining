using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Interactions;

namespace TestClassLibrary.Curs_9
{
    [TestFixture]
    class TestCurs9_1
    {
        IWebDriver driver;
        [SetUp]
        public void InitDriver()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/ebizau/Downloads/homepage.html";
        }
        [Test]
        public void TestTitle()
        {
            Assert.IsTrue(driver.Title.Equals("Home page"));
        }

        [Test]
        public void TestEmailDisplayed()
        {
            Assert.IsTrue(driver.FindElement(By.Id("email")).Displayed);
        }

        [Test]
        public void TestPasswordDisplayed()
        {
            Assert.IsTrue(driver.FindElement(By.Id("password")).Displayed);
        }

        [Test]
        public void TestLoginButtonDisplayed()
        {
            Assert.IsTrue(driver.FindElement(By.Id("Login")).Displayed);
        }

        [Test]
        public void TestLinksDisplayed()
        {
            IReadOnlyCollection<IWebElement> webElements = driver.FindElements(By.XPath("/ul[@id=\"nav\"]/li"));
            foreach(IWebElement element in webElements)
            {
                Assert.IsTrue(element.Displayed);
            }
            
        }
        [Test]
        public void TestValidateErrorMessages()
        {
            IWebElement button = driver.FindElement(By.Id("Login"));
            button.Click();
            IWebElement emailError = driver.FindElement(By.Id("emailErrorText"));
            Assert.IsTrue(emailError.Displayed);
            IWebElement passwordError = driver.FindElement(By.Id("passwordErrorText"));
            Assert.IsTrue(passwordError.Displayed);
            driver.Navigate().Refresh();
            try
            {
                bool displayed = emailError.Displayed;
                displayed = passwordError.Displayed;
                Assert.IsTrue(false);
            } catch(StaleElementReferenceException ex)
            {

            }
        } 

        [TearDown]
        public void destroyDriver(){
            driver.Close();
        }
    }
}
