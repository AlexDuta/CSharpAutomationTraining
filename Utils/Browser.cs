using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Utils
{
    public class Browser
    {
        IWebDriver driver;

        //explicit Wait
        public void WaitElementToBeVisibleExplicit(IWebDriver driver, By element, int timeOut)
        {
            WebDriverWait explicitWait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
            explicitWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
        }

        //fluent Wait
        public void WaitElementToBeVisibleFluent(IWebDriver driver, By element)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(7);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            fluentWait.Message = "The element you searched was not found";
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Until(x => x.FindElement(element).Displayed);
        }
        public bool IsElementPresent(By element)
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
