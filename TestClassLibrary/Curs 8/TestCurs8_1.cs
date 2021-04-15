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

namespace TestClassLibrary.Curs_8
{
    [TestFixture]
    class TestCurs8_1
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
            driver.Close();
        }

        [Test]
        public void TestEmailDisplayed()
        {
            Assert.IsTrue(driver.FindElement(By.Id("email")).Displayed);
            driver.Close();
        }

        [Test]
        public void TestPasswordDisplayed()
        {
            Assert.IsTrue(driver.FindElement(By.Id("password")).Displayed);
            driver.Close();
        }

        [Test]
        public void TestLoginButtonDisplayed()
        {
            Assert.IsTrue(driver.FindElement(By.Id("Login")).Displayed);
            driver.Close();
        }

        [Test]
        public void TestLinksDisplayed()
        {
            IReadOnlyCollection<IWebElement> webElements = driver.FindElements(By.XPath("/ul[@id=\"nav\"]/li"));
            foreach(IWebElement element in webElements)
            {
                Assert.IsTrue(element.Displayed);
            }
            driver.Close();
        }
    }
}
