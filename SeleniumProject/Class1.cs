using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumProject.Curs7;
using OpenQA.Selenium;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Threading;
using SeleniumExtras.WaitHelpers;

namespace SeleniumProject
{
    
    [TestFixture]
    
    public class Class1
    {
       
        //[SetUp] - method will be called before each test method (e.g. create a new driver instance)
        public IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "C:/CSharp_Automation/CSharpAutomationTraining/wikipage.html";
        }
        public void SetUp2()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "C:/CSharp_Automation/CSharpAutomationTraining/homepage.html";
        }

        //[TearDown] - method will be called after each test method (e.g. call driver.Quit())
        [TearDown]
        public void TearDown()
        {
           // driver.Quit();
        }
        /* Curs 10 - tema */
        /* Curs 10*/
        [Test]
        public void TestWaits()
        {
            //  Thread.Sleep(4000);

            // WaitElemetToBeVisible(driver, By.Id("htmlVersion"),5);

           // DefaultWait<IWebDriver> defaultWait = new DefaultWait<IWebDriver>(driver);
           // defaultWait.Timeout = TimeSpan.FromSeconds(5);
           // defaultWait.PollingInterval = TimeSpan.FromMilliseconds(250);
           // defaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotInteractableException));
           // defaultWait.Message = "Element ";
            //defaultWait.Until(driver =>driver.FindElement(By.Id("htmlVersion")).Displayed);
           
            driver.Manage().Timeouts().ImplicitWait= TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("htmlVersion")).SendKeys("test");
            var isPresent = IsElementPresent(By.Id("htmlVersion"));
            Assert.IsTrue(isPresent);

            // navigate
            driver.Navigate().GoToUrl("https://www.google.com");
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.Navigate().Forward();
            Thread.Sleep(2000);
            driver.Navigate().Refresh();


        }
        //element vizibil si prezent in html
        public void WaitElemetToBeVisible( IWebDriver driver , By elementBy , int timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
       
            wait.Until(ExpectedConditions.ElementIsVisible(elementBy));

        }

        private bool IsElementPresent(By element)
        {
            try
            {
                driver.FindElement(element);
                return true;
            }
            catch(NoSuchElementException e)
            {
                return false;
            }
        }
        /* Curs 9 - tema*/
        [Test]
        public void TestCurs9Tema1()
        {
            SetUp2();
            var loginButton = driver.FindElement(By.XPath("//button[@id='Login']"));
            loginButton.Click();
            Assert.True(driver.FindElement(By.Id("emailErrorText")).Displayed);
            Assert.True(driver.FindElement(By.Id("passwordErrorText")).Displayed);
           driver.Navigate().Refresh();
            Assert.False(driver.FindElement(By.Id("emailErrorText")).Displayed);
            Assert.False(driver.FindElement(By.Id("passwordErrorText")).Displayed);
            TearDown();
        }

        public IWebDriver GetDriver()
        {
            return driver;
        }

        [Test]
        public void testHeaderFooterLinks()
        {
            SetUp();
            var elements = driver.FindElements(By.XPath("//header//a/@href"));
            foreach (WebElement elm in elements)
            {
                Assert.True(elm.Displayed);
            }
            TearDown();

           

        }
        /* Curs 9 */
        [Test]
        public void TestCurs9()
        {
            SetUp();
            var bikeCheckBox = driver.FindElement(By.XPath("//input[@value='Bike']"));
            bikeCheckBox.Click();
            Assert.AreEqual(true, bikeCheckBox.Selected); // returneaza bool

            SelectElement a = new SelectElement(driver.FindElement(By.Id("htmlversions")));
            a.SelectByText("HTML 5");
            a.SelectByValue("2");

            var fileInput = driver.FindElement(By.Name("picture"));
            fileInput.SendKeys("C:/CSharp_Automation/CSharpAutomationTraining/rebe.png");

     //refresh
            Actions action = new Actions(driver); 
            action.SendKeys(Keys.F5).Perform();

            var textArea = driver.FindElement(By.Id("textArea"));
            textArea.Click();
           // textArea.SendKeys("hello");
           //selectez text ctr+a
           action.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).Perform();
            //copiez textul ctr+c
            action.KeyDown(Keys.Control).SendKeys("c").KeyUp(Keys.Control).Perform();
            //pun textul
            action.KeyDown(Keys.Control).SendKeys("v").KeyUp(Keys.Control).Perform();
            TearDown();


        }
        /*Curs 8 - tema */
        [Test]
        public void TestPageTitle()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "C:/CSharp_Automation/CSharpAutomationTraining/homepage.html";
            Assert.True(driver.Title.Equals("Home page"));
            driver.Quit();         
        }
        [Test]
        public void TestPageEmail()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "C:/CSharp_Automation/CSharpAutomationTraining/homepage.html";
            Assert.True(driver.FindElement(By.Id("email")).Displayed);           
            driver.Quit();
        }

        [Test]
        public void TestPagePassword()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "C:/CSharp_Automation/CSharpAutomationTraining/homepage.html";
            Assert.True(driver.FindElement(By.Id("password")).Displayed);
            driver.Quit();
        }

        [Test]
        public void TestPageLogin()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "C:/CSharp_Automation/CSharpAutomationTraining/homepage.html";
            Assert.True(driver.FindElement(By.XPath("//button[@id='Login']")).Displayed);
            driver.Quit();
        }

        [Test]
        public void TestAllLinks()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "C:/CSharp_Automation/CSharpAutomationTraining/homepage.html";
            var elements = driver.FindElements(By.XPath("//a/@href"));
         //   var getAttribute = elements.GetAttribute("value");
            foreach (var elm in elements)
            {
                Assert.True(elm.Displayed);
            }
            driver.Quit();
        }
        /*Curs 8*/
        [Test]
        public void FirstSeleniumTest()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers"); 
            driver.Url = "C:/CSharp_Automation/CSharpAutomationTraining/homepage.html"; 
            Assert.True(driver.Title.Equals("Home page"));
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("admin@domain.org");
            driver.FindElement(By.Id("password")).SendKeys("111111");
            driver.FindElement(By.Id("Login")).Click(); 
            Assert.True(driver.FindElement(By.Id("email")).Displayed);       
            driver.Quit();       
        }
            /*Curs 7 - tema*/
            [Test]
        public void TestStartBrowser()
        {
            Browser browser= new Browser();
            Assert.IsTrue(browser.StartBrowser());
            Assert.AreEqual("False", browser.StartBrowser());
        }

        [Test]
        public void TestGetPageTitle()
        {
            Browser browser = new Browser();
            Assert.AreEqual("browser is open",browser.GetPageTitle());
            //Assert.Contains("open",browser.GetPageTitle(), "contine stringul");
            Assert.AreNotEqual("browser is closed", browser.GetPageTitle());
        }

        [Test]
        public void TestGetBrowserWidth()
        {
            Browser browser = new Browser();
            Assert.AreEqual(1890 , browser.GetBrowserWidth());
            Assert.Less(1234, browser.GetBrowserWidth());
            Assert.Greater(1999, browser.GetBrowserWidth());
        }
        /* Curs 7*/
        [Test]
        public void TestMethod1()
        {
            Console.WriteLine("test method1");
            Assert.IsTrue(2 == 2);
        }

        [Test]
        public void TestMethod2()
        {
            Console.WriteLine("test method2");
            Assert.AreEqual(true, 2 == 3, "test2");
        }
    }
}
