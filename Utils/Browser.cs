using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestClassLibrary.Curs10;

namespace Utils
{
    public class Browser : TestBase
    {
        public void WaitElementToBeVisible(IWebDriver driver, By elementBy, int timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(ExpectedConditions.ElementIsVisible(elementBy));
        }

        public void WaitElementToBeVisible(IWebDriver driver, By elementBy)
        {
            DefaultWait<IWebDriver> defaultWait = new DefaultWait<IWebDriver>(driver);
            defaultWait.Timeout = TimeSpan.FromSeconds(5);
            defaultWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            defaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotInteractableException));
            defaultWait.Message = "Element to be searched was not found";
            defaultWait.Until(d => d.FindElement(elementBy).Displayed);
        }

        [Test]
        public void NavigateAndFill()
        {
            SetUp();

            IWebElement header = driver.FindElement(By.Id("header"));
            var url = header.FindElement(By.XPath(".//div/header/ul/a[2]"));



            url.Click();

            WaitElementToBeVisible(driver, By.Id("htmlVersion"));

            driver.FindElement(By.Id("htmlVersion")).SendKeys("Filling text area");

            TearDown();
        }

        [Test]
        public void TestH1Text()
        {
            SetUp();

            IWebElement header = driver.FindElement(By.Id("header"));
            var url = header.FindElement(By.XPath(".//div/header/ul/a[2]"));



            url.Click();

            WaitElementToBeVisible(driver, By.Id("htmlVersion"));

            var wikiPage = driver.FindElement(By.XPath("/html/body/div[1]/div/header/ul/a[2]"));

            Assert.IsTrue(wikiPage.Displayed);
            Assert.AreEqual("WikiPage", wikiPage.Text);

            SelectElement dropdownList = new SelectElement(driver.FindElement(By.Id("htmlversions")));

            dropdownList.SelectByText("HTML 2.0");
            dropdownList.SelectByText("HTML 3.2");
            dropdownList.SelectByText("HTML 4.0");
            dropdownList.SelectByText("HTML 5");

            IWebElement footer = driver.FindElement(By.XPath("/html/body/footer/ul"));

            var footerLinks = footer.FindElements(By.XPath("//a"));

            foreach(var link in footerLinks)
            {
                Assert.IsTrue(link.Displayed);
            }

            IWebElement head = driver.FindElement(By.XPath("/html/body/div[1]/div/header"));

            var headerLinks = head.FindElements(By.XPath("//ul/a"));

            foreach (var link in headerLinks)
            {
                Assert.IsTrue(link.Displayed);
            }


        }
    }
}
