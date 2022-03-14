using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class WikiPage
    {
        private IWebDriver driver;
        private Browser browser;

        private IWebElement PageHeaderText => driver.FindElement(By.TagName("h1"));
        private IWebElement TextAreaInput => driver.FindElement(By.Id("htmlVersion"));

        private SelectElement selectElement { get { return new SelectElement(driver.FindElement(By.Id("htmlversions"))); } }
        
        private ReadOnlyCollection<IWebElement> footer => driver.FindElements(By.XPath("//div//header//*[@id='navHeader']//a"));

        private ReadOnlyCollection<IWebElement> header => driver.FindElements(By.XPath("//div//header//*[@id='navHeader']//a"));

        public WikiPage(IWebDriver driver)
        {
            this.driver = driver;
            browser = new Browser(driver);
        }
        public WikiPage H1Displayed()
        {
            browser.WaitElementToBeVisible(driver, 10, PageHeaderText);
            Assert.IsTrue(PageHeaderText.Displayed);
            Assert.AreEqual("WikiPage", PageHeaderText.Text);
            return this;
        }

        public WikiPage SelectVersionDropDownByValue(string selectedValue)
        {
            selectElement.SelectByValue(selectedValue);
            return this;
        }

        public string TextAreaValue()
        {
            browser.WaitElementToBeVisible(driver, 10, TextAreaInput);
            return TextAreaInput.Text;
        }

        public void HeaderDisplayed()
        {
            foreach (var elm in header)
            {
                Assert.True(elm.Displayed);
            }

        }

        public void FooterDisplayed()
        {
            foreach (var elm in footer)
            {
                Assert.True(elm.Displayed);
            }

        }
    }
}
