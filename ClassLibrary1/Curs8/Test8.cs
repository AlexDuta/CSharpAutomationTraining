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

namespace ClassLibrary1.Curs8
{
    [TestFixture]
    class Test8
    {
        
       
        [Test]
        public void CheckPageTitle()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file://c:/AutomationTraining/TestPages/homepage.html";
            Assert.IsTrue(driver.Title.Equals("Home page"));

        }

        [Test]
        public void EmailInputDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file://c:/AutomationTraining/TestPages/homepage.html";

            var emailInput = driver.FindElement(By.Id("email"));
            Assert.IsTrue(emailInput.Displayed);

        }
        [Test]
        public void PasswordInputDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file://c:/AutomationTraining/TestPages/homepage.html";

            var passwordInput = driver.FindElement(By.Id("password"));
            Assert.IsTrue(passwordInput.Displayed);
        }
        [Test]
        public void LoginButtonDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file://c:/AutomationTraining/TestPages/homepage.html";

            var loginButtonInput = driver.FindElement(By.Id("Login"));
            Assert.IsTrue(loginButtonInput.Displayed);
        }

        [Test]
        public void CheckLinksDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file://c:/AutomationTraining/TestPages/homepage.html";

            var links = driver.FindElements(By.XPath("//a"));
            foreach(var link in links)
            {
                Assert.IsTrue(link.Displayed);
            }
            
        }
    }
}
