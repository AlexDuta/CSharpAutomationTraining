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

namespace SeleniumProj
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void FirstSeleniumTest()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+ @"\Drivers");
            driver.Url = "file:///c:/Workspace/homepage.html";
            driver.Manage().Window.Maximize();
            Assert.IsTrue(driver.Title.Equals("Home page"));

            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("admin@domain.org");
            driver.FindElement(By.Id("password")).SendKeys("111111");
            //driver.FindElement(By.Id("email")).Clear();

            driver.FindElement(By.Id("Login")).Click();

            Assert.IsTrue(driver.Title.Equals("Dashboard page"));


            //var passwordErrorText = driver.FindElement(By.Id("passwordErrorText"));

            //Assert.IsTrue(passwordErrorText.Displayed);

            var elementsList = driver.FindElements(By.XPath("//a"));

            foreach(var elm in elementsList)
            {
                Assert.IsTrue(elm.Displayed);
            }


            driver.Quit();
            //driver.Close();

        }
    }
}
