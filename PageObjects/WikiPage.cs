using CoreProject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageObjects
{
     public class WikiPage
    {
        //H1 text is displayed and value equals “WikiPage”
        private IWebDriver driver;
        private Browser browser;

        private IWebElement PageHeaderText => driver.FindElement(By.TagName("h1"));
        private IWebElement TextAreaInput => driver.FindElement(By.Id("htmlVersion"));
      
        private SelectElement selectElement { get { return new SelectElement(driver.FindElement(By.Id("htmlversions"))); } }
      //  private IWebElement HeaderLinks  => driver.FindElements(By.XPath("//div//header//*[@id='navHeader']//a"));
        
        private ReadOnlyCollection<IWebElement> FooterLinks => driver.FindElements(By.XPath("//div//header//*[@id='navHeader']//a"));

        private ReadOnlyCollection<IWebElement> HeaderLinks => driver.FindElements(By.XPath("//div//header//*[@id='navHeader']//a"));

        public WikiPage(IWebDriver driver)
        {
            this.driver = driver;
            browser = new Browser(driver);
        }
        public WikiPage H1TextDesplayed()
        {
            browser.WaitElemetToBeDisplayed(driver, PageHeaderText, 5);
            bool isDisplayed = PageHeaderText.Displayed;
            Assert.IsTrue(isDisplayed);
            Assert.AreEqual("WikiPage" , PageHeaderText.Text);
            return this;
        }

        public WikiPage SelectVersionDropDownByValue(string selectedValue)
        {
            selectElement.SelectByValue(selectedValue);
            return this;
        }
        public WikiPage SelectVersionDropDownByText(string selectedValue)
        {
            selectElement.SelectByText(selectedValue);
            return this;
        }

        public string ReturnTextAreaValue()
        {
            browser.WaitElemetToBeDisplayed(driver, TextAreaInput, 5);
            return TextAreaInput.Text;
        }

        public void HeaderLinksDisplayed()
        {
            foreach (var elm in HeaderLinks)
            {
                Assert.True(elm.Displayed);
            }         
            
        }

        public void footerLinksDisplayed()
        {
            foreach (var elm in FooterLinks)
            {
                Assert.True(elm.Displayed);
            }

        }


    }
}
