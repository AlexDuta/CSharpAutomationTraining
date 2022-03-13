using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using SeleniumProject;
using NUnit.Framework;

namespace Utils
{
    public class Browser : TestBase
    {
        public void WaitElementToBeVisible(IWebDriver driver, By element, int timeOut)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
            var waitCondition = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
        }

        public void WaitElementToBeVisible(IWebDriver driver, By element)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element to be searched not found";
            IWebElement searchResult = fluentWait.Until(x => x.FindElement(By.Id("htmlVersion")));
        }

        [Test]
        public void Test1Curs10()
        {
            IWebElement header = driver.FindElement(By.Id("header"));
            var webElement = header.FindElement(By.XPath("//a[@href='wikipage.html']"));
            webElement.Click();
            WaitElementToBeVisible(driver, By.Id("htmlVersion"), 10);
            driver.FindElement(By.Id("htmlVersion")).SendKeys("Text1");
           
        }

        [Test]
        public void Test2Curs10()
        {
            driver.FindElement(By.XPath(".//*[@id='navHeader']/a[2]")).Click();
            WaitElementToBeVisible(driver, By.XPath(".//*[@id='htmlVersion']"), 10);

            var webElement = driver.FindElement(By.XPath("//h1"));

            Assert.IsTrue(webElement.Displayed);
            Assert.AreEqual("WikiPage", webElement.Text);

            SelectElement dropList = new SelectElement(driver.FindElement(By.Id("htmlversions")));

            dropList.SelectByText("HTML 2.0");
            dropList.SelectByText("HTML 3.2");
            dropList.SelectByText("HTML 4.0");
            dropList.SelectByText("HTML 5");


            IWebElement header = driver.FindElement(By.XPath("//header"));
            var elements = header.FindElements(By.XPath(".//a"));
            foreach (var element in elements)
            {
                Assert.True(element.Displayed);
            }

            IWebElement footer= driver.FindElement(By.XPath("//footer"));
            var elements1 =footer.FindElements(By.XPath(".//a"));
            foreach (var element in elements1)
            {
                Assert.True(element.Displayed);
            }



        }
    }
}
