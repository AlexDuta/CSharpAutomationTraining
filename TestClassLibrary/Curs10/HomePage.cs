using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace TestClassLibrary.Curs10
{
    class HomePage
    {
        private IWebDriver driver;
        private BrowserCurs10 browser;

        private IWebElement WikiLink { get { return driver.FindElement(By.XPath("//*[@id='navHeader']//a[@href='wikipage.html']")); } }

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            this.browser = new BrowserCurs10(driver);
        }

        public WikiPage NavigateToWikiPage()
        {
            WikiLink.Click();
            return new WikiPage(driver);
        }
    }
}
