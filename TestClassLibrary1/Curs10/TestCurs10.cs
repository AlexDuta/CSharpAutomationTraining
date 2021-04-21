using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary1.Curs10
{
    class TestCurs10 : TestBaseCurs10
    {
        [Test]
        public void VerifyPageTitle()
        {
            Assert.True(driver.Title.Equals("Home page"));
            driver.Quit();
        }
        [Test]
        public void EmailInputIsDisplayed()
        {
            var emailInput = driver.FindElement(By.Id("email"));
            bool visibility = emailInput.Displayed && emailInput.Enabled;
            Assert.IsTrue(visibility);
            driver.Quit();

        }
        [Test]
        public void PasswordInputIsDisplayed()
        {
            var passwordInput = driver.FindElement(By.Id("password"));
            bool visibility = passwordInput.Displayed && passwordInput.Enabled;
            Assert.IsTrue(visibility);
            driver.Quit();
        }
        [Test]
        public void LogInButtonIsDisplayed()
        {
            var logInButton = driver.FindElement(By.Id("Login"));
            bool visibility = logInButton.Enabled && logInButton.Displayed;
            Assert.IsTrue(visibility);
            driver.Quit();
        }
        [Test]
        public void ErrorMessageIsCorrect()
        {
            //Actions action = new Actions(driver);
            var emailInput = driver.FindElement(By.Id("email"));
            var passwordInput = driver.FindElement(By.Id("password"));
            var actualEmailErrorMessage = driver.FindElement(By.Id("emailErrorText"));
            var actualPasswordErrorMessage = driver.FindElement(By.Id("passwordErrorText"));
            var logInButton = driver.FindElement(By.Id("Login"));
            string expectedErrorMessageEmail = "Email address can't be null";
            string expectederrorMessagePassword = "Password can't be null";

            emailInput.SendKeys("");
            passwordInput.SendKeys("");
            logInButton.Click();

            Assert.AreEqual(expectedErrorMessageEmail, actualEmailErrorMessage.Text);
            Assert.AreEqual(expectederrorMessagePassword, actualPasswordErrorMessage.Text);
        }
        [Test]
        public void verifyHeaderLink()
        {
            var header = driver.FindElement(By.Id("header"));
            var link = header.FindElement(By.XPath("//*[@id='navHeader']/a"));
            Assert.IsTrue(link.Displayed);
        }
        [Test]
        public void verifyFooterLinks()
        {
            var footer = driver.FindElement(By.XPath("/html/body/footer"));
            var link1 = footer.FindElement(By.XPath("//*[@id='nav']/li[1]/a"));
            var link2 = footer.FindElement(By.XPath("//*[@id='nav']/li[2]/a"));
            var link3 = footer.FindElement(By.XPath("//*[@id='nav']/li[3]/a"));
            Assert.IsTrue(link1.Displayed);
            Assert.IsTrue(link2.Displayed);
            Assert.IsTrue(link3.Displayed);
        }
    }
}
