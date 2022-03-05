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
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace SeleniumProj
{
    [TestFixture]
    public class Class1
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
        public void FirstSeleniumTest()
        {
            SetUp();
            Assert.IsTrue(driver.Title.Equals("Home page"));


            //var header = driver.FindElement(By.Id("header"));

            //header.FindElement(By.XPath(".//a/img")).Click();










            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("admin@domain.org");
            driver.FindElement(By.Id("password")).SendKeys("111111");
            //driver.FindElement(By.Id("email")).Clear();

            driver.FindElement(By.Id("Login")).Click();

            Assert.IsTrue(driver.Title.Equals("Dashboard page"));

            var firstName = driver.FindElement(By.Id("firstname"));
            var getAttributeString = firstName.GetAttribute("value");

            Assert.AreEqual("Dave", getAttributeString, "info");

            var bikeCheckbox = driver.FindElement(By.XPath("//input[@value='Bike']"));
            bikeCheckbox.Click();
            Assert.AreEqual(true, bikeCheckbox.Selected);


            SelectElement dropdownList = new SelectElement(driver.FindElement(By.Id("htmlversions")));
            
            dropdownList.SelectByText("HTML 3.2");
            dropdownList.SelectByValue("5");


            var fileInput = driver.FindElement(By.Name("picture"));
            fileInput.SendKeys(@"C:\Users\DLeonties\OneDrive - ENDAVA\Desktop\dog.jpg");


            


            Actions action = new Actions(driver);
            //action.SendKeys(Keys.F5).Perform(); driver.Navigate().Refresh();

            var textArea = driver.FindElement(By.Id("textArea"));
            textArea.Click();

            textArea.SendKeys("TEST AUTOMATION BLA BLA");
            action.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).Perform();
            action.KeyDown(Keys.Control).SendKeys("c").KeyUp(Keys.Control).Perform();
            action.KeyDown(Keys.Control).SendKeys("v").KeyUp(Keys.Control).Perform();
            action.KeyDown(Keys.Control).SendKeys("v").KeyUp(Keys.Control).Perform();
            action.KeyDown(Keys.Control).SendKeys("v").KeyUp(Keys.Control).Perform();


            //var passwordErrorText = driver.FindElement(By.Id("passwordErrorText"));

            //Assert.IsTrue(passwordErrorText.Displayed);

            //var elementsList = driver.FindElements(By.XPath("//a"));

            //foreach(var elm in elementsList)
            //{
            //    Assert.IsTrue(elm.Displayed);
            //}

            TearDown();
            //driver.Quit();
            //driver.Close();

        }
    }
}
