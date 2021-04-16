using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Browser
    {
        private readonly IWebDriver driver;


        public Browser(IWebDriver driver)
        {

            this.driver = driver;
        }

        public void CustomSendKeys(IWebElement element, string value)
        {
            WaitElementToBeDisplayed(driver, 10, element);
            element.SendKeys(value);
        }

        public void WaitElementToBeVisible(By element, int timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
        }

        public void WaitElementToBeDisplayed(IWebDriver driver, int timeout, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(n => element.Displayed);
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
