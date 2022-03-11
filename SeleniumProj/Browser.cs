using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProj
{
    public class Browser
    {

        private IWebDriver driver;

        public Browser(IWebDriver driver)
        {
            this.driver = driver;
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

        public void WaitElementToBeVisible(IWebDriver driver, By elementBy, int timeout)
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
            catch (NoSuchElementException e)
            {
                return false;
            }
        }

    }
}
