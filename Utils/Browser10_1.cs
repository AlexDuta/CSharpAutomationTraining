using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Utils
{
    public class Browser10_1
    {
        public void WaitElementToBeVisible(IWebDriver driver, By element, int timeOut) 
        { 
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut)); 
            var waitCondition = wait.Until(c=>c.FindElement(element).Displayed); 
        }
        public void WaitElementToBeVisibleFluent(IWebDriver driver, By element, int timeOut)
        {
            DefaultWait<IWebElement> fluentWait = new DefaultWait<IWebElement>(driver.FindElement(element));
            fluentWait.Timeout = TimeSpan.FromSeconds(timeOut);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element to be searched not found";

            fluentWait.Until(x => x.Displayed);
        }

    }
}
