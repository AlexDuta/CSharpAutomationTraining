using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumProject
{
    [TestFixture]
    public class TestClass : TestBase
    {
        
        [Test]
        public void Curs10Test()
        {
            driver.FindElement(By.XPath(".//*[@id='navHeader']/a[2]")).Click(); 
            WaitElementToBeVisible(driver, By.XPath(".//*[@id='htmlVersion']"), 10); 
            driver.FindElement(By.XPath(".//*[@id='htmlVersion']")).SendKeys("aaa");
        }

        public void WaitElementToBeVisible(IWebDriver driver, By element, int timeOut) 
        { 
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut)); 
            var waitCondition = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
        }

        /* --tema9
        [Test]
        public void Curs9Test()
        {
            IWebElement LoginBtn = driver.FindElement(By.Id("Login"));
            LoginBtn.Click();
            Assert.True(driver.FindElement(By.Id("emailErrorText")).Displayed);
            Assert.True(driver.FindElement(By.Id("passwordErrorText")).Displayed);

            driver.Navigate().Refresh();

            Assert.False(driver.FindElement(By.Id("emailErrorText")).Displayed);
            Assert.False(driver.FindElement(By.Id("passwordErrorText")).Displayed);

        }

        [Test]
        public void HeaderLinksTest()
        {
            IWebElement header = driver.FindElement(By.Id("header"));
            var elements = header.FindElements(By.XPath(".//a"));
            foreach (var element in elements)
            {
                Assert.True(element.Displayed);
            }
        }

        [Test]
        public void FooterLinksTest()
        {
            IWebElement footer = driver.FindElement(By.XPath("//footer"));
            var elements = footer.FindElements(By.XPath(".//a"));
            foreach (var element in elements)
            {
                Assert.True(element.Displayed, "error");
            }
        }

        --tema8
        [Test]
        public void FirstSeleniumTest()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Workspace/homepage.html";
            Assert.True(driver.Title.Equals("Home page")); 
            driver.FindElement(By.Id("email")).SendKeys("admin@domain.org"); 
            driver.FindElement(By.Id("Login")).Click(); 
            Assert.True(driver.FindElement(By.Id("email")).Displayed); 
            driver.Quit();

        }

        [Test]
        public void PageTitleTest()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Workspace/homepage.html";
            Assert.True(driver.Title.Equals("Home page"));
            driver.Quit();

        }

        [Test]
        public void EmailInputTest()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Workspace/homepage.html";
            Assert.True(driver.FindElement(By.Id("email")).Displayed);
            driver.Quit();

        }

        [Test]
        public void PasswordInputTest()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Workspace/homepage.html";
            Assert.True(driver.FindElement(By.Id("password")).Displayed);
            driver.Quit();

        }

        [Test]
        public void LoginBtnTest()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Workspace/homepage.html";
            Assert.True(driver.FindElement(By.Id("Login")).Displayed);
            driver.Quit();

        }

        [Test]
        public void LinksTest()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Workspace/homepage.html";
            var elements = driver.FindElements(By.XPath("//a"));

            foreach(var element in elements)
            {
                Assert.True(element.Displayed);
            }
            driver.Quit();

        }

        --tema 7

        [Test]
        public void TestMethod1()
        {
            Browser browser = new Browser();
            Assert.IsTrue(browser.StartBrowser());
         
        }

        [Test]
        public void TestMethod2()
        {
            Browser browser = new Browser();
            Assert.IsFalse(browser.StartBrowser());

        }

        [Test]
        public void TestMethod3()
        {
            Browser browser = new Browser();
            Assert.AreEqual("Browser is open",browser.GetPageTitle());

        }

        [Test]
        public void TestMethod4()
        {
            Browser browser = new Browser();
            Assert.AreEqual("Browser is not open", browser.GetPageTitle());

        }

        [Test]
        public void TestMethod5()
        {
            Browser browser = new Browser();
            Assert.AreEqual(1000, browser.GetBrowserWidth());

        }

        [Test]
        public void TestMethod6()
        {
            Browser browser = new Browser();
            Assert.Greater(1200, browser.GetBrowserWidth());

        }

        [Test]
        public void TestMethod7()
        {
            Browser browser = new Browser();
            Assert.Less(800, browser.GetBrowserWidth());

        }*/
    }
}
