using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;

namespace Utils
{
    class Browser
    {
        
        public void WaitElementToBeVisible1(IWebDriver driver, By Element, int timeout) 
        {
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(timeout));
            wait.Until(ExpectedConditions.ElementIsVisible(Element));
        }
        public void WaitElementToBeVisible2(IWebDriver driver, By Element, int timeout) 
        {
            DefaultWait<IWebDriver> defaultWait = new DefaultWait<IWebDriver>(driver);
            
            //Properties setting
            defaultWait.Timeout = TimeSpan.FromSeconds(timeout);
            defaultWait.PollingInterval = TimeSpan.FromMilliseconds(500);
            defaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            defaultWait.Message = "Default message";

            //Condition setting
            defaultWait.Until(ExpectedConditions.ElementIsVisible(Element));
        }

     
    }
}
