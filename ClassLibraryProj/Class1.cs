using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace ClassLibraryProj
{
    public class Class1
    {

        public IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = @"C:\Users\lgrecu\OneDrive - ENDAVA\Desktop\pages\homepage.html";
            driver.Manage().Window.Maximize();
        }


        [TearDown]
        public void TearDown()
        {
            // driver.Quit();
        }


        [Test]
        public void FirstNunitTest()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void FirstSeleniumTest()
        {

            //IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            //driver.Url = @"C:\Users\lgrecu\OneDrive - ENDAVA\Desktop\pages\homepage.html";
            //driver.Manage().Window.Maximize();
            Assert.IsTrue(driver.Title.Equals("Home page"));

            var pageHeader = driver.FindElement(By.Id("header"));
            var wikipageLink = pageHeader.FindElement(By.XPath(".//*[@href='wikipage.html']"));
            Assert.IsTrue(wikipageLink.Displayed);

            var inputList = driver.FindElements(By.TagName("input"));
            foreach (var element in inputList)
            {
                Assert.IsTrue(element.Displayed);
            }

            var emailInput = driver.FindElement(By.Id("email"));
            emailInput.SendKeys("admin@domain.org");
            Console.WriteLine("email input value: '" + emailInput.GetAttribute("value") + "'");
            var passwordInput = driver.FindElement(By.Id("password"));
            passwordInput.SendKeys("111111");
            passwordInput.Clear();
            var loginButton = driver.FindElement(By.XPath("//*[@type='submit']"));
            loginButton.Click();
            var passwErrorMessage = driver.FindElement(By.Id("passwordErrorText"));
            Assert.IsTrue(passwErrorMessage.Displayed);
            Thread.Sleep(3000);
            ///driver.Quit();
        }

        [Test]
        public void SecondSelTest()
        {
            //IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            //driver.Url = @"C:\Users\lgrecu\OneDrive - ENDAVA\Desktop\pages\dashboardpage.html";
            //driver.Manage().Window.Maximize();

            var emailInput = driver.FindElement(By.Id("email"));
            emailInput.SendKeys("admin@domain.org");
            var passwordInput = driver.FindElement(By.Id("password"));
            passwordInput.SendKeys("111111");
            var loginButton = driver.FindElement(By.XPath("//*[@type='submit']"));
            loginButton.Click();


            var maleradioButton = driver.FindElement(By.XPath("//*[@value='male']"));
            Assert.IsTrue(maleradioButton.Selected);
            var femaleRadioButton = driver.FindElement(By.XPath("//*[@value='female']"));
            femaleRadioButton.Click();
            Assert.IsTrue(femaleRadioButton.Selected);

            var bikeCheckbox = driver.FindElement(By.Name("vehicle1"));
            bikeCheckbox.Click();
            Assert.IsTrue(bikeCheckbox.Selected);

            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id("htmlversions")));
            dropdown.SelectByText("HTML 3.2");

            driver.FindElement(By.Name("picture")).SendKeys(@"C:\Users\lgrecu\OneDrive - ENDAVA\Desktop\rucsac.jpg");

            Actions actions = new Actions(driver);
            driver.FindElement(By.Id("textArea")).SendKeys("test22");

            ///actions.SendKeys(Keys.F5).Perform();
            //driver.Navigate().Refresh();

            actions.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).Perform();
            actions.KeyDown(Keys.Control).SendKeys("c").KeyUp(Keys.Control).Perform();
            actions.KeyDown(Keys.Control).SendKeys("v").KeyUp(Keys.Control).Perform();
            actions.SendKeys(Keys.Enter).Perform();
            actions.KeyDown(Keys.Control).SendKeys("v").KeyUp(Keys.Control).Perform();

        }

        [Test]
        public void TestWikiPage()
        {
            var wikiLink = driver.FindElement(By.XPath("//*[@id='navHeader']//a[@href='wikipage.html']"));
            wikiLink.Click();
            //Thread.Sleep(5000);
            //WaitForElementToBeVisible(driver, By.Id("htmlVersion"), 5);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            fluentWait.Message = "Element to be searched not found";
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotInteractableException));

            fluentWait.Until(x => x.FindElement(By.Id("htmlVersion")).Displayed);

            driver.FindElement(By.Id("htmlVersion")).SendKeys("test wiki");
            var isPresent = IsElementPresent(By.Id("htmlVersion"));
            Assert.IsTrue(isPresent);
            driver.Navigate().GoToUrl("https://google.com");
            Thread.Sleep(2000);
            driver.Navigate().Refresh();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.Navigate().Forward();
            Thread.Sleep(2000);

        }


        public void WaitForElementToBeVisible(IWebDriver driver, By element, int timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
        }

        private bool IsElementPresent(By element)
        {
            try
            {
                driver.FindElement(element);
                return true;
            }
            catch (NoSuchElementException err)
            {
                return false;
            }
        }

    }
}
