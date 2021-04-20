using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Utils;

namespace TestClassLibrary.Curs10
{
    class HomePage
    {
        private IWebDriver driver;
        //elements

        private IWebElement WikiLink 
        { get { return driver.FindElement(By.XPath("//*[@id='navHeader']//a[@href='wikipage.html']")); } }


        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public WikiPage NavigateOnWikiPage()
        {
            WikiLink.Click();
            return new WikiPage(driver);
        }
    }
}