using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Utils2;

namespace TestClassLibrary.Curs10
{

    class Homepage
    {
        private IWebDriver driver;

        //elements
        private IWebElement WikiLink { get { return driver.FindElement(By.XPath("//*[@id='navHeader']//a[@href='wikipage.html']")); } }

        // constructor
        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //metoda
        public WikiPage NavigateToWikiPage()
        {
            WikiLink.Click();
            return new WikiPage(driver);
        }
    }

  
}
