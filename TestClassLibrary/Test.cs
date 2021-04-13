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
using TestClassLibrary.Curs7;

namespace TestClassLibrary
{
    [TestFixture]
    public class Test
    {
        //Probleme Curs 7
        //BrowserCurs7 browserCurs7 = new BrowserCurs7();

        //[Test]
        //public void StartBrowserTrue()
        //{
        //    Assert.IsTrue(browserCurs7.StartBrowser());
        //}
        //[Test]
        //public void StartBrowserFalse()
        //{
        //    Assert.IsFalse(browserCurs7.StartBrowser());
        //}
        //[Test]
        //public void GetPagetitleEquals()
        //{
        //    Assert.AreEqual("returns a generic string saying browser is open", browserCurs7.GetPageTitle());
        //}
        //[Test]
        //public void GetPagetitleContains()
        //{
        //    string value = browserCurs7.GetPageTitle();
        //    Assert.IsTrue(value.Contains("generic"));
        //}
        ////[Test]
        ////public void GetPagetitleContains2()
        ////{
        ////    Assert.Contains("generic", browserCurs7.GetPageTitle());
        ////}
        //[Test]
        //public void GetBrowserWidthEquals()
        //{
        //    Assert.AreEqual(15, browserCurs7.GetBrowserWidth());
        //}
        //[Test]
        //public void GetBrowserWidthLess()
        //{
        //    Assert.Less(14, browserCurs7.GetBrowserWidth());
        //}
        //[Test]
        //public void GetBrowserWidthGreater()
        //{
        //    Assert.Greater(16, browserCurs7.GetBrowserWidth());
        //}

        //Probleme Curs 8
        [Test]
        public void CheckPageTitle()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = @"C:\Users\cnegrea\OneDrive - ENDAVA\Desktop\pages\homepage.html";
            driver.Manage().Window.Maximize();
            Assert.IsTrue(driver.Title.Equals("Home page"));
            driver.Close();
        }

        [Test]
        public void EmailInpusIsDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = @"C:\Users\cnegrea\OneDrive - ENDAVA\Desktop\pages\homepage.html";
            driver.Manage().Window.Maximize();
            var emailInput = driver.FindElement(By.Id("email"));
            Assert.IsTrue(emailInput.Displayed);
            driver.Close();
        }
        [Test]
        public void PasswordInputIsDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = @"C:\Users\cnegrea\OneDrive - ENDAVA\Desktop\pages\homepage.html";
            driver.Manage().Window.Maximize();
            var passwordInput = driver.FindElement(By.Id("password"));
            Assert.IsTrue(passwordInput.Displayed);
            driver.Close();
        }
        [Test]
        public void LogginButtonIsDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = @"C:\Users\cnegrea\OneDrive - ENDAVA\Desktop\pages\homepage.html";
            driver.Manage().Window.Maximize();
            var loginButton = driver.FindElement(By.Id("Login"));
            Assert.IsTrue(loginButton.Displayed);
            driver.Close();
        }
        [Test]
        public void LinksDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = @"C:\Users\cnegrea\OneDrive - ENDAVA\Desktop\pages\homepage.html";
            driver.Manage().Window.Maximize();
            var linksOnThePage=driver.FindElements(By.XPath("//a[contains(@href,'html') or contains(@href,'#')]"));
            foreach (var links in linksOnThePage)
            {
                Assert.IsTrue(links.Displayed);
            }
        }

    }
}
