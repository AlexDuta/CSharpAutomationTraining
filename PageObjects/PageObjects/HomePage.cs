using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class HomePage
    {
        private IWebDriver driver;
        private IWebElement WikiPageLink;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            WikiPageLink = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[2]/a")); 
        }
        
        public WikiPage WikiPageClick()
        {
            WikiPageLink.Click();
            return new WikiPage(driver);
        }

    }
}
