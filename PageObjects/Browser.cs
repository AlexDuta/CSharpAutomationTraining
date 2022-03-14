using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace PageObjects
{
    public class Browser 
    {
        IWebDriver driver;

        public Browser(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void WaitElementToBeVisible(IWebDriver driver, int seconds, IWebElement element) 
        { 
            new WebDriverWait(driver, TimeSpan.FromSeconds(seconds)).Until(n => element.Displayed); 
        }

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

       
    }
}
