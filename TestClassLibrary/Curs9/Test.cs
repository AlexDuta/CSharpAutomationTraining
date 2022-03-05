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

namespace TestClassLibrary.Curs9
{
    [TestFixture]
    public class Test
    {
        public IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///c:/Workspace/homepage.html";
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void TestPageTitle()
        {
            SetUp();
            Assert.IsTrue(driver.Title.Equals("Home page"));
            TearDown();
        }

        [Test]
        public void TestEmailInputDisplayed()
        {
            SetUp();
            var emailInput = driver.FindElement(By.XPath("//input[@id='email']"));
            Assert.IsTrue(emailInput.Displayed);
            TearDown();
        }

        [Test]
        public void TestPasswordInputDisplayed()
        {
            SetUp();
            var passwordInput = driver.FindElement(By.Id("password"));
            Assert.IsTrue(passwordInput.Displayed);
            TearDown();
        }

        [Test]
        public void TestLoginBtnDisplayed()
        {
            SetUp();
            var loginBtn = driver.FindElement(By.Id("Login"));
            Assert.IsTrue(loginBtn.Displayed);
            TearDown();
        }
        [Test]
        public void VerifyLinks()
        {
            SetUp();
            var elementsList = driver.FindElements(By.XPath("//a"));

            foreach (var elm in elementsList)
            {
                Assert.IsTrue(elm.Displayed);
            }

            TearDown();
        }

        [Test]
        public void ValidateErrorNoInput()
        {
            SetUp();

            
            var emailErrorText = driver.FindElement(By.Id("emailErrorText"));
            var passwordErrorText = driver.FindElement(By.Id("passwordErrorText"));

            driver.FindElement(By.Id("Login")).Click();

            Assert.AreEqual("Email address can't be null", emailErrorText.Text);
            Assert.AreEqual("Password can't be null", passwordErrorText.Text);

            Actions action = new Actions(driver);
            action.SendKeys(Keys.F5).Perform(); driver.Navigate().Refresh();

            emailErrorText = driver.FindElement(By.Id("emailErrorText"));
            passwordErrorText = driver.FindElement(By.Id("passwordErrorText"));

            Assert.AreEqual("", emailErrorText.Text);
            Assert.AreEqual("", passwordErrorText.Text);


            TearDown();
        }

        [Test]
        public void VerifyHeaderLinks()
        {
            SetUp();

            IWebElement header = driver.FindElement(By.Id("header"));
            var url = header.FindElement(By.XPath(".//a"));
            Assert.IsTrue(url.Displayed);

            header = driver.FindElement(By.Id("myDivHeader"));
            var links = header.FindElements(By.XPath(".//header/ul/a"));

            foreach(var link in links)
            {
                Assert.IsTrue(link.Displayed);
            }

            TearDown();
        }

        [Test]
        public void VerifyFooterLinks()
        {
            SetUp();

            IWebElement footer = driver.FindElement(By.XPath("/html/body/footer"));
            var links = footer.FindElements(By.XPath(".//ul/li"));

            foreach(var link in links)
            {
                Assert.IsTrue(link.Displayed);
            }

            TearDown();
        }
    }
}
