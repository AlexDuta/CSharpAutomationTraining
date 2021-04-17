using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;
using System.Threading.Tasks;

namespace TestClassLibrary.Curs10
{
    class HomePageScreen
    {
        private IWebDriver driver;
        
        private By wikiButton = By.XPath("//*[@id='navHeader']/a[2]");

        public HomePageScreen(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClickOnWikiButton()
        {
            Utils.Browser.ClickOnElement(driver, wikiButton);
        }

    }
}
