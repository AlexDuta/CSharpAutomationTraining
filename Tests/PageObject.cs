using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Tests
{
    class PageObject
    {
        private IWebDriver driver;
        public PageObject(IWebDriver driver)
        {
            this.driver = driver;
        }
        private bool IsElementPresent(By element)
        {
            try
            {
                driver.FindElement(element);
                return true;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
        }
        public void WaitElementToBeVisible(IWebDriver driver, By elementBy, int timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(ExpectedConditions.ElementIsVisible(elementBy));
        }

        public void SendKeys(IWebElement element, string value)
        {
            WaitElementToBeDisplayed(driver, element, 5);
            element.SendKeys(value);
        }
        public void WaitElementToBeDisplayed(IWebDriver driver, IWebElement element, int timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(n => element.Displayed);
        }
    }
}
