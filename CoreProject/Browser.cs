using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace CoreProject
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
            WaitElemetToBeDisplayed(driver, element, 5);
            element.SendKeys(value);
        }

        public void WaitElemetToBeDisplayed(IWebDriver driver , IWebElement element, int timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(n => element.Displayed);

        }
        //element vizibil si prezent in html
        public void WaitElemetToBeVisible(IWebDriver driver, By elementBy, int timeout)
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
