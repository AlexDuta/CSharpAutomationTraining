using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PageObjects
{
    class Wikipage
    {
        private IWebDriver driver;
        private PageObject pageObject;

        private IWebElement PageHeaderText => driver.FindElement(By.TagName("h1"));
        private IWebElement TextAreaField => driver.FindElement(By.Id("htmlVersion"));
        


        public Wikipage(IWebDriver driver)
        {
            this.driver = driver;
            this.pageObject = new PageObject(driver);
        }
       
    }
}
