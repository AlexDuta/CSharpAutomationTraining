using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;


namespace Utils
{
    public class Browser 
    {
        
        public static IWebElement FluentWaitForElement(IWebDriver driver, By element)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element to be searched not found";
            IWebElement searchResult = fluentWait.Until(x => x.FindElement(element));
            return searchResult;
        }
        public static void ExplicitWaitForElement(IWebDriver driver, By element, int timeOut)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
            var waitCondition = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
        }

        public static void ClickOnElement(IWebDriver driver, By element)
        {
            FluentWaitForElement(driver, element);
           
            driver.FindElement(element).Click();
        }

        public static void EnterText(IWebDriver driver, string text, By element)
        {
            ExplicitWaitForElement(driver, element, 5);
            driver.FindElement(element).SendKeys(text);
        }

        public static bool CheckElementVisibility(IWebDriver driver, By element)
        {
           try
            {
                driver.FindElement(element);
                return true;
            }

            catch (NoSuchElementException e) {

                return false;
            }
           
        }

        public static void SelectByValue(IWebDriver driver, By byElement, string value)
        {
            IWebElement element = driver.FindElement(byElement);
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByValue(value);
        }
    }

}
