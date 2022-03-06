using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;


namespace Utils
{
    public class BrowserTema10
    {
       
        public void WaitElemetToBeVisibleExplicit(IWebDriver driver, By elementBy, int timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            var waitCondititon = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(elementBy));
        }
        public void WaitElemetToBeVisibleFluent(IWebDriver driver, By elementBy, int timeout)
        { 
             DefaultWait<IWebDriver> defaultWait = new DefaultWait<IWebDriver>(driver);
             defaultWait.Timeout = TimeSpan.FromSeconds(timeout);
             defaultWait.PollingInterval = TimeSpan.FromMilliseconds(250);
             defaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotInteractableException));
             defaultWait.Message = "Element ";
             defaultWait.Until(driver1 =>driver1.FindElement(elementBy).Displayed);
        }
    }
}
