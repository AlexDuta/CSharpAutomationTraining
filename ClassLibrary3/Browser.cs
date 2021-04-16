using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Browser
    {
        IWebDriver driver;

        public Browser(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void CustomSendKeys(IWebElement element, string textInput)
        {
            WaiTElementToBeDisplayed(element, 5);
            element.SendKeys(textInput);
        }


        public void WaiTElementToBeDisplayed(IWebElement element, int timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(x => element.Displayed);
        }

        public void WaitForElementToBeVisible(IWebDriver driver, By element, int timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
        }

        private bool IsElementPresent(By element)
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
