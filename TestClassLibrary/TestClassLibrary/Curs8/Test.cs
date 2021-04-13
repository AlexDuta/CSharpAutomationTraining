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

namespace TestClassLibrary.Curs8
{
    class Test
    {
        [Test]
        public void CheckPageTitle()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = @"C:\Users\dbardasan\OneDrive - ENDAVA\Desktop\Pages\homepage.html";
            Assert.IsTrue(driver.Title.Equals("Home page"));
            driver.Close();
        }

        [Test]
        public void EmailInputIsDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = @"C:\Users\dbardasan\OneDrive - ENDAVA\Desktop\Pages\homepage.html";
            var emailInput = driver.FindElement(By.Id("email"));
            Assert.IsTrue(emailInput.Displayed);
            driver.Close();
        }

        [Test]
        public void PasswordInputIsDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = @"C:\Users\dbardasan\OneDrive - ENDAVA\Desktop\Pages\homepage.html";
            var passwordInput = driver.FindElement(By.Id("password"));
            Assert.IsTrue(passwordInput.Displayed);
            driver.Close();
        }

        [Test]
        public void LoginButtonIsDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = @"C:\Users\dbardasan\OneDrive - ENDAVA\Desktop\Pages\homepage.html";
            var loginButton = driver.FindElement(By.Id("Login"));
            Assert.IsTrue(loginButton.Displayed);
            driver.Close();
        }

        [Test]
        public void VerifyDisplayedLinks()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = @"C:\Users\dbardasan\OneDrive - ENDAVA\Desktop\Pages\homepage.html";
            var elements = driver.FindElements(By.XPath("//a[contains(@href,'html') or contains(@href,'#')]"));
            foreach (var elm in elements) {
                Assert.IsTrue(elm.Displayed);
            }
            driver.Close();

        }
    }
}
